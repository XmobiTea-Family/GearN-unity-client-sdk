# API Reference Index

Tổng cộng **945** public async method trên **11 API group**. Mỗi group có 1 file reference riêng (bảng method + request DTO + async form + response class).

> Fast path để tiết kiệm token: chọn domain ở [AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) hoặc guide trong [docs/guides/](/docs/guides/) trước, rồi mới mở row cụ thể ở file `API_<GROUP>.md`.

> File này là **contract index**, không phải nơi canonical cho route/permission/socket/error; các rule đó nằm ở [RULES.md](/docs/RULES.md).

Các khái niệm chung (áp dụng cho mọi group):

- Namespace gốc: `GNNetwork.<group>` (role `Client`); một số group có thêm `.server` (`Server`) và `.admin` (`Admin`).
- Mỗi method có 2 form C#: callback (`method(data, onResponse, ...)`) và `Task` (`methodAsync(data, ...)`). Ưu tiên `*Async()` khi code đang ở async context.
- Param chung của mọi method: `(requestData, onResponse?, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?)` — xem chi tiết trong từng file.
- Response class expose field PUBLIC: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Check 2 tầng (`ReturnCode` → `ErrorCode`); xem [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Request/response wrapper class thường kế thừa `CustomOperationRequestAbstract<TRequestData>` / `CustomOperationResponseAbstract<TResponseData>`; xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) khi cần hiểu `requestData`, `build()`, `setupOperationResponse()`, `responseData`.
- Enum value cụ thể: [ENUMS.md](/docs/reference/ENUMS.md). Config SDK: [CONFIG.md](/docs/reference/CONFIG.md). Permission flags: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md). Realtime event: [EVENTS.md](/docs/reference/EVENTS.md). Custom DTO attribute: [DATAMEMBER.md](/docs/reference/DATAMEMBER.md). Dynamic payload container: [GNDATA.md](/docs/reference/GNDATA.md).

## API groups

<!-- prettier-ignore -->
| Group | Guide | File reference | Namespaces | Public methods | Chịu trách nhiệm |
| --- | --- | --- | --- | --- | --- |
| Authenticate | [AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md) | [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md) | `authenticate` | 18 | Player login (account, social, device id), register, refresh auth token. |
| CharacterPlayer | [CHARACTER_PLAYER.md](/docs/guides/CHARACTER_PLAYER.md) | [API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md) | `characterPlayer`, `.server`, `.admin` | 159 (53/53/53) | Character-level gameplay: profile, inventory relation, friend/group relation, statistics, currency, segment, tag. |
| CloudScript | [CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) | [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md) | `cloudScript`, `.server`, `.admin` | 15 (5/5/5) | CloudScript function add/edit/execute + version/listing. |
| Content | [CONTENT.md](/docs/guides/CONTENT.md) | [API_CONTENT.md](/docs/reference/API_CONTENT.md) | `content`, `.server`, `.admin` | 21 (7/7/7) | Content data key-value, file upload info, download token. |
| Dashboard | [DASHBOARD.md](/docs/guides/DASHBOARD.md) | [API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md) | `dashboard` | 26 | Admin login, game/admin account/secret management, analytics, server log, maintenance tools. Dùng `RequestRole.Client` transport; admin context resolve từ auth token. |
| GamePlayer | [GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md) | [API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md) | `gamePlayer`, `.server`, `.admin` | 156 (52/52/52) | Game-player profile, friend/group relation, currency, statistics, segment, tag, social identity. |
| Group | [GROUP.md](/docs/guides/GROUP.md) | [API_GROUP.md](/docs/reference/API_GROUP.md) | `group`, `.server`, `.admin` | 120 (40/40/40) | Group metadata, member roster, message stream, group-level currency/inventory/statistics. |
| Inventory | [INVENTORY.md](/docs/guides/INVENTORY.md) | [API_INVENTORY.md](/docs/reference/API_INVENTORY.md) | `inventory`, `.server`, `.admin` | 102 (34/34/34) | Inventory item metadata, ownership, amount, statistics, activity log. |
| MasterPlayer | [MASTER_PLAYER.md](/docs/guides/MASTER_PLAYER.md) | [API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md) | `masterPlayer`, `.server`, `.admin` | 256 (86/85/85) | Master-player account: identity linking, profile, contact info, external providers. |
| Multiplayer | [MULTIPLAYER.md](/docs/guides/MULTIPLAYER.md) | [API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md) | `multiplayer`, `.server`, `.admin` | 30 (10/10/10) | Matchmaking ticket lifecycle, queue statistics, match query. |
| StoreInventory | [STORE_INVENTORY.md](/docs/guides/STORE_INVENTORY.md) | [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md) | `storeInventory`, `.server`, `.admin` | 42 (14/14/14) | Store catalog, buy/present, receipt validation, store log. |

Format count: `client/server/admin`. Nếu chỉ có 1 số → chỉ có client variant.

## Cách đọc file reference

Mỗi `API_<GROUP>.md` có:

1. **Namespaces** — danh sách namespace + role transport.
2. **Convention** — template signature chung + param table.
3. **Method tables** — 1 bảng cho client, và (nếu có) 1 bảng cho server + 1 cho admin. Mỗi hàng: `Method | Request DTO | Async form | Response class`.
4. **Ví dụ tối thiểu** — snippet `*Async()` đầu tiên của group với check `returnCode` + `errorCode`.

DTO shape (field-by-field) không inline trong API reference — xem [DTO_INDEX.md](/docs/reference/DTO_INDEX.md) và thư mục [dto/](/docs/reference/dto/).

## Khi nào dùng `server` / `admin` variant?

- `.server` (role `Server`) — trusted backend-to-backend call, ví dụ CloudScript runtime gọi SDK, hoặc backend/service grant item cho player khác.
- `.admin` (role `Admin`) — admin tool / dashboard script mutate state bất kỳ player.
- Không có `.server` / `.admin` namespace nghĩa là group đó chỉ expose cho client (hoặc admin flow đã wrap trong namespace riêng, ví dụ `dashboard`).

Xem [AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md#2-decision-tree-what-i-need-do) để chọn đúng API group + [CONFIG.md](/docs/reference/CONFIG.md) cho secret key config.

## Liên kết nhanh

- Error / return code → [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Enum value cụ thể → [ENUMS.md](/docs/reference/ENUMS.md)
- Permission route/flag → [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)
- Config `GNServerSettings` → [CONFIG.md](/docs/reference/CONFIG.md)
- Realtime event handler → [EVENTS.md](/docs/reference/EVENTS.md)
- Custom DTO / DataMember attribute → [DATAMEMBER.md](/docs/reference/DATAMEMBER.md)
- Dynamic payload `GNArray` / `GNHashtable` → [GNDATA.md](/docs/reference/GNDATA.md)
- Operation request/response base classes → [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md)
- Kịch bản end-to-end → [/docs/COOKBOOK.md](/docs/COOKBOOK.md)
