# DTO Reference: Generic

Reusable embedded contracts shared by multiple domains (avatar, tag, currency, filter, pagination, …).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: Generic class là embedded item — nested trong parent DTO (vd `playerCurrencies: PlayerCurrencyParam[]`). Tạo qua `new GenericModels.<Class>()` và push vào collection của parent. Response cũng expose typed instance để đọc field theo schema dưới đây.

> **Khi nào tra file này**: Khi parent DTO (`GamePlayer`/`MasterPlayer`/`CharacterPlayer`/...) tham chiếu field kiểu `AvatarItem`/`TagItem`/`CurrencyItem`/... — không lặp lại schema trong file domain mà link sang đây.

## Danh sách

- **GenericModels** (from `Runtime/Entity/Models/GenericModels.cs`)
    - [AvatarItem](#avataritem)
    - [TagItem](#tagitem)
    - [BanItem](#banitem)
    - [DataItem](#dataitem)
    - [CurrencyItem](#currencyitem)
    - [StatisticsItem](#statisticsitem)
    - [CharacterItem](#characteritem)
    - [OwnerItem](#owneritem)
    - [RemoveStatusItem](#removestatusitem)
    - [InventoryItem](#inventoryitem)
    - [GroupItem](#groupitem)
    - [FriendItem](#frienditem)
    - [MemberItem](#memberitem)

---

## Namespace `GenericModels`

### AvatarItem

Represents a generic avatar payload.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | Avatar type identifier. User custom this type enum. |
| `value` | `string` | yes | Avatar value, typically a URL, file id, or provider-specific string. |

### TagItem

Represents a key-value tag entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Tag key used to identify the metadata entry. |
| `value` | `string` | yes | Tag value associated with `key`. |

### BanItem

Represents a ban state entry returned by player-auth or player-profile flows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsExpire` | `long` | yes | Expiration timestamp of the current ban state. |
| `reason` | `string` | yes | Human-readable ban reason when provided by the backend. |

### DataItem

Represents an arbitrary key-value data entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Data entry key used to identify the payload. |
| `value` | `object` | yes | Raw value returned by the backend. This may be a primitive, `GNHashtable`, `GNArray`, or plain object-like data. |

### CurrencyItem

Represents one currency entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Currency key such as the configured currency code or logical name. |
| `value` | `double` | yes | Numeric balance of the currency identified by `key`. |

### StatisticsItem

Represents one statistics entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Statistic key such as the configured metric name. |
| `value` | `double` | yes | Numeric value of the statistic identified by `key`. |

### CharacterItem

Represents a lightweight relation item pointing to a character.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `characterId` | `string` | yes | Character identifier of the related character entity. |
| `catalogId` | `string` | yes | Catalog identifier associated with the related character. |

### OwnerItem

Represents the current owner of an entity such as an inventory item.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | Owner type. Map this value with the public `OwnerType` enum. |
| `id` | `string` | yes | Owner id paired with `type`. |

### RemoveStatusItem

Represents soft-remove metadata for an entity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsRemove` | `long` | yes | Removal timestamp when the entity was soft-removed. |
| `reason` | `string?` | no | Removal reason when the backend provides one. |

### InventoryItem

Represents a lightweight relation item pointing to an inventory item.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemId` | `string` | yes | Inventory item identifier of the related item entity. |
| `catalogId` | `string` | yes | Catalog identifier associated with the related inventory item. |
| `classId` | `string` | yes | Class identifier associated with the related inventory item. |

### GroupItem

Represents a lightweight relation item pointing to a group.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupId` | `string` | yes | Group identifier of the related group entity. |
| `catalogId` | `string` | yes | Catalog identifier associated with the related group. |
| `status` | `int` | yes | Group relation status. Map this value with the public `GroupStatus` enum. |
| `tsLastStatusUpdate` | `long` | yes | Timestamp of the last group status change. |

### FriendItem

Represents a lightweight relation item pointing to a friend relation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `friendId` | `string` | yes | Friend identifier of the related friend entity. |
| `catalogId` | `string` | yes | Catalog identifier associated with the related friend entity. |
| `status` | `int` | yes | Friend relation status. Map this value with the public `FriendStatus` enum. |
| `tsLastStatusUpdate` | `long` | yes | Timestamp of the last friend status change. |

### MemberItem

Represents a lightweight relation item pointing to a group member.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `memberId` | `string` | yes | Member identifier of the related group member. |
| `status` | `int` | yes | Member relation status. Map this value with the public member-status enum when available. |
