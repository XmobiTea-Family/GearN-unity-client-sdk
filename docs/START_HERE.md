# Start Here

Minimal router cho con người và AI khi làm việc với package `com.xmobitea.changx.gearn-unity-client-sdk`.

Repo này là **Unity client package để import vào game**. Nếu mục tiêu của bạn là tích hợp SDK vào project Unity khác, ưu tiên `docs/` và **không** bắt đầu từ `Runtime/`.

## Đọc Theo Mục Tiêu

<!-- prettier-ignore -->
| Tôi cần... | Mở file này trước | Sau đó |
| --- | --- | --- |
| Login / refresh token / socket | [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) | [docs/guides/AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md) |
| Chọn đúng API group / method | [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) | [docs/reference/API_INDEX.md](/docs/reference/API_INDEX.md) rồi mở guide domain tương ứng |
| Hiểu rule route, permission, self/other-self, error | [docs/RULES.md](/docs/RULES.md) | [docs/reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md) / [docs/reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md) |
| Xem scenario end-to-end | [docs/COOKBOOK.md](/docs/COOKBOOK.md) | hoặc `docs/examples/*.md` nếu đúng scenario |
| Tra DTO field cụ thể | [docs/reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md) | rồi mở split file DTO đúng class/range |
| Viết hoặc publish CloudScript | [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) | [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) |
| Sửa chính SDK / debug nội bộ | [ARCHITECTURE.md](/ARCHITECTURE.md) | [REQUEST_FLOW.md](/REQUEST_FLOW.md), `Runtime/**/*.cs` |

## Reading Order Đề Nghị Cho Package Consumer

1. [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md)
2. [docs/RULES.md](/docs/RULES.md)
3. Guide domain trong [docs/guides/](/docs/guides/)
4. [docs/reference/API_INDEX.md](/docs/reference/API_INDEX.md) và [docs/reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md) khi cần contract/field cụ thể

## Đừng Mở Trước Nếu Chỉ Đang Tích Hợp Package

- `Runtime/`
- [ARCHITECTURE.md](/ARCHITECTURE.md)
- [REQUEST_FLOW.md](/REQUEST_FLOW.md)
- [DEVELOPMENT.md](/DEVELOPMENT.md)
- [DOMAIN_RELATIONSHIP.md](/DOMAIN_RELATIONSHIP.md)
- `internal-docs/*`

Những file trên dành cho maintainer hoặc cho task sửa chính SDK; chúng không phải public contract đầu tiên để sinh code tích hợp.

## Quy Tắc Sống Còn

1. `GNNetwork` là entrypoint public chính.
2. Unity client mặc định gọi `GNNetwork.<group>.*Async(...)`.
3. Check `returnCode` trước, rồi `errorCode`.
4. `ReturnCode.Ok == 1` và `ErrorCode.Ok == 1`.
5. Socket flow chuẩn: login HTTP -> subscribe handler -> `GNNetwork.connectSocket()`; chỉ `GNNetwork.sendRequestAuthSocket()` khi cần re-auth thủ công.
