# API ErrorCode Migration Guide

> Internal maintenance doc. Không dùng file này làm public contract cho package consumer.

Mục tiêu: chuyển danh sách `ErrorCode` theo từng method từ guide domain sang API reference, để API reference trở thành nơi tra contract đầy đủ gồm DTO, permission và business error. Guide domain sau migration chỉ giữ vai trò hướng dẫn chọn flow/method, không còn là nguồn liệt kê `ErrorCode` theo method.

Áp dụng trước mắt cho:

- Source: `/docs/guides/CHARACTER_PLAYER.md`
- Target: `/docs/reference/API_CHARACTER_PLAYER.md`

## Nguyên tắc

- `docs/reference/API_<GROUP>.md` là nơi đặt bảng contract theo method.
- `docs/guides/<GROUP>.md` là nơi giải thích khi nào dùng method, flow, best practice, ví dụ code.
- Không giữ cùng một danh sách `ErrorCode` ở cả guide và API reference, vì dễ lệch khi backend contract thay đổi.
- Khi chuyển, không tự bịa thêm `ErrorCode`. Chỉ lấy từ cột `ErrorCode` hiện có trong guide hoặc nguồn canonical khác nếu có chỉ định rõ.
- Giữ nguyên spelling enum như trong code/docs: `Ok`, `CharacterPlayerNotFound`, `KeyNotFound`, `PlayerBan`, ...

## Cấu trúc bảng API mới

Với `## Client methods`, đổi bảng sang cấu trúc ưu tiên cho AI agent đọc đúng contract:

```markdown
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules Error Code có thể gặp | Permission Rules khi truyền `characterId` mà `gamePlayer` đang authenticated không phải là owner của `characterPlayer` này |
| --- | --- | --- | --- | --- | --- |
```

Ví dụ:

```markdown
| `addPlayerFriend` | [CharacterPlayerModels.AddPlayerFriendRequestData:86-96](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addplayerfriendrequestdata) | `characterPlayer.addPlayerFriend.selfEnable` | `characterPlayer.addPlayerFriend.otherSelfEnable` | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `PlayerBan` | [CharacterPlayerModels.EmptyResponseData:2244-2248](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#emptyresponsedata) |
```

Với `## Server methods`, dùng cấu trúc tương tự nhưng không có cột other-self, vì route server dùng `serverSelfEnable`:

```markdown
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
```

Ví dụ:

```markdown
| `addPlayerFriend` | [CharacterPlayerModels.ServerAddPlayerFriendRequestData:86-108](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serveraddplayerfriendrequestdata) | [CharacterPlayerModels.EmptyResponseData:2244-2248](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#emptyresponsedata) | `characterPlayer.addPlayerFriend.serverSelfEnable` | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `PlayerBan` |
```

Với `## Admin methods`, cũng không có cột other-self, vì route admin dùng `adminSelfEnable`:

```markdown
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
```

Ví dụ:

```markdown
| `addPlayerFriend` | [CharacterPlayerModels.AdminAddPlayerFriendRequestData:86-121](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#adminaddplayerfriendrequestdata) | [CharacterPlayerModels.EmptyResponseData:2244-2248](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#emptyresponsedata) | `characterPlayer.addPlayerFriend.adminSelfEnable` | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `PlayerBan` |
```

## Mapping method name

Guide dùng tên async như `addPlayerFriendAsync`; API reference dùng tên base method như `addPlayerFriend`.

Khi migrate:

- Bỏ suffix `Async` trong guide để match API row.
- Ví dụ `getAvatarAsync` trong guide map vào row `getAvatar` trong API.
- Nếu một method có trong API nhưng không có trong guide, để `ErrorCode` trống hoặc ghi rõ `TBD` chỉ khi team đã dùng convention đó. Ưu tiên kiểm tra lại source canonical trước khi thêm.
- Nếu guide có method không có trong API, không thêm API row mới nếu chưa verify public method tồn tại.

## Mapping DTO link

Không dùng text DTO trần nếu đã có DTO split file và line range.

Request data:

- Link tới `docs/reference/dto/<domain>/<GROUP>_MODELS.md`.
- Label có dạng `[CharacterPlayerModels.<RequestData>:startLine-endLine](...)`.
- Dòng range phải là range đủ để đọc section payload cần thiết.

Response data:

- Không link tới operation response wrapper nếu mục tiêu là biết `responseData` có gì.
- Đọc `docs/reference/dto/<domain>/<GROUP>_RESPONSE_MODELS.md` để biết operation response extends `CustomOperationResponseAbstract<TResponseData>`.
- Link cột `Response Data DTO Link` tới chính `TResponseData` trong `<GROUP>_MODELS.md`.
- Ví dụ `AddPlayerFriendOperationResponse` extends `CustomOperationResponseAbstract<CharacterPlayerModels.EmptyResponseData>` thì response data link là `CharacterPlayerModels.EmptyResponseData`, không phải `AddPlayerFriendOperationResponse`.

## Quy trình chuyển đổi

1. Đọc các bảng method trong `docs/guides/<GROUP>.md` và trích map:
   - key: method base name, bỏ hậu tố `Async`
   - value: danh sách `ErrorCode`
2. Đọc `docs/reference/API_<GROUP>.md` và cập nhật cả 3 bảng `## Client methods`, `## Server methods`, `## Admin methods`.
3. Với mỗi row API:
   - đổi `Request DTO` thành `Request Data DTO Link`
   - bỏ `Async form`
   - đổi `Response class` thành `Response Data DTO Link`
   - giữ cột permission phù hợp với route hiện tại
   - thêm cột `Error Code có thể gặp`
4. Với mỗi method, điền `ErrorCode` từ map đã trích ở bước 1.
   - Client, server và admin của cùng một operation dùng cùng danh sách business `ErrorCode` nếu guide chỉ khai báo theo method.
   - Permission failure nằm ở `returnCode` như `OperationNotAllow`, không đưa vào cột `ErrorCode`.
5. Sau khi bảng API đã đủ, quay lại guide và xóa cột `ErrorCode` khỏi các bảng method.
6. Không xóa phần hướng dẫn check `response.errorCode` trong guide, vì đó là response handling pattern, không phải danh sách contract theo method.
7. Tính lại line range trong các link DTO nếu file DTO bị thay đổi. Nếu chỉ sửa API/guide thì DTO line range không đổi.

## Phạm vi xóa trong guide

Chỉ xóa cột `ErrorCode` trong các bảng chọn method, ví dụ:

```markdown
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
```

đổi thành:

```markdown
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú |
```

Và từng row bỏ cell cuối cùng chứa danh sách `ErrorCode`.

Không xóa:

- `response.errorCode` trong phần Response Rules.
- Code sample đang check `if (response.errorCode != ErrorCode.Ok)`.
- Link tới `ERROR_HANDLING.md`.
- Nội dung giải thích 2-tier response checking.

## Kiểm tra sau khi migrate

- `API_<GROUP>.md` có cột `ErrorCode` trong `## Client methods`.
- `API_<GROUP>.md` có cột `ErrorCode` trong `## Server methods` và `## Admin methods`.
- Mỗi method client có ErrorCode đúng với guide trước khi xóa.
- Server/admin method cùng operation dùng cùng danh sách business `ErrorCode` với client, trừ khi có nguồn canonical riêng chỉ ra khác biệt.
- `guides/<GROUP>.md` không còn cột `ErrorCode` trong bảng method.
- `guides/<GROUP>.md` vẫn còn hướng dẫn check `returnCode` trước `errorCode`.
- Markdown table vẫn đủ số cột ở header, separator và mọi row.
- Không thay đổi route/permission rule khi chỉ migrate ErrorCode.

## Ghi chú cho CharacterPlayer

Trong `CHARACTER_PLAYER`, nhiều method đọc metadata có cùng lỗi:

```text
Ok, CharacterPlayerNotFound
```

Các method search/leaderboard/log thường có `Ok` và có thể thêm `KeyNotFound` hoặc `VersionInvalid`. Các method mutation thường có `CharacterPlayerNotFound`, `PlayerBan`, và lỗi domain phụ như `CatalogIdNotFound`, `GroupNotFound`, `ItemNotFound`, `NotEnoughCurrency`, `DisplayNameUsed`, `OwnerNotFound`, `GamePlayerNotFound`.

Đây chỉ là pattern hỗ trợ review. Khi điền bảng, vẫn phải lấy danh sách cụ thể từ guide hiện tại hoặc nguồn canonical được chỉ định.
> Internal maintenance doc. Không dùng file này làm public contract cho package consumer.
