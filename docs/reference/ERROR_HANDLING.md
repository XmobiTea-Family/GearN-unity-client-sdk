# Reference: Error Handling

Mọi response từ GearN backend đi qua 2 tầng kiểm tra. AI consumer phải check đủ cả hai, đúng thứ tự.

## Pattern bắt buộc

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new AuthenticateModels.LoginByAccountRequestData();
requestData.username = username;
requestData.password = password;
requestData.infoRequestParam = new AuthenticateModels.InfoRequestParam();

var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);

// 1. Kiểm tra returnCode (transport/gateway)
if (response.returnCode != ReturnCode.Ok) {
    handleTransportFailure(response);
    return;
}

// 2. Kiểm tra errorCode (business domain)
if (response.errorCode != ErrorCode.Ok) {
    handleDomainFailure(response);
    return;
}

// 3. Happy path: trust typed payload
useResult(response.responseData);
```

Typed response (trả từ mọi `*Async()` và callback path) expose field `public`:

- `res.returnCode: number` — tầng 1
- `res.errorCode: number` — tầng 2 (chỉ set khi `returnCode == Ok`)
- `res.invalidMembers: InvalidMember[]` — khi `returnCode == InvalidRequestParameters`
- `res.debugMessage: string` — backend debug message
- `res.responseData: T` — typed payload. Khi code tích hợp đọc kết quả nghiệp vụ, chỉ dùng sau khi `returnCode == Ok` và `errorCode == Ok`.

**Rule cứng:**

- Không skip tầng 1 để đọc thẳng `errorCode`. Nếu `returnCode != Ok`, `errorCode` và typed parameters **không đáng tin**.
- Không giả định success là `0`. Success ở cả hai tầng là `1` (`ReturnCode.Ok == 1`, `ErrorCode.Ok == 1`).
- Không hardcode số. Luôn so sánh bằng symbol `ReturnCode.*` / `ErrorCode.*`.
- `Async` method vẫn return response object (không throw) — reject chỉ xảy ra khi transport layer lỗi thực sự (network down, serialization fail).

**Helper method tương đương:**

- `res.hasReturnCodeError(): boolean` — tương đương `res.returnCode !== ReturnCode.Ok`. Dùng cho code throw-style ngắn gọn.
- Không có helper cho tầng 2 — dùng `res.errorCode !== ErrorCode.Ok` trực tiếp.

```csharp
// Field public (early-return):
if (res.returnCode !== ReturnCode.Ok) return;
if (res.errorCode !== ErrorCode.Ok) return;

// Helper method (throw-style):
if (res.hasReturnCodeError()) throw new System.Exception(res.debugMessage ?? res.ToString());
if (res.errorCode !== ErrorCode.Ok) throw new System.Exception(`business error: ${res.errorCode}`);
```

---

## Tầng 1: `ReturnCode`

Kiểm tra bằng `res.returnCode`. So sánh bằng enum symbol. Giá trị numeric: [ENUMS.md § ReturnCode](/docs/reference/ENUMS.md#returncode).

<!-- prettier-ignore -->
| ReturnCode | Khi nào gặp | Recommended action |
| --- | --- | --- |
| `Ok` | Happy path | Sang tầng 2 check `errorCode` |
| `UnknownError` | Backend fail nhưng không map code cụ thể | Log + show lỗi chung; không retry tự động |
| `OperationTimeout` | Request timeout (SDK hoặc backend) | Retry với backoff nếu operation idempotent; báo user nếu không |
| `OperationNotAllow` | Permission rule của secret key không cho chạy operation ở target context | Sai route (`client/server/admin`) hoặc secret thiếu `selfEnable`/`otherSelfEnable`/`serverSelfEnable`/`adminSelfEnable`. Không retry — fix config. Checklist chi tiết: [RULES.md § 6](/docs/RULES.md#6-permission-flags) |
| `InternalServerError` | Backend crash internal | Log + show lỗi chung; có thể retry 1 lần rồi escalate |
| `OperationInvalid` | Operation code không tồn tại / sai với request type + role | Sai namespace: kiểm tra đang gọi đúng `GNNetwork.<domain>.<method>`. Không retry |
| `InvalidRequestParameters` | Request shape / field invalid | Đọc `res.invalidMembers`; fix field rồi gửi lại |
| `OperationNotAuthorized` | Caller không auth với role/target resource | Kiểm tra `authToken` hợp lệ; re-login hoặc refresh token |
| `MaxCCUReject` | Vượt concurrent user limit | Backoff + retry; escalate lên ops nếu recurring |
| `MaxRequestReject` | Vượt rate limit | Exponential backoff retry; xem lại client usage pattern |
| `MaxSizeRequestReject` | Payload vượt max size | Không retry; giảm size request (paginate, split) |
| `SecretInvalid` | Secret key sai / thiếu / không khớp game | Fix cấu hình `GNServerSettings`, không retry |

### Khi gặp `InvalidRequestParameters`

Response expose thêm `res.invalidMembers: InvalidMember[]`:

```csharp
public class InvalidMember
{
    public string code; // field name (ParameterCode)
    public InvalidMemberType invalidMemberType;
}
```

`InvalidMemberType` xem [ENUMS.md § InvalidMemberType](/docs/reference/ENUMS.md#invalidmembertype). Ví dụ parse:

```csharp
if (res.returnCode == ReturnCode.InvalidRequestParameters) {
    foreach (var im in res.invalidMembers ?? new System.Collections.Generic.List<InvalidMember>()) {
        UnityEngine.Debug.LogWarning("field " + im.code + " invalid: type=" + im.invalidMemberType);
    }
}
```

---

## Tầng 2: `ErrorCode`

Chỉ check sau khi `returnCode == ReturnCode.Ok`. Lấy qua `response.errorCode` (field public trên typed response class).

Bảng đầy đủ 50 giá trị xem [ENUMS.md § ErrorCode](/docs/reference/ENUMS.md#errorcode). Pattern xử lý chung:

<!-- prettier-ignore -->
| ErrorCode family | Pattern |
| --- | --- |
| `Ok` | Dùng data trong response |
| `*NotFound` (2, 7, 9–19, 22, 24, 29, 30, 31, 39, 42, 44) | Entity không tồn tại — thường hiện message user-friendly, không retry |
| `*Exists` / `*HadBeen*` (4, 23, 25, 36, 49, 50) | Conflict trạng thái — hiện UX "đã tồn tại" / "đã mua", không retry |
| `*Invalid` (5, 6, 34, 35, 47, 48) | Input hoặc external data invalid — user sửa lại rồi thử lại |
| `AccountPasswordWrong` (3), `PlayerBan` (38) | Auth fail nghiệp vụ — show rõ cho user, không retry cùng input |
| `NotEnoughCurrency` (8), `CanNotBuyThisStoreItem` (32) | Điều kiện business không đủ — UX hướng dẫn user nạp/thử item khác |
| `ExternalLinked*` (27, 28) | Identity conflict — UX hướng dẫn unlink/choose account |
| `MatchmakingPlayerJoinedOtherTicket` (43), `MatchmakingTicketAlreadyCompleted` (40) | State transition không hợp lệ — poll state mới rồi retry logic |
| `ExecuteError` (46) | CloudScript throw — đọc payload execute response để debug |

---

## `Return` vs `Error` — quyết định nhanh

<!-- prettier-ignore -->
| Tình huống | Layer | Xử lý |
| --- | --- | --- |
| User offline, request không đến server | — (throw exception / transport exception) | Retry với backoff |
| SSL/cert fail | — (throw exception) | Báo ops; không retry tự động |
| Timeout | `ReturnCode.OperationTimeout` | Retry nếu idempotent |
| Sai secret key | `ReturnCode.SecretInvalid` | Fix config |
| Thiếu permission | `ReturnCode.OperationNotAllow` / `OperationNotAuthorized` | Fix route + secret permission |
| Field invalid | `ReturnCode.InvalidRequestParameters` | Parse `invalidMembers` |
| Username sai | `ErrorCode.AccountNotFound` | UX login fail |
| Password sai | `ErrorCode.AccountPasswordWrong` | UX login fail |
| Thiếu tiền | `ErrorCode.NotEnoughCurrency` | UX nạp tiền |

---

## Task vs Callback

Cả 2 pattern **không throw** trên business/transport error:

```csharp
// Callback
GNNetwork.authenticate.loginByAccount(data, (res) => {
    if (res.returnCode != ReturnCode.Ok) return;
    if (res.errorCode != ErrorCode.Ok) return;
    useResult(res.responseData);
});

// Async
try {
    var res = await GNNetwork.authenticate.loginByAccountAsync(data);
    if (res.returnCode != ReturnCode.Ok) return;
    if (res.errorCode != ErrorCode.Ok) return;
    useResult(res.responseData);
} catch (System.Exception e) {
    // chỉ đến đây khi transport layer throw (network exception, serialization fail)
}
```

Mặc định ưu tiên `*Async`.

---

## Liên kết

- Enum đầy đủ: [ENUMS.md](/docs/reference/ENUMS.md)
- Route / permission: [RULES.md § 3](/docs/RULES.md#3-route--trust-boundary-của-caller)
- Self / other-self: [RULES.md § 4](/docs/RULES.md#4-self-vs-other-self-chỉ-áp-dụng-trên-route-client)
