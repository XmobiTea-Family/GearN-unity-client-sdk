# DTO Split Plan

> Internal maintenance doc. Không dùng file này làm nguồn canonical khi sinh code sử dụng SDK.

Mục tiêu: chia các file lớn ra thành các file nhỏ, file lớn lúc này giữ index đến các file nhỏ để AI Agent đọc nội dung chính xác hơn, bổ sung cả start line và end line bằng định dạng kiểu [InfoRequestParam:1-35](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam) (nghĩa là đọc /docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam từ dòng 1-35), mục tiêu để AI AGENT không phải mở full các file mà chỉ cần Get-Content từ dòng 1-35 là đủ nội dung cần rồi

Thực hiện như sau:

Chia dto
tại các .md nằm tại root /docs/reference/dto/
nếu gặp 1 đối tượng mà chưa thấy reference, hãy bổ sung reference link dạng `[abc.md:startLine-endLine]()`

## Rule bắt buộc

- Không được dừng ở việc chỉ tách file namespace lớn thành file nhỏ.
- Bắt buộc phải bổ sung `Reference links:` cho từng section DTO nếu section đó nhắc tới object khác trong field type, generic type, response type, request type, hoặc note mô tả.
- Rule này áp dụng cho cả request DTO, response DTO, param/helper DTO, operation request, operation response.
- Nếu một field dùng object như `InfoRequestParam`, `PlayerDataParam`, `GroupMemberParam`, `CharacterPlayerResponseData`, `EmptyResponseData`... thì section hiện tại phải có link trỏ tới đúng section được nhắc đến.
- Không cần tạo `Reference links:` cho chính base wrapper `CustomOperationRequestAbstract` hoặc `CustomOperationResponseAbstract`.
- Nếu section extends `CustomOperationRequestAbstract<TRequestData>` hoặc `CustomOperationResponseAbstract<TResponseData>`, bắt buộc link tới DTO generic bên trong `T...`, không link tới base wrapper. Ví dụ `CustomOperationResponseAbstract<AuthenticateModels.RefreshAuthTokenResponseData>` phải có `Reference links:` dạng `[AuthenticateModels.RefreshAuthTokenResponseData:314-326](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#refreshauthtokenresponsedata)`. Rule này áp dụng tương tự cho mọi generic DTO khác như `CharacterPlayerModels.EmptyResponseData`, `AuthenticateModels.AuthenticateResponseData`, `GamePlayerModels.GetPlayerInformationRequestData`...
- Link phải dùng line range chính xác theo format `[Name:startLine-endLine](/path/file.md#anchor)`.
- Label của `Reference links:` phải giữ đúng cách type được nhắc trong section hiện tại.
  - Nếu field/extends/note ghi bare type cùng namespace như `InfoRequestParam`, `AddPlayerFriendRequestData`, `ServerAddPlayerFriendRequestData` thì link label cũng bare: `[InfoRequestParam:1-29](...)`, không tự thêm `[AuthenticateModels.InfoRequestParam:...]`.
  - Nếu generic type ghi đầy đủ namespace/container như `CustomOperationResponseAbstract<AuthenticateModels.RefreshAuthTokenResponseData>` thì link label phải giữ đầy đủ `AuthenticateModels.RefreshAuthTokenResponseData`.
  - Nếu dependency nằm ngoài entity/namespace hiện tại như `GenericModels.DataItem` thì dùng prefix chuẩn của dependency theo rule bên dưới.
- Nếu dependency nằm ở entity/namespace khác thì vẫn bắt buộc phải thêm `Reference links:`. Ví dụ trong GamePlayer, field type `GenericModels.DataItem`, `GenericModels.AvatarItem`, `GenericModels.CurrencyItem`... phải link sang `/docs/reference/dto/generic/GENERIC_MODELS.md`.
- Với dependency ngoài entity hiện tại, label link phải có prefix namespace/entity để tránh nhầm với DTO cùng tên ở file khác. Ví dụ link Generic phải viết dạng `[Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)`, không viết `[DataItem:31-40](...)`.
- Không được bỏ qua chỉ vì object đã xuất hiện ở file index lớn hoặc vì tên object đã đủ rõ.
- Mục tiêu là AI Agent có thể đứng ngay tại section hiện tại, thấy object phụ thuộc, và nhảy thẳng tới đúng đoạn cần đọc mà không phải mở cả file hoặc tự grep thêm.

## Quy trình chuẩn cho mọi entity

Áp dụng giống nhau cho mọi file DTO gốc như:

- `/docs/reference/dto/CHARACTER_PLAYER.md`
- `/docs/reference/dto/GAME_PLAYER.md`
- `/docs/reference/dto/MASTER_PLAYER.md`
- và mọi entity tương tự khác

Khi làm bất kỳ entity nào, bắt buộc làm đủ toàn bộ các bước sau:

1. Tách file gốc thành các file nhỏ theo namespace.
   Ví dụ: `*_MODELS.md`, `*_REQUEST_MODELS.md`, `*_RESPONSE_MODELS.md`.
2. Bổ sung `Reference links:` cho mọi section có nhắc tới object khác.
   - Phải scan cả dependency cùng entity lẫn dependency ngoài entity như `GenericModels.*`; GamePlayer từng bị thiếu các link Generic trong `InfoResponseParameters`, nên đây là bước bắt buộc.
   - Nếu link tới Generic, dùng label dạng `Generic.<ClassName>:start-end`.
   - Nếu field type trong cùng namespace được viết bare, label link cũng phải bare; không tự thêm prefix container.
   - Nếu section là operation wrapper extends `CustomOperationRequestAbstract<T>` / `CustomOperationResponseAbstract<T>`, chỉ link tới DTO `T`, không link tới `CustomOperationRequestAbstract` / `CustomOperationResponseAbstract`.
3. Tính lại line range chính xác sau khi đã chèn xong toàn bộ `Reference links:`.
4. Cập nhật lại file DTO gốc để phần `## Danh sách` link sang các file nhỏ mới bằng format `[Name:start-end](/path/file.md#anchor)`.
5. Loại bỏ toàn bộ nội dung chi tiết `## Namespace ...` khỏi file DTO gốc.
   File DTO gốc sau khi hoàn thành chỉ giữ vai trò index / landing page, không giữ lại phần body chi tiết của các namespace đã được tách ra.
6. Cập nhật lại mọi tài liệu khác đang reference vào DTO cũ của entity đó.
   Ví dụ: cloud script docs, guide docs, api docs, hoặc bất kỳ file nào đang link sang `docs/reference/dto/<ENTITY>.md#...`.
7. Sau khi update reference ở các file liên quan, phải tính lại line range một lần nữa để bảo đảm không bị lệch dòng do việc chèn thêm `Reference links:` hoặc chỉnh sửa nội dung.

## Yêu cầu đầu ra

Sau khi hoàn thành cho một entity, kết quả đúng phải có đủ:

- File DTO gốc chỉ còn phần mô tả chung + `## Danh sách`.
- `## Danh sách` không còn link nội bộ kiểu `(#heading)` tới section chi tiết trong chính file gốc.
- `## Danh sách` phải link sang các file split tương ứng với line range chính xác.
- Các file split phải chứa đầy đủ section chi tiết.
- Các file split phải có `Reference links:` nếu section có phụ thuộc tới object khác.
- Các tài liệu liên quan bên ngoài DTO gốc phải được đổi sang link mới nếu trước đó đang trỏ vào file DTO gốc cũ.
- Nếu số dòng thay đổi, toàn bộ line range đã public ra ngoài phải được cập nhật lại đồng bộ.

dưới đây chỉ là ví dụ cho dễ hiểu, bạn hãy làm chi tiết tất cả, thứ tự sắp xếp cần giống với file gốc như `/docs/reference/dto/CHARACTER_PLAYER.md`
- vd
```markdown
### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional character fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

Refernce Link:

- [InfoRequestParam:1-35](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)

```

Ví dụ trên không phải case đặc biệt, mà là pattern bắt buộc cho mọi section tương tự. Ví dụ:

- Nếu `### GetPlayerInformationRequestData` có field `infoRequestParam: InfoRequestParam` thì section đó bắt buộc phải có `Reference links:` tới `InfoRequestParam`.
- Nếu `### AddPlayerFriendOperationResponse` extends `CustomOperationResponseAbstract<CharacterPlayerModels.EmptyResponseData>` thì section đó cũng phải có `Reference links:` tới `CharacterPlayerModels.EmptyResponseData`, không cần link tới `CustomOperationResponseAbstract`.
- Nếu `### AddPlayerFriendOperationRequest` extends `CustomOperationRequestAbstract<CharacterPlayerModels.AddPlayerFriendRequestData>` thì section đó cũng phải có `Reference links:` tới `CharacterPlayerModels.AddPlayerFriendRequestData`, không cần link tới `CustomOperationRequestAbstract`.
- Nếu `### RefreshAuthTokenOperationResponse` extends `CustomOperationResponseAbstract<AuthenticateModels.RefreshAuthTokenResponseData>` thì section đó phải có `Reference links:` tới `[AuthenticateModels.RefreshAuthTokenResponseData:314-326](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#refreshauthtokenresponsedata)`.
file gốc chứa các phần và nội dung các phần như sau, tôi cho ví dụ về file /docs/reference/dto/CHARACTER_PLAYER.md:

```markdown
# DTO Reference: CharacterPlayer

Character-level gameplay: profile, inventory relation, friend/group relation, statistics, currency, segments, tags.

Related API reference: [API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new CharacterPlayerModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `characterId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

> **Operation base**: Nếu class `*OperationRequest` extends `CustomOperationRequestAbstract<TRequestData>` hoặc class `*OperationResponse` extends `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) để hiểu `requestData`, `build()`, `setupOperationResponse()`, và `responseData`.

## Danh sách

- **CharacterPlayerModels** (from `Runtime/Entity/Models/CharacterPlayerModels.cs`)
    - [InfoRequestParam:1-35](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#inforequestparam)
    - [AddPlayerFriendRequestData:37-46](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addplayerfriendrequestdata)
    - [ServerAddPlayerFriendRequestData:37-54](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serveraddplayerfriendrequestdata)
    - [AdminAddPlayerFriendRequestData:37-62](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#adminaddplayerfriendrequestdata)
    - ... toàn bộ CharacterPlayerModels
- **CharacterPlayerRequestModels** (from `Runtime/Entity/Models/CharacterPlayerRequestModels.cs`)
    - [AddPlayerFriendOperationRequest:1-7](/docs/reference/dto/character-player/CHARACTER_PLAYER_REQUEST_MODELS.md#addplayerfriendoperationrequest)
    - [ServerAddPlayerFriendOperationRequest:1-15](/docs/reference/dto/character-player/CHARACTER_PLAYER_REQUEST_MODELS.md#serveraddplayerfriendoperationrequest)
    - [AdminAddPlayerFriendOperationRequest:1-23](/docs/reference/dto/character-player/CHARACTER_PLAYER_REQUEST_MODELS.md#adminaddplayerfriendoperationrequest)
    - ... toàn bộ CharacterPlayerRequestModels
- **CharacterPlayerResponseModels** (from `Runtime/Entity/Models/CharacterPlayerResponseModels.cs`)
    - [AddPlayerFriendOperationResponse:1-7](/docs/reference/dto/character-player/CHARACTER_PLAYER_RESPONSE_MODELS.md#addplayerfriendoperationresponse)
    - ... toàn bộ CharacterPlayerResponseModels

---
```

*** Chú ý ***
    - [AddPlayerFriendRequestData:37-46](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#addplayerfriendrequestdata) bởi vì AddPlayerFriendRequestData chỉ có nội dung từ dòng 37-46
    - [ServerAddPlayerFriendRequestData:37-54](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#serveraddplayerfriendrequestdata) bởi vì ServerAddPlayerFriendRequestData có Extends từ AddPlayerFriendRequestData nên cần nội dung từ dòng 37-54 để có cả nội dung của ServerAddPlayerFriendRequestData lẫn Extends là AddPlayerFriendRequestData 
    - [AdminAddPlayerFriendRequestData:37-62](/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md#adminaddplayerfriendrequestdata) bởi vì AdminAddPlayerFriendRequestData có Extends từ ServerAddPlayerFriendRequestData và ServerAddPlayerFriendRequestData lại có nội dung Extends từ AddPlayerFriendRequestData nên cần nội dung từ dòng 37-62 để có cả nội dung của AdminAddPlayerFriendRequestData lẫn Extends là ServerAddPlayerFriendRequestData và AddPlayerFriendRequestData

nội dung ## Namespace `CharacterPlayerModels` được tách ra thành file như sau:
/docs/reference/dto/character-player/CHARACTER_PLAYER_MODELS.md
```markdown
### InfoRequestParam

Selects which optional character-player fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `bool?` | no | Includes the character catalog ID. — _default=false_ |
| `owner` | `bool?` | no | Includes the current owner descriptor. — _default=false_ |
| `removeStatus` | `bool?` | no | Includes the remove-state descriptor. — _default=false_ |
| `segments` | `bool?` | no | _default=false_ |
| `customDatas` | `bool?` | no | _default=false_ |
| `displayName` | `bool?` | no | _default=false_ |
| `avatar` | `bool?` | no | _default=false_ |
| `tsCreate` | `bool?` | no | _default=false_ |
| `tags` | `bool?` | no | _default=false_ |
| `playerBan` | `bool?` | no | _default=false_ |
| `playerCurrencies` | `bool?` | no | _default=false_ |
| `playerStatistics` | `bool?` | no | _default=false_ |
| `playerDatas` | `bool?` | no | _default=false_ |
| `ipAddressCreate` | `bool?` | no | _default=false_ |
| `countryCode` | `bool?` | no | _default=false_ |
| `tsLastLogin` | `bool?` | no | _default=false_ |
| `playerInventories` | `bool?` | no | Includes relation items for inventory owned by the character, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `playerGroups` | `bool?` | no | Includes relation items for groups joined or owned by the character, optionally filtered by `groupCatalogIds`. — _default=false_ |
| `playerFriends` | `bool?` | no | Includes relation items for friends attached to the character, optionally filtered by `friendCatalogIds`. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |
| `characterCatalogIds` | `List<string>?` | no | _elementCls=String_ |
| `itemCatalogIds` | `List<string>?` | no | Restricts `playerInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `groupCatalogIds` | `List<string>?` | no | Restricts `playerGroups` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `friendCatalogIds` | `List<string>?` | no | Restricts `playerFriends` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### AddPlayerFriendRequestData

Defines the request payload for AddPlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |
| `friendId` | `string` | yes | _minLength=11, maxLength=11_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerAddPlayerFriendRequestData

Extends: `AddPlayerFriendRequestData`

Defines the request payload for ServerAddPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `AddPlayerFriendRequestData`._

### AdminAddPlayerFriendRequestData

Extends: `ServerAddPlayerFriendRequestData`

Defines the request payload for AdminAddPlayerFriend.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerAddPlayerFriendRequestData`._

- ... toàn bộ CharacterPlayerModels

```

nội dung ## Namespace `CharacterPlayerRequestModels` được tách ra thành file như sau:
/docs/reference/dto/character-player/CHARACTER_PLAYER_REQUEST_MODELS.md
```markdown
### AddPlayerFriendOperationRequest

Extends: `CustomOperationRequestAbstract<CharacterPlayerModels.AddPlayerFriendRequestData>`

Maps the AddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddPlayerFriendOperationRequest

Extends: `AddPlayerFriendOperationRequest`

Maps the ServerAddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddPlayerFriendOperationRequest

Extends: `AddPlayerFriendOperationRequest`

Maps the AdminAddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

- ... toàn bộ CharacterPlayerRequestModels

```

nội dung ## Namespace `CharacterPlayerResponseModels` được tách ra thành file như sau:
/docs/reference/dto/character-player/CHARACTER_PLAYER_RESPONSE_MODELS.md
```markdown
### AddPlayerFriendOperationResponse

Extends: `CustomOperationResponseAbstract<CharacterPlayerModels.EmptyResponseData>`

Maps the AddPlayerFriend operation to a typed response wrapper.

_Không có field public (payload rỗng)._

- ... toàn bộ CharacterPlayerResponseModels

```
> Internal maintenance doc. Không dùng file này làm nguồn canonical khi sinh code sử dụng SDK.
