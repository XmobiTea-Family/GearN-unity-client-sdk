# Ví dụ: Push Campaign — gửi push notification cho segment user theo tag / level / last-active

Tính năng: gửi thông báo đẩy cho một nhóm user lọc theo điều kiện (tag, level tối thiểu, hoạt động gần đây). Client đăng ký device token; campaign handler query token theo segment rồi gửi bulk qua `pushNotification.sendToMore`. Registry token lưu trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_pushNotification.md](/docs/cloudScript/CLOUDSCRIPT_pushNotification.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Push.DeviceToken", gameId)`
- Full name (index): `"Runtime." + gameId + ".Push.DeviceToken"`

Document shape (1 doc / user — denormalize sẵn field segment để query nhanh):

```ts
type DeviceToken = {
    userId: string;
    token: string;          // FCM/APNs device token client cung cấp
    platform: string;       // "android" | "ios"
    level: number;          // level hiện tại — để lọc segment
    lastActiveTs: number;   // Date.now() lần hoạt động gần nhất
    tags: string[];         // tag segment, vd ["whale", "vn-region"]
    tsUpdate: number;
};
```

Index:

- `{ userId: 1 }` **unique** — 1 token / user, cho upsert.
- `{ level: 1 }`, `{ lastActiveTs: 1 }`, `{ tags: 1 }` — lọc segment.

> Vì sao denormalize `level`/`tags`/`lastActiveTs` vào chính registry token thay vì join sang GamePlayer mỗi lần gửi: campaign quét hàng nghìn user, join từng người sẽ chậm. Client cập nhật các field này khi đăng ký/đăng nhập. Nếu cần segment chính xác tuyệt đối theo dữ liệu GearN, dùng `database.gamePlayerRepository.loadGamePlayersWithTagAsync(...)` ([cloudScript/CLOUDSCRIPT_database.md:140-145](/docs/cloudScript/CLOUDSCRIPT_database.md)) rồi map sang token — đánh đổi tốc độ.

---

## 2. Script TypeScript

```ts
const PUSH_COLLECTION = "Push.DeviceToken";
const PUSH_BATCH_SIZE = 500;          // số token / lần sendToMore
const PUSH_CAMPAIGN_SCAN_MAX = 50000; // chặn quét vô hạn
// Whitelist user được phép bắn campaign.
const PUSH_ADMIN_USER_IDS: string[] = ["REPLACE_WITH_ADMIN_USER_ID"];

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

// Client đăng ký / cập nhật device token + field segment
handlers["pushRegisterToken"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const token = requireString(args?.token, "token");
    const platform = typeof args?.platform === "string" ? args.platform : "android";
    const level = typeof args?.level === "number" ? Math.floor(args.level) : 1;
    const tags = Array.isArray(args?.tags) ? args.tags.filter((t: unknown) => typeof t === "string") : [];

    const collection = database.runtimeGameCollection(PUSH_COLLECTION, gameId);
    const now = Date.now();

    await collection.updateOne(
        { userId: userId },
        {
            $set: {
                userId: userId,
                token: token,
                platform: platform,
                level: level,
                lastActiveTs: now,
                tags: tags,
                tsUpdate: now,
            },
        },
        { upsert: true },
    );

    return { registered: true };
};

// Gọi mỗi lần login để giữ lastActiveTs/level mới
handlers["pushTouchActivity"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(PUSH_COLLECTION, gameId);

    const set: Record<string, unknown> = { lastActiveTs: Date.now() };
    if (typeof args?.level === "number") set.level = Math.floor(args.level);

    const result = await collection.updateOne({ userId: userId }, { $set: set });
    return { updated: (result.matchedCount ?? 0) > 0 };
};

// Bắn campaign — CHỈ admin / trusted (xem §5).
handlers["pushCampaignSend"] = async (args: Record<string, unknown>, context, log) => {
    if (PUSH_ADMIN_USER_IDS.indexOf(context.userId) < 0) {
        throw new Error("forbidden: not a campaign admin");
    }
    const title = requireString(args?.title, "title");
    const body = requireString(args?.body, "body");

    // Xây filter segment từ args
    const filter: Record<string, unknown> = {};
    if (typeof args?.tag === "string" && args.tag.length > 0) {
        filter.tags = args.tag; // match phần tử trong mảng tags
    }
    if (typeof args?.minLevel === "number") {
        filter.level = { $gte: Math.floor(args.minLevel) };
    }
    if (typeof args?.activeWithinMs === "number") {
        filter.lastActiveTs = { $gte: Date.now() - args.activeWithinMs };
    }

    const collection = database.runtimeGameCollection(PUSH_COLLECTION, gameId);
    const cursor = collection.find(filter, { projection: { _id: 0, token: 1 } }).limit(PUSH_CAMPAIGN_SCAN_MAX);

    let batch: string[] = [];
    let sentCount = 0;

    // Đẩy theo từng batch để không giữ cả chục nghìn token trong RAM
    const flush = async (): Promise<void> => {
        if (batch.length === 0) return;
        await pushNotification.sendToMore(batch, title, body, 1, "default", "ic_notification", {
            source: "pushCampaign",
            gameId: gameId,
        });
        sentCount += batch.length;
        batch = [];
    };

    while (await cursor.hasNext()) {
        const doc = await cursor.next();
        if (doc != null && typeof doc.token === "string" && doc.token.length > 0) {
            batch.push(doc.token);
            if (batch.length >= PUSH_BATCH_SIZE) {
                await flush();
            }
        }
    }
    await flush();

    return { campaignSent: true, recipientCount: sentCount };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initPushCampaign"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + PUSH_COLLECTION;
    await database.createIndex(fullName, { userId: 1 }, { unique: true });
    await database.createIndex(fullName, { level: 1 });
    await database.createIndex(fullName, { lastActiveTs: 1 });
    await database.createIndex(fullName, { tags: 1 });
    return { ok: true };
};
```

> Thay thế cho registry token tự quản: nếu game phân nhóm cố định, dùng topic — client `subscribeToTopic` theo segment, campaign chỉ cần `pushNotification.sendToTopic(topic, ...)`, không phải quét DB. Topic phù hợp segment ít thay đổi; registry + filter phù hợp segment động theo level/last-active.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = pushCampaignScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initPushCampaign` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)). Push notification cần GearN Server đã setup PushNotificationSettings (Dashboard → Settings/PushNotification).

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

// Gọi sau khi lấy được FCM/APNs token từ plugin push của Unity
public System.Threading.Tasks.Task<object> PushRegisterTokenAsync(string token, string platform, int level, System.Collections.Generic.List<string> tags)
    => ExecuteAsync("pushRegisterToken", GNHashtable.builder()
        .add("token", token).add("platform", platform).add("level", level).add("tags", tags).build());

// Gọi mỗi lần login
public System.Threading.Tasks.Task<object> PushTouchActivityAsync(int level)
    => ExecuteAsync("pushTouchActivity", GNHashtable.builder().add("level", level).build());
```

UI flow:

1. App khởi động, lấy được device token từ plugin push → `PushRegisterTokenAsync(...)`.
2. Mỗi lần login → `PushTouchActivityAsync(level)` để `lastActiveTs`/`level` luôn mới.
3. `pushCampaignSend` chạy từ admin tool / cron backend, KHÔNG từ game client.

---

## 5. Cảnh báo

- `pushCampaignSend` check whitelist `PUSH_ADMIN_USER_IDS` — nếu mở, user bất kỳ tự bắn spam toàn bộ player. Whitelist hard-code là tối thiểu; thực tế đọc admin list từ dashboard config.
- Gửi theo batch (`PUSH_BATCH_SIZE`) và `cursor` streaming — KHÔNG `toArray()` cả chục nghìn token vào RAM. `PUSH_CAMPAIGN_SCAN_MAX` chặn quét vô hạn.
- Device token hết hạn / bị thu hồi: `sendToMore` với token chết không throw lỗi rõ ràng. Định kỳ dọn token cũ (vd `deleteMany({ lastActiveTs: { $lt: now - 90 ngày } })`).
- KHÔNG return danh sách token ra response — token là dữ liệu nhạy cảm, chỉ trả `recipientCount`.
- `pushNotification` chỉ tới được thiết bị đã cài app + cho phép push. User online cần realtime trong session thì dùng `socket` ([cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md)) — push không thay được.
- Filter `tags: "<value>"` match phần tử trong mảng — đúng cho field mảng. Đừng dùng `$elemMatch` thừa cho match bằng đơn giản.
- Campaign lớn có thể chạy lâu hơn timeout của 1 lần `executeFunction`. Nếu segment rất lớn, chia campaign theo nhiều lần gọi (phân trang theo `lastActiveTs`) hoặc chạy từ cron backend, không ép 1 handler quét hết.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
