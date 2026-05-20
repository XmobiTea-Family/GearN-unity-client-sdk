# Ví dụ: Daily Login Streak — đếm ngày liên tiếp, reset khi bỏ lỡ, payout tăng dần

Tính năng: mỗi ngày user check-in 1 lần. Streak tăng nếu check-in đúng ngày kế tiếp; reset về 1 nếu bỏ lỡ ≥ 1 ngày. Payout currency tăng dần theo streak qua `admin.gamePlayer.changePlayerCurrencyAsync` (giữ audit log SDK). Anti-double-checkin bằng atomic CAS filter theo "ngày" (day index UTC), không phải cooldown 24h trôi.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("LoginStreak.State", gameId)`
- Full name (index): `"Runtime." + gameId + ".LoginStreak.State"`

Document shape (1 doc / user):

```ts
type LoginStreakState = {
    userId: string;
    streak: number;        // số ngày liên tiếp đã check-in
    lastDayIndex: number;  // day index UTC của lần check-in gần nhất; -1 nếu chưa từng
    tsLastCheckin: number; // Date.now() lần check-in gần nhất
};
```

Index: `{ userId: 1 }` **unique** — cho atomic upsert + CAS filter theo `lastDayIndex`.

Khái niệm "ngày": `dayIndex = Math.floor(Date.now() / 86_400_000)` — số ngày kể từ epoch UTC. So sánh `dayIndex` thay vì so `Date.now()` để "1 ngày" là ranh giới lịch UTC, không phải khung 24h trôi.

Reward theo streak: bảng `[100, 150, 200, 300, 500, 700, 1000]`; streak ≥ 7 dùng giá trị cuối.

> Khác biệt với cooldown 24h: cooldown đo "đủ 24h chưa". Login streak đo "đã sang ngày mới chưa". Check-in lúc 23:00 rồi 00:30 hôm sau vẫn là 2 ngày khác nhau dù chỉ cách 1.5h.

---

## 2. Script TypeScript

```ts
const LS_COLLECTION = "LoginStreak.State";
const LS_DAY_MS = 24 * 60 * 60 * 1000;
const LS_REWARD_TABLE = [100, 150, 200, 300, 500, 700, 1000];
const LS_CURRENCY_KEY = "gold";

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

const dayIndexOf = (ts: number): number => Math.floor(ts / LS_DAY_MS);

const rewardForStreak = (streak: number): number => {
    const idx = Math.min(Math.max(streak, 1), LS_REWARD_TABLE.length) - 1;
    return LS_REWARD_TABLE[idx];
};

handlers["loginStreakStatus"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(LS_COLLECTION, gameId);
    const doc = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });

    const today = dayIndexOf(Date.now());
    const lastDayIndex = doc?.lastDayIndex ?? -1;
    const streak = doc?.streak ?? 0;

    const canCheckin = lastDayIndex !== today;
    // streak kế tiếp: nối nếu hôm nay liền sau lastDay, reset nếu bỏ lỡ
    const nextStreak = lastDayIndex === today - 1 ? streak + 1 : 1;

    return {
        canCheckin: canCheckin,
        streak: streak,
        nextStreak: nextStreak,
        nextReward: rewardForStreak(nextStreak),
        checkedInToday: lastDayIndex === today,
    };
};

handlers["loginCheckin"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(LS_COLLECTION, gameId);
    const now = Date.now();
    const today = dayIndexOf(now);

    const existing = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    const lastDayIndex = existing?.lastDayIndex ?? -1;
    const prevStreak = existing?.streak ?? 0;

    if (lastDayIndex === today) {
        throw new Error("already_checked_in_today");
    }

    // Liền ngày → nối streak; bỏ lỡ ≥ 1 ngày (hoặc lần đầu) → reset về 1
    const newStreak = lastDayIndex === today - 1 ? prevStreak + 1 : 1;
    const reward = rewardForStreak(newStreak);

    // CAS atomic: chỉ ghi khi lastDayIndex chưa đổi → chống double-checkin concurrent
    const filter = lastDayIndex === -1
        ? { userId: userId, lastDayIndex: { $exists: false } }
        : { userId: userId, lastDayIndex: lastDayIndex };

    const updateResult = await collection.updateOne(
        filter,
        { $set: { userId: userId, streak: newStreak, lastDayIndex: today, tsLastCheckin: now } },
        { upsert: lastDayIndex === -1 },
    );
    if ((updateResult.modifiedCount ?? 0) === 0 && (updateResult.upsertedCount ?? 0) === 0) {
        throw new Error("race_lost: checkin đã được xử lý bởi request khác");
    }

    try {
        const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
        currencyParam.key = LS_CURRENCY_KEY;
        currencyParam.value = reward;

        const payoutRequest = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
        payoutRequest.userId = userId;
        payoutRequest.playerCurrencies = [currencyParam];
        payoutRequest.log = "loginStreak checkin streak=" + newStreak;

        const payoutResponse = await admin.gamePlayer.changePlayerCurrencyAsync(payoutRequest);
        assertResponseOk(payoutResponse, "admin.gamePlayer.changePlayerCurrencyAsync");
    } catch (payoutError) {
        // Rollback về state cũ để user check-in lại
        await collection.updateOne(
            { userId: userId },
            { $set: { streak: prevStreak, lastDayIndex: lastDayIndex } },
        );
        throw payoutError;
    }

    return {
        checkedIn: true,
        streak: newStreak,
        reward: reward,
        currencyKey: LS_CURRENCY_KEY,
        dayIndex: today,
    };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initLoginStreak"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + LS_COLLECTION;
    await database.createIndex(fullName, { userId: 1 }, { unique: true });
    return { ok: true };
};
```

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = loginStreakScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initLoginStreak` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)).

---

## 4. Unity client

Pattern 3-tier check (`returnCode` → `errorCode` → `ExecuteResponseStatus`) — [guides/CLOUDSCRIPT.md:162-185](/docs/guides/CLOUDSCRIPT.md).

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> ExecuteAsync(string functionName, GNHashtable parameters)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = functionName;
    requestData.functionParameters = parameters;

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);
    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    return exec.functionResult;
}

public System.Threading.Tasks.Task<object> LoginStreakStatusAsync()
    => ExecuteAsync("loginStreakStatus", GNHashtable.builder().build());

public System.Threading.Tasks.Task<object> LoginCheckinAsync()
    => ExecuteAsync("loginCheckin", GNHashtable.builder().build());
```

UI flow:

1. Mở app → `LoginStreakStatusAsync` → render `streak`, `nextReward`, nút Check-in bật khi `canCheckin`.
2. User bấm Check-in → `LoginCheckinAsync` → hiện reward + streak mới.
3. Throw `already_checked_in_today` → UI lệch ngày với server, refresh status. Throw `race_lost` → 2 thiết bị cùng check-in, refresh.

---

## 5. Cảnh báo

- KHÔNG dùng `Date.now()` của client để quyết "đã sang ngày mới chưa" — luôn để server tính `dayIndex`. Client chỉ render trạng thái từ response.
- "Ngày" ở đây là ngày UTC. Nếu game cần reset theo timezone cụ thể (vd 00:00 giờ VN), trừ offset trước khi chia: `Math.floor((now + offsetMs) / LS_DAY_MS)`. Phải nhất quán giữa `loginStreakStatus` và `loginCheckin`.
- KHÔNG thay CAS filter `lastDayIndex` bằng `replaceOne` không filter — mất anti-double-checkin, 2 request song song sẽ check-in đôi và payout đôi.
- Payout fail thì handler rollback `streak`/`lastDayIndex` về giá trị cũ. Nếu rollback CŨNG fail, state kẹt — thêm fail-log collection nếu reward lớn.
- KHÔNG payout bằng `database.gamePlayerRepository.loadGamePlayerAsync(...)` + `saveAsync()` — bỏ qua audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- `LS_REWARD_TABLE` cứng trong script; muốn config-driven thì đọc từ `database.systemGameCollection("LoginStreak.Config", gameId)`.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
