# RULES — Single Source of Truth

File này là canonical source cho mọi rule cross-cutting: config, route/permission, self/other-self, auth/socket, error handling, override params, anti-patterns. Các file khác (`README.md`, `AGENTS.md`, guides) đều link tới đây thay vì lặp lại.

> Nếu phát hiện mâu thuẫn giữa RULES.md và file khác, RULES.md thắng.

---

## 1. Config / Bootstrap

- Public entrypoint chính là static class `GNNetwork` trong namespace `XmobiTea.GearN`.
- Unity SDK **không** dùng `GNNetwork.init(settings)` kiểu TypeScript. SDK load `GNServerSettings` từ `Resources/GNServerSettings` khi `GNNetwork` được dùng trong Play Mode.
- Cấu hình settings qua Unity Editor menu `XmobiTea GearN/Open Settings`, hoặc qua setter runtime khi thật sự cần.
- Nếu cần chọn game context runtime, gọi `GNNetwork.gnServerSettings.setGameId(gameId)`.
- Config field: xem [reference/CONFIG.md](/docs/reference/CONFIG.md).

---

## 2. Response checking (2-tier)

Typed response expose **PUBLIC FIELDS** — không phải getter:

```csharp
res.returnCode;      // transport/gateway layer
res.errorCode;       // business/domain layer
res.invalidMembers;  // chỉ set khi returnCode == InvalidRequestParameters
res.debugMessage;    // backend debug string
res.responseData;    // typed payload, chỉ đáng tin khi returnCode == Ok
```

Pattern bắt buộc, đúng thứ tự:

```csharp
if (res.returnCode != ReturnCode.Ok) return; // transport/permission fail
if (res.errorCode != ErrorCode.Ok) return;   // business fail
UseResult(res.responseData);                 // happy path
```

Rule cứng:

- `Ok == 1` ở **cả** `ReturnCode` và `ErrorCode`. Không giả định `Ok == 0`.
- Không skip tầng 1 để đọc thẳng `errorCode`; khi `returnCode != Ok`, `errorCode` và `responseData` **không đáng tin**.
- Không hardcode số (`if (res.returnCode == 1)`). So sánh bằng enum symbol.
- `*Async()` trả `Task<TResponse>`; business/transport fail bình thường nằm trong response, không phải exception.
- Low-level raw `OperationResponse` có getter `getReturnCode()` etc. — chỉ dùng khi tự viết custom op.

Full table ReturnCode/ErrorCode + recommended action: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

---

## 3. Route = trust boundary của caller

Route `client / server / admin` mô tả **bên gọi** thực sự ở đâu, không phải target của mình hay của người khác.

<!-- prettier-ignore -->
| Route | Dùng khi code chạy ở |
| --- | --- |
| `client` (`GNNetwork.<group>`) | Unity app của player |
| `server` (`GNNetwork.<group>.server`) | Trusted backend, CloudScript runtime, internal service, worker, cron, webhook |
| `admin` (`GNNetwork.<group>.admin`) | Backoffice, dashboard, GM tool, migration tool, ops |

Rule cứng:

- Không chọn `server`/`admin` chỉ vì target không thuộc user hiện tại.
- Không dùng `.server` / `.admin` từ Unity client chỉ để vượt permission — secret sẽ bị expose.
- Không suy diễn route chỉ từ việc request có hay không có `userId`.
- Route `server`/`admin` yêu cầu `secretKey` có flag `serverSelfEnable` / `adminSelfEnable` tương ứng (hoặc truyền `overrideSecretKey`).

### Ngoại lệ: `DashboardApi`

- Sau `loginByAdminAccountAsync` thành công, backend resolve admin context từ `authToken`.
- Public wrapper `GNNetwork.dashboard.*` vẫn đi `RequestRole.Client`.
- `GNNetwork.dashboard.server` và `GNNetwork.dashboard.admin` hiện rỗng.

---

## 4. `self` vs `other-self` (chỉ áp dụng trên route `client`)

Backend suy ra thêm target context `self / other-self` cho route `client`:

<!-- prettier-ignore -->
| Domain | `self` = |
| --- | --- |
| `MasterPlayerApi`, `GamePlayerApi` | `userId` trong request trùng `userId` đã authenticate, hoặc request không truyền `userId` |
| `CharacterPlayerApi`, `InventoryApi`, `GroupApi` | Entity target thuộc ownership của `GamePlayer` có `userId` trùng user đang authenticate |
| `ContentApi`, `StoreInventoryApi`, `MultiplayerApi`, `CloudScriptApi` | Không có ownership rõ ràng — không ép self/other-self; chọn route theo trust boundary + backend permission |

Rule cứng:

- `self / other-self` **không** phải `server / admin`.
- Không vì muốn thao tác lên data user khác mà tự động chuyển sang `.server` / `.admin`.
- Game server/backend mới được dùng `.server`; GM/backoffice mới được dùng `.admin`.

---

## 5. Phân biệt 3 ReturnCode dễ nhầm

<!-- prettier-ignore -->
| Code | Nghĩa | Fix |
| --- | --- | --- |
| `SecretInvalid` | Secret key sai, thiếu, hoặc không khớp game context | Fix `GNServerSettings.secretKey`. **KHÔNG retry**. |
| `OperationInvalid` | Operation code không tồn tại, hoặc không hợp lệ với `RequestType` + `RequestRole` hiện tại | Check namespace đang gọi + đúng method trong `API_<GROUP>.md`. |
| `OperationNotAllow` | Secret hợp lệ và operation tồn tại, NHƯNG permission rule của secret không cho phép trong target context | Check route + flag `selfEnable`/`otherSelfEnable`/`serverSelfEnable`/`adminSelfEnable`. **KHÔNG retry**. |

---

## 6. Permission flags

GearN Server map quyền theo từng domain + operation. Mỗi secret key có 4 flag chính:

<!-- prettier-ignore -->
| Flag | Nghĩa |
| --- | --- |
| `selfEnable` | Cho phép thao tác trên tài nguyên thuộc user đã authenticate |
| `otherSelfEnable` | Cho phép thao tác trên tài nguyên không thuộc user đã authenticate |
| `serverSelfEnable` | Cho phép thực thi qua route `server` |
| `adminSelfEnable` | Cho phép thực thi qua route `admin` |

Danh sách operation/flag offline: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md) + `docs/reference/API_<GROUP>.md`. Backend GearN Server / dashboard vẫn là runtime source-of-truth.

### 6.1 Mapping (route, target) → required flag

<!-- prettier-ignore -->
| Caller gọi | Target | Flag cần trên secret key |
| --- | --- | --- |
| `GNNetwork.<group>.<method>()` — bỏ userId hoặc userId trùng auth | Self | `selfEnable` của operation |
| `GNNetwork.<group>.<method>(otherUserId)` | Other-self | `otherSelfEnable` của operation |
| `GNNetwork.<group>.server.<method>(...)` | Bất kỳ | `serverSelfEnable` của operation |
| `GNNetwork.<group>.admin.<method>(...)` | Bất kỳ | `adminSelfEnable` của operation |

Ngoại lệ: domain không có ownership (`ContentApi`, `StoreInventoryApi`, `MultiplayerApi`, `CloudScriptApi`) — backend áp rule theo contract operation.

### 6.2 Ai config flag, client có đổi được không?

- Permission rule được backend admin config trên GearN Dashboard theo từng `secretKey × operation × flag`.
- Unity client không tự đổi được flag. Chỉ có 3 option khi thiếu quyền:
  1. Dùng `secretKey` khác trong `GNServerSettings`.
  2. Truyền `overrideSecretKey` per-request.
  3. Yêu cầu backend admin bật flag cho secret hiện tại.

### 6.3 Checklist nhanh khi gặp `ReturnCode.OperationNotAllow`

1. Xác định route đang gọi (`client` / `.server` / `.admin`).
2. Xác định target là `self` hay `other-self`.
3. Tra bảng § 6.1 → ra flag cần.
4. Check secret key active có flag đó cho operation đang gọi không.
5. Nếu không → 3 option ở § 6.2.

**Không retry** — đây là config fix, không phải transient error.

---

## 7. Auth & Socket flow

Flow chuẩn:

```text
1. Login HTTP (`GNNetwork.authenticate.loginByAccountAsync`, `loginByCustomIdAsync`, ...) → SDK cache authToken + userId vào StorageService
2. Nếu app cần realtime: subscribe handler trước
3. GNNetwork.connectSocket()
4. Khi socket connect, SDK tự gửi authToken hiện tại cho backend
5. (Chỉ khi cần) GNNetwork.sendRequestAuthSocket() — re-auth thủ công, không reconnect
```

Rule cứng:

- Không gộp auth socket với auth HTTP. Socket auth là bước riêng sau HTTP.
- Không bắt buộc gọi `sendRequestAuthSocket()` sau mỗi `connectSocket()`. SDK auto-auth nếu token đã có.
- Gọi `sendRequestAuthSocket()` chỉ khi socket connect trước khi có `authToken`, hoặc token vừa đổi và muốn re-auth ngay.
- Không giả định realtime event tự chạy chỉ vì đã gọi method HTTP friend/group. Phải subscribe handler trong [reference/EVENTS.md](/docs/reference/EVENTS.md).
- Subscribe event handler **trước** `connectSocket()` để không miss event ngay sau handshake.

Helper state:

- `GNNetwork.isSocketConnected()` — check socket session id hiện tại.
- `GNNetwork.getPing()` — ping trung bình từ active transport.
- `GNNetwork.getServerTimestamp()` — đọc local estimate (ms since epoch) của server clock; không gọi network.
- `GNNetwork.syncTs()` / `syncTsAsync()` — hit endpoint timestamp để refresh local estimate; dùng khi cần time-sensitive call (ví dụ trước khi validate receipt).
- `GNNetwork.getAuthenticateStatus().getAuthToken()` / `.getUserId()` — đọc auth cache.

---

## 8. Method signature & override params

Đa số method có 2 form:

```csharp
// Callback
GNNetwork.authenticate.loginByAccount(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async (preferred)
var res = await GNNetwork.authenticate.loginByAccountAsync(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

### 8.1 Build request DTO trong code copy-paste

- Code tích hợp cuối cùng nên tạo instance DTO public: `var request = new <Group>Models.<Method>RequestData();`.
- Set field trên instance đó rồi truyền vào `*Async(request)`.
- Không dùng anonymous object hoặc `Dictionary` thay DTO khi API đã có request class public.

<!-- prettier-ignore -->
| Param | Khi nào cần |
| --- | --- |
| `overrideAuthToken: string` | Impersonate / multi-session / admin thao tác trên user khác mà không dùng auth cache hiện tại |
| `overrideSecretKey: string` | Override secret cho 1 request, ví dụ migration tool gọi `.admin` từ script ngoài |
| `customTags: GNHashtable` | Tag trace id, build version, A/B bucket — backend có thể log/route |
| `timeout: int` | Override `defaultTimeoutInSeconds` per-request |

Ví dụ `customTags`:

```csharp
var tags = XmobiTea.GearN.Common.GNHashtable.builder().add("traceId", "trace-001").add("build", "qa").build();
```

---

## 9. Platform & transport

- Unity `2020.3` trở lên.
- Detect platform runtime: `GNNetwork.getPlatform()`.
- `MessageType.MsgPack` dùng binary payload khi server/transport hỗ trợ; `MessageType.Json` dùng JSON.
- Socket transport phụ thuộc compile define / package được cài trong project:
  - `UNITY_USING_BEST_HTTP`
  - `UNITY_USING_SOCKET_IO_UNITY`

---

## 10. Anti-patterns & pitfalls

<!-- prettier-ignore -->
| # | Anti-pattern | Triệu chứng | Fix |
| --- | --- | --- | --- |
| 1 | Giả định success là `0` | So sánh `== 0` luôn false, code tưởng fail | `Ok == 1` cả `ReturnCode` và `ErrorCode`. |
| 2 | Skip tầng 1, đọc thẳng `errorCode` | Business code branching nhầm vì `errorCode` chưa valid | Check `returnCode != Ok` trước. |
| 3 | Dùng getter `res.getReturnCode()` trên typed response | Compile/runtime fail | Typed response dùng public field. Getter chỉ trên raw `OperationResponse`. |
| 4 | Gọi API khi chưa có `Resources/GNServerSettings` | Null settings / lỗi init | Tạo settings asset qua Unity menu. |
| 5 | Tưởng `GNNetwork.init(settings)` tồn tại | Code TS copy sang C# không compile | Unity SDK tự load `GNServerSettings`; dùng setter/asset. |
| 6 | Dùng `.server` / `.admin` từ Unity client để vượt permission | Secret expose | Route là trust boundary của caller. |
| 7 | Tự gọi `sendRequestAuthSocket()` sau mọi `connectSocket()` | Redundant call | SDK auto-auth nếu token có. |
| 8 | Subscribe event sau `connectSocket()` | Miss event ngay sau handshake | Subscribe trước, rồi connect. |
| 9 | `editFunctionAsync` để sửa CloudScript source code | Source không đổi, chỉ flag thay | Đổi source = `addFunctionAsync` tạo version mới. |
| 10 | `MultiplayerApi` gửi qua socket | Không reach backend | Multiplayer dùng HTTP. |
| 11 | `infoRequestParam = null` trong login | Backend không hydrate gì cả | Truyền instance và bật field cần lấy. |
| 12 | Bulk-set mọi field của `infoRequestParam` | Payload lớn, chậm | Chỉ bật field thật sự render. |
| 13 | `OperationNotAllow` = thiếu secret | Fix sai hướng | Secret hợp lệ nhưng permission rule cấm. |
| 14 | Bịa method / field không có trong public C# type | Compile fail | Tra `API_<GROUP>.md` / `dto/<DOMAIN>.md` / `Runtime/**/*.cs`. |
| 15 | Giả định realtime tự chạy sau HTTP call | Không nhận event | Subscribe handler trong [EVENTS.md](/docs/reference/EVENTS.md). |

---

## 11. Canonical sources (thứ tự ưu tiên)

Khi có conflict:

- Rule cross-cutting (route, permission, socket, error): **RULES.md thắng**.
- Method signature, DTO, enum: **API reference / DTO reference / ENUMS.md thắng**, fallback cuối là public C# type trong `Runtime/**/*.cs`.
- Bundle generated như `llms-full.txt` không bao giờ thắng source docs.

Khi sinh code:

1. **API reference theo domain** (`docs/reference/API_<GROUP>.md`).
2. **Guide theo domain** (`docs/guides/<GROUP>.md`).
3. **RULES.md** + [ai-manifest.json](/docs/ai-manifest.json).
4. **DTO field table** (`docs/reference/dto/<DOMAIN>.md` hoặc grep `DTO_INDEX.md`).
5. **ENUMS.md**.
6. **`Runtime/**/*.cs`** — fallback nếu docs chưa cover.

Chỉ đọc implementation chi tiết khi sửa SDK, debug nội bộ, hoặc verify public contract mà docs chưa đủ.

---

## Liên kết

- [AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) — one-page reference
- [COOKBOOK.md](/docs/COOKBOOK.md) — scenario end-to-end
- [reference/API_INDEX.md](/docs/reference/API_INDEX.md) — bảng method mọi group
- [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md) — full return/error code table
- [reference/EVENTS.md](/docs/reference/EVENTS.md) — realtime event handler
- [reference/CONFIG.md](/docs/reference/CONFIG.md) — `GNServerSettings` schema
- [reference/ENUMS.md](/docs/reference/ENUMS.md) — enum numeric value
- [ai-manifest.json](/docs/ai-manifest.json) — machine-readable manifest
