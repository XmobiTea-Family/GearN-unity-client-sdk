# DTO Reference: Generic

Reusable embedded contracts shared by multiple domains (avatar, tag, currency, filter, pagination, …).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: Generic class là embedded item — nested trong parent DTO (vd `playerCurrencies: PlayerCurrencyParam[]`). Tạo qua `new GenericModels.<Class>()` và push vào collection của parent. Response cũng expose typed instance để đọc field theo schema dưới đây.

> **Khi nào tra file này**: Khi parent DTO (`GamePlayer`/`MasterPlayer`/`CharacterPlayer`/...) tham chiếu field kiểu `AvatarItem`/`TagItem`/`CurrencyItem`/... — không lặp lại schema trong file domain mà link sang đây.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

> **Operation base**: Nếu class `*OperationRequest` extends `CustomOperationRequestAbstract<TRequestData>` hoặc class `*OperationResponse` extends `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) để hiểu `requestData`, `build()`, `setupOperationResponse()`, và `responseData`.

## Danh sách

- **GenericModels** (from `Runtime/Entity/Models/GenericModels.cs`)
  - [Generic.AvatarItem:1-10](/docs/reference/dto/generic/GENERIC_MODELS.md#avataritem)
  - [Generic.TagItem:11-20](/docs/reference/dto/generic/GENERIC_MODELS.md#tagitem)
  - [Generic.BanItem:21-30](/docs/reference/dto/generic/GENERIC_MODELS.md#banitem)
  - [Generic.DataItem:31-40](/docs/reference/dto/generic/GENERIC_MODELS.md#dataitem)
  - [Generic.CurrencyItem:41-50](/docs/reference/dto/generic/GENERIC_MODELS.md#currencyitem)
  - [Generic.StatisticsItem:51-60](/docs/reference/dto/generic/GENERIC_MODELS.md#statisticsitem)
  - [Generic.CharacterItem:61-70](/docs/reference/dto/generic/GENERIC_MODELS.md#characteritem)
  - [Generic.OwnerItem:71-80](/docs/reference/dto/generic/GENERIC_MODELS.md#owneritem)
  - [Generic.RemoveStatusItem:81-90](/docs/reference/dto/generic/GENERIC_MODELS.md#removestatusitem)
  - [Generic.InventoryItem:91-101](/docs/reference/dto/generic/GENERIC_MODELS.md#inventoryitem)
  - [Generic.GroupItem:102-113](/docs/reference/dto/generic/GENERIC_MODELS.md#groupitem)
  - [Generic.FriendItem:114-125](/docs/reference/dto/generic/GENERIC_MODELS.md#frienditem)
  - [Generic.MemberItem:126-134](/docs/reference/dto/generic/GENERIC_MODELS.md#memberitem)
