# Permission Rules Reference

Local offline reference cho permission flags. AI Agent không cần duyệt web để map route, target và flag cơ bản.

## Source Priority

1. [RULES.md § 6](/docs/RULES.md#6-permission-flags) định nghĩa semantics chung: route, target, và flag.
2. `API_<GROUP>.md` liệt kê operation theo từng domain; dùng tên method bỏ hậu tố `Async` làm operation name.
3. GearN Server dashboard là runtime source-of-truth cho secret key nào đang có flag nào.
4. `https://docs.gearn.net/permissionRules` chỉ là external mirror khi cần đối chiếu online.

Nếu docs và dashboard khác nhau, dashboard thắng ở runtime; docs cần được update lại.

## Route To Flag Matrix

<!-- prettier-ignore -->
| Caller | Target | Required flag |
| --- | --- | --- |
| `GNNetwork.<group>.<method>Async(...)` | `self` | `selfEnable` |
| `GNNetwork.<group>.<method>Async(...)` | `other-self` | `otherSelfEnable` |
| `GNNetwork.<group>.server.<method>Async(...)` | any | `serverSelfEnable` |
| `GNNetwork.<group>.admin.<method>Async(...)` | any | `adminSelfEnable` |

`self` / `other-self` chỉ áp dụng cho route `client`. Với route `server` hoặc `admin`, truyền target rõ ràng theo signature của method và kiểm flag tương ứng của route.

## API Group Index

<!-- prettier-ignore -->
| Group | Operation list | Notes |
| --- | --- | --- |
| Authenticate | [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md) | Chỉ có namespace client. Login/register thường là acting-on-unauth-user; xem rule trong dashboard. |
| Dashboard | [API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md) | Chỉ có namespace client wrapper; admin context resolve từ admin auth token. |
| Content | [API_CONTENT.md](/docs/reference/API_CONTENT.md) | Có client/server/admin; ownership không rõ như player entity. |
| Multiplayer | [API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md) | Có client/server/admin; dùng HTTP, không dùng socket cho ticket lifecycle. |
| StoreInventory | [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md) | Có client/server/admin; purchase/receipt flow cần secret đúng trust boundary. |
| Inventory | [API_INVENTORY.md](/docs/reference/API_INVENTORY.md) | Có client/server/admin; owner có thể là master/game/character/group tùy DTO. |
| Group | [API_GROUP.md](/docs/reference/API_GROUP.md) | Có client/server/admin; group lifecycle một số flow nằm ở GamePlayer/CharacterPlayer. |
| MasterPlayer | [API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md) | Có client/server/admin; client có thể bỏ `userId` để target current user. |
| GamePlayer | [API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md) | Có client/server/admin; scoped theo game environment. |
| CharacterPlayer | [API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md) | Có client/server/admin; thường phải truyền `characterId`. |
| CloudScript | [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md) | Có client/server/admin; execute/publish phải theo trust boundary. |

## Operation name convention

Operation name backend = method name SDK **bỏ hậu tố `Async`** (giữ camelCase). Ví dụ:

<!-- prettier-ignore -->
| SDK method | Operation name (dashboard) |
| --- | --- |
| `masterPlayer.getPlayerInformationAsync` | `masterPlayer.getPlayerInformation` |
| `gamePlayer.server.changePlayerCurrencyAsync` | `gamePlayer.changePlayerCurrency` |
| `inventory.admin.setRemoveStatusAsync` | `inventory.setRemoveStatus` |

Route (`client`/`.server`/`.admin`) **không** xuất hiện trong operation name — route quyết định flag (`selfEnable` vs `serverSelfEnable` vs `adminSelfEnable`), không phải operation.

## Diagnose `OperationNotAllow`

1. Xác định namespace đang gọi: client, `.server`, hay `.admin`.
2. Nếu là client route, xác định target là `self` hay `other-self`.
3. Map route + target sang flag theo bảng ở trên.
4. Lấy operation name từ API reference theo convention `Operation name convention` ở trên.
5. Kiểm secret active trong dashboard có flag đó cho operation đó không.

Không retry cùng secret khi gặp `ReturnCode.OperationNotAllow`; đây là lỗi config permission. Các hướng xử lý hợp lệ:

- Dùng secret khác trong `GNServerSettings` rồi restart process.
- Truyền `overrideSecretKey` cho request cụ thể.
- Yêu cầu backend admin bật flag còn thiếu trong GearN Dashboard cho secret hiện tại.

Xem checklist đầy đủ trong [RULES.md § 6.4](/docs/RULES.md#64-checklist-nhanh-khi-gặp-returncodeoperationnotallow) và scenario chẩn đoán trong [COOKBOOK.md](/docs/COOKBOOK.md#scenario-16-diagnose-operationnotallow).
