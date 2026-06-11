# CLOUDSCRIPT INJECTED SYMBOLS

Danh sách đầy đủ symbol được inject sẵn vào script TypeScript chạy trong CloudScript template. KHÔNG cần `import` — gọi trực tiếp.

Khi cần verify một symbol cụ thể, đọc source trong GearN Server repo (không public trong package này):

- `dist/GN-startup/cloudScript/templateCloudScript.ts`
- `dist/GN-startup/cloudScript/CloudScriptDatabase.ts`
- `dist/GN-startup/cloudScript/CloudScriptHttp.ts`
- `dist/GN-startup/cloudScript/CloudScriptSocket.ts`
- `dist/GN-startup/cloudScript/CloudScriptMail.ts`
- `dist/GN-startup/cloudScript/CloudScriptPushNotification.ts`
- `dist/GN-startup/cloudScript/CloudScriptAdmin.ts`

## 1. Runtime helper (singletons)

| Symbol | Kind | Dùng khi nào | Reference |
| --- | --- | --- | --- |
| `gameId` | string | Lấy gameId hiện tại của script | templateCloudScript.ts |
| `handlers` | object | Đăng ký function name → handler (`handlers["X"] = async (...) => {}`) | templateCloudScript.ts |
| `database` | helper | Raw MongoDB collection (custom data: chat, kv, log nghiệp vụ) | CloudScriptDatabase.ts |
| `http` | helper | Gọi REST API / webhook bên ngoài | CloudScriptHttp.ts |
| `socket` | helper | Push realtime event tới user online / room | CloudScriptSocket.ts |
| `mail` | helper | Gửi email | CloudScriptMail.ts |
| `pushNotification` | helper | Gửi push notification | CloudScriptPushNotification.ts |
| `admin` | helper | Gọi API có sẵn của GearN (player, group, inventory, store, …) | CloudScriptAdmin.ts |
| `mongodb` | lib | Native `mongodb` driver (chỉ khi cần type/operator riêng) | — |
| `axios` | lib | Native `axios` (thường dùng qua `http`) | — |

## 2. Data structure

| Symbol | Kind | Dùng khi nào |
| --- | --- | --- |
| `GNHashtable` | class | Map key→value typed của GearN |
| `GNArray` | class | List typed của GearN |
| `GNHashtableBuilder` | builder | Build `GNHashtable` fluent |
| `GNArrayBuilder` | builder | Build `GNArray` fluent |

## 3. Symbol cho `admin` helper

> Các bảng §3.x dưới đây CHỈ cần khi script gọi `admin.*` (gọi API có sẵn của GearN). Khi chỉ dùng `database` / `http` / `socket` / `mail` / `pushNotification` — bỏ qua toàn bộ §3.

### 3.1 Enums / constants

| Symbol | Group |
| --- | --- |
| `ErrorCode` | Lỗi nghiệp vụ (luôn check `=== ErrorCode.Ok`) |
| `ReturnCode` | Tầng transport (`hasReturnCodeError()` thường dùng thay vì so sánh trực tiếp) |
| `ExecuteResponseStatus` | Status của CloudScript execute response (3-tier check tầng 3) |
| `OperationCode` | Mã operation server |
| `ParameterCode` | Mã parameter trong payload |
| `EventCode` | Mã event server push |
| `Commands` | Lệnh nội bộ |
| `OwnerType` | Loại owner của resource |
| `FriendStatus` | Trạng thái friend |
| `GroupStatus` | Trạng thái group |
| `ItemType` | Loại item inventory |
| `StoreItemType` | Loại item trong store |
| `StoreReceiveType` | Cách user nhận item từ store |
| `LogType` | Loại log nghiệp vụ |
| `PostType` | Loại post |
| `PushPlatformType` | Platform push notification |
| `MatchStatus` | Trạng thái match multiplayer |
| `GoogleLoginType` | Loại Google login |
| `InvalidMemberType` | Loại lỗi validate field |
| `RequestType` | `JSON` / `MsgPack` |
| `RequestRole` | `client` / `server` / `admin` |
| `FieldDataType` | Type cho field metadata |

### 3.2 Models namespaces

Mỗi namespace export Request/Response/DTO classes cho domain tương ứng. Pattern: `XxxModels.AdminYyyRequestData`, `XxxModels.YyyResponseData`.

| Symbol | Domain |
| --- | --- |
| `GenericModels` | Generic DTO dùng chung |
| `CharacterPlayerModels` | Character-scoped state |
| `GamePlayerModels` | Per-game gameplay profile |
| `MasterPlayerModels` | Global account identity |
| `ContentModels` | File / content |
| `GroupModels` | Groups & membership |
| `InventoryModels` | Item ownership |
| `StoreInventoryModels` | Store catalog & purchase |
| `MultiplayerModels` | Matchmaking |
| `CloudScriptModels` | CloudScript execute / publish |

### 3.3 Decorators (cho custom DTO class)

| Symbol | Áp lên |
| --- | --- |
| `DataMember` | Field generic |
| `StringDataMember` | Field string |
| `BooleanDataMember` | Field boolean |
| `NumberDataMember` | Field number |
| `GNHashtableDataMember` | Field GNHashtable |
| `GNArrayDataMember` | Field GNArray |

### 3.4 Base classes (khi cần khai báo custom request/response)

| Symbol | Dùng để |
| --- | --- |
| `CustomOperationRequest` | Base custom request typed |
| `CustomOperationRequestAbstract` | Base abstract |
| `CustomOperationResponse` | Base custom response typed |
| `CustomOperationResponseAbstract` | Base abstract |
| `OperationRequest` | Raw operation request |
| `OperationResponse` | Raw operation response |
| `IServerEventHandler` | Interface handle server-side event |

> `OperationEvent` (raw event payload) — dùng khi push event qua `socket`, không thuộc admin. Xem [CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).

## 4. Action types

| Symbol | Arity |
| --- | --- |
| `Action0` | `() => void` |
| `Action1` | `(a) => void` |
| `Action2` | `(a, b) => void` |
| `Action3` | `(a, b, c) => void` |
| `Action4` | `(a, b, c, d) => void` |

## 5. Utility

| Symbol | Dùng khi nào |
| --- | --- |
| `CodeHelper` | Helper đổi code/enum sang tên: `getReturnCodeName`, `getErrorCodeName`, `getRequestTypeName`, `getRequestRoleName`, `getInvalidMemberName` |
| `Constructor` | Type helper (constructor signature) |
| `AbstractConstructor` | Type helper (abstract constructor) |
| `ConverterService` | Convert giữa các kiểu dữ liệu GearN |
| `GNDebug` | Log có level (`info`/`warn`/`error`), nên dùng thay `console.log` |
| `GNSupport` | Utility runtime |
| `GNUtils` | Utility chung |
| `GetAuthInfoResponse` | DTO auth info |
| `PermissionDataItem` | DTO permission |
| `InvalidMember` | DTO validate failure |
| `GNObjectMetadata` | Metadata class GearN |
| `GNObjectFieldMetadata` | Metadata field GearN |
| `GNServerSettings` | Settings runtime |
| `GNServerSettingsOptions` | Options khi build settings |
