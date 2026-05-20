# Ví dụ: Email Verify — gửi mã 6 số, verify, gán flag verified vào MasterPlayer

Tính năng: xác thực email của user. Server gửi mã 6 số qua email, user nhập mã để verify; verify thành công thì gán tag `emailVerified` vào MasterPlayer. Token mã lưu trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; gửi email qua `mail`; gán flag qua `admin.masterPlayer.setTagAsync`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_mail.md](/docs/cloudScript/CLOUDSCRIPT_mail.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("EmailVerify.Token", gameId)`
- Full name (index): `"Runtime." + gameId + ".EmailVerify.Token"`

Document shape (1 doc / user — token mới ghi đè token cũ):

```ts
type EmailVerifyToken = {
    userId: string;
    email: string;        // email đang xin verify
    code: string;         // mã 6 số
    attempts: number;     // số lần nhập sai
    consumed: boolean;    // đã verify thành công chưa
    tsCreate: number;
    tsExpire: number;     // Date.now() + TTL; index TTL tự dọn token hết hạn
    tsLastSend: number;   // chống spam gửi mã
};
```

Index:

- `{ userId: 1 }` **unique** — 1 token sống / user.
- `{ tsExpire: 1 }` với `{ expireAfterSeconds: 0 }` — Mongo TTL tự dọn token hết hạn.

Constants: mã sống `10 phút`; tối đa `5` lần nhập sai; gửi lại mã cách nhau ≥ `60s`.

---

## 2. Script TypeScript

```ts
const EV_COLLECTION = "EmailVerify.Token";
const EV_CODE_TTL_MS = 10 * 60 * 1000;
const EV_MAX_ATTEMPTS = 5;
const EV_RESEND_COOLDOWN_MS = 60 * 1000;
const EV_VERIFIED_TAG_KEY = "emailVerified";

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

// Validate email tối thiểu — không tham regex phức tạp
const requireEmail = (raw: unknown): string => {
    const email = requireString(raw, "email").toLowerCase();
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
        throw new Error("invalid_email");
    }
    return email;
};

const random6Digits = (): string => {
    return String(Math.floor(100000 + Math.random() * 900000));
};

handlers["emailRequestCode"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const email = requireEmail(args?.email);

    const collection = database.runtimeGameCollection(EV_COLLECTION, gameId);
    const now = Date.now();

    const existing = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    if (existing != null && now - (existing.tsLastSend ?? 0) < EV_RESEND_COOLDOWN_MS) {
        throw new Error("resend_too_soon: msRemaining=" + (EV_RESEND_COOLDOWN_MS - (now - existing.tsLastSend)));
    }

    const code = random6Digits();
    await collection.updateOne(
        { userId: userId },
        {
            $set: {
                userId: userId,
                email: email,
                code: code,
                attempts: 0,
                consumed: false,
                tsCreate: now,
                tsExpire: now + EV_CODE_TTL_MS,
                tsLastSend: now,
            },
        },
        { upsert: true },
    );

    // Gửi email. Mã nằm TRONG email, KHÔNG trả về client.
    const html = "<h2>Xác thực email</h2>"
        + "<p>Mã xác thực của bạn là: <b style='font-size:20px'>" + code + "</b></p>"
        + "<p>Mã có hiệu lực trong 10 phút.</p>";
    await mail.send(email, "Mã xác thực email", html);

    return { sent: true, email: email, expiresInMs: EV_CODE_TTL_MS };
};

handlers["emailVerifyCode"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const inputCode = requireString(args?.code, "code");

    const collection = database.runtimeGameCollection(EV_COLLECTION, gameId);
    const now = Date.now();

    const token = await collection.findOne({ userId: userId }, { projection: { _id: 0 } });
    if (token === null || token.consumed === true) {
        throw new Error("no_pending_code");
    }
    if (now > token.tsExpire) {
        throw new Error("code_expired");
    }
    if ((token.attempts ?? 0) >= EV_MAX_ATTEMPTS) {
        throw new Error("too_many_attempts");
    }

    if (token.code !== inputCode) {
        // Tăng đếm sai. CAS theo attempts cũ để không bị race underflow.
        await collection.updateOne({ userId: userId }, { $inc: { attempts: 1 } });
        throw new Error("wrong_code: remaining=" + (EV_MAX_ATTEMPTS - (token.attempts ?? 0) - 1));
    }

    // Đúng mã → CAS đánh dấu consumed (chống verify đôi)
    const consumeResult = await collection.updateOne(
        { userId: userId, consumed: false },
        { $set: { consumed: true } },
    );
    if ((consumeResult.modifiedCount ?? 0) === 0) {
        throw new Error("already_verified");
    }

    // Gán tag emailVerified vào MasterPlayer (account-level)
    try {
        const tagRequest = new MasterPlayerModels.AdminSetTagRequestData();
        tagRequest.userId = userId;
        tagRequest.key = EV_VERIFIED_TAG_KEY;
        tagRequest.value = "true";

        const tagResponse = await admin.masterPlayer.setTagAsync(tagRequest);
        assertResponseOk(tagResponse, "admin.masterPlayer.setTagAsync");
    } catch (tagError) {
        // Rollback consumed để user verify lại
        await collection.updateOne({ userId: userId }, { $set: { consumed: false } });
        throw tagError;
    }

    return { verified: true, email: token.email };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initEmailVerify"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + EV_COLLECTION;
    await database.createIndex(fullName, { userId: 1 }, { unique: true });
    await database.createIndex(fullName, { tsExpire: 1 }, { expireAfterSeconds: 0 });
    return { ok: true };
};
```

> Vì sao tag emailVerified gán vào MasterPlayer chứ không GamePlayer: email là định danh cấp tài khoản, dùng chung mọi game. Gán ở MasterPlayer → mọi game của user đó đều thấy `emailVerified`. Nếu verify mang ý nghĩa riêng từng game, đổi sang `admin.gamePlayer.setTagAsync`.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = emailVerifyScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initEmailVerify` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)). Gửi email cần GearN Server đã setup EmailSettings (Dashboard → Settings/Email).

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

public System.Threading.Tasks.Task<object> EmailRequestCodeAsync(string email)
    => ExecuteAsync("emailRequestCode", GNHashtable.builder().add("email", email).build());

public System.Threading.Tasks.Task<object> EmailVerifyCodeAsync(string code)
    => ExecuteAsync("emailVerifyCode", GNHashtable.builder().add("code", code).build());
```

UI flow:

1. User nhập email → `EmailRequestCodeAsync(email)`. Throw `resend_too_soon` → disable nút gửi tới hết cooldown.
2. User nhập mã 6 số từ email → `EmailVerifyCodeAsync(code)`. Throw `wrong_code: remaining=N` → hiện số lần còn lại; `code_expired` → cho gửi lại; `too_many_attempts` → khóa, yêu cầu gửi mã mới.
3. Success → cập nhật UI "email đã xác thực".

---

## 5. Cảnh báo

- Mã 6 số nằm TRONG email, KHÔNG bao giờ trả về response của `emailRequestCode`. Trả về = bỏ qua toàn bộ ý nghĩa verify.
- `emailVerifyCode` giới hạn `EV_MAX_ATTEMPTS` lần nhập sai — chống brute-force mã 6 số (1 triệu khả năng). Không có giới hạn này, attacker dò mã trong vài giây.
- `emailRequestCode` có cooldown `EV_RESEND_COOLDOWN_MS` — chống spam gửi mail (tốn quota email service, làm phiền chủ email).
- KHÔNG cho client tự quyết "đã verify" — chỉ server gán tag sau khi mã khớp. Tag `emailVerified` trên MasterPlayer là nguồn sự thật.
- Mã 6 số entropy thấp; với email có giá trị cao (khôi phục tài khoản) cân nhắc mã dài hơn hoặc magic-link token ngẫu nhiên dài.
- `mail.send` là bridge fire-and-forget — `await` không đảm bảo email tới hộp thư. Nếu user báo không nhận, cho gửi lại sau cooldown.
- Token hết hạn tự xóa nhờ index TTL `tsExpire`. Verify thành công vẫn để doc lại tới khi TTL dọn (field `consumed:true` chặn dùng lại) — không cần `deleteOne` thủ công.
- Gán tag fail thì rollback `consumed`. Rollback fail → user kẹt; cho user thử `emailVerifyCode` lại (mã vẫn còn nếu chưa hết hạn).
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
