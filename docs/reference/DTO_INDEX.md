# DTO Index

Tổng cộng **2506** DTO class trên **12** domain.

> **Cách dùng hiệu quả (đặc biệt cho AI consumer):**
> - Khi thấy dạng tài liệu như sau hoặc tương tự `[Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)`, điều đó có nghĩa dùng tool đọc từ dòng 1-10 của `/docs/reference/dto/generic/GENERIC_MODELS.md` là lấy được toàn bộ nội dung cần thiết có trong `Generic.AvatarItem`, trường hợp thấy thông tin bị lệch dòng hoặc không chính xác, fallback về dùng `grep` / ripgrep tìm class name cần: `rg "ClassName" docs/reference/DTO_INDEX.md`.
> - Hoặc mở trực tiếp file domain tương ứng trong `docs/reference/dto/` (xem bảng "Theo domain" dưới).

## Theo domain

<!-- prettier-ignore -->
| Domain | File | Class count |
| --- | --- | --- |
| Authenticate | [dto/AUTHENTICATE.md](/docs/reference/dto/AUTHENTICATE.md) | 59 |
| CharacterPlayer | [dto/CHARACTER_PLAYER.md](/docs/reference/dto/CHARACTER_PLAYER.md) | 390 |
| CloudScript | [dto/CLOUDSCRIPT.md](/docs/reference/dto/CLOUDSCRIPT.md) | 41 |
| Content | [dto/CONTENT.md](/docs/reference/dto/CONTENT.md) | 57 |
| Dashboard | [dto/DASHBOARD.md](/docs/reference/dto/DASHBOARD.md) | 156 |
| GamePlayer | [dto/GAME_PLAYER.md](/docs/reference/dto/GAME_PLAYER.md) | 384 |
| Generic | [dto/GENERIC.md](/docs/reference/dto/GENERIC.md) | 13 |
| Group | [dto/GROUP.md](/docs/reference/dto/GROUP.md) | 300 |
| Inventory | [dto/INVENTORY.md](/docs/reference/dto/INVENTORY.md) | 252 |
| MasterPlayer | [dto/MASTER_PLAYER.md](/docs/reference/dto/MASTER_PLAYER.md) | 641 |
| Multiplayer | [dto/MULTIPLAYER.md](/docs/reference/dto/MULTIPLAYER.md) | 87 |
| StoreInventory | [dto/STORE_INVENTORY.md](/docs/reference/dto/STORE_INVENTORY.md) | 126 |

## Ý nghĩa các cột bảng flat

- **Namespace** — namespace khi import (ví dụ `AuthenticateModels.LoginByAccountRequestData`).
- **Class** — tên class; click để xem field table chi tiết.
- **Fields** — số field public của class (không tính field kế thừa từ parent).
- **Extends** — parent class nếu có (để biết field kế thừa; xem thêm file của parent).

Nếu `Extends` là `CustomOperationRequestAbstract<TRequestData>` hoặc `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md): `TRequestData` là kiểu `requestData` được serialize vào request; `TResponseData` là kiểu `responseData` chỉ đáng tin sau khi `returnCode == ReturnCode.Ok`.
