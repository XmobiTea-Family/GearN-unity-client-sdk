# Reference: DataMember Attributes

Trang này mô tả cách dùng 6 attribute `[DataMember]`, `[StringDataMember]`, `[NumberDataMember]`, `[BooleanDataMember]`, `[GNHashtableDataMember]`, `[GNArrayDataMember]` khi tự viết DTO cho custom request/response, custom `OperationEvent`, hoặc handler implement `IServerEventHandler`.

Public imports:

```csharp
using System.Collections.Generic;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
```

## Khi nào dùng

Dùng attribute khi SDK cần serialize/deserialize class typed:

- Request/response DTO custom.
- Payload class cho `OperationEvent` custom.
- Payload class trong `IServerEventHandler`.
- Nested object/list trong DTO.

Không dùng anonymous object hoặc dictionary thay cho DTO nếu code cần đi qua `ConverterService`; hãy tạo class có attribute để SDK đọc metadata đúng.

## Rule chung

Mỗi decorated field cần `code`, là key wire-level trong `GNHashtable`.

```csharp
public class RewardEvent
{
    [StringDataMember(code = "rewardId")]
    public string rewardId;

    [NumberDataMember(code = ParameterCode.Amount)]
    public int amount;
}
```

`code` phải khớp chính xác với key server gửi hoặc backend/API mong đợi:

- Key SDK có sẵn: dùng `ParameterCode.Amount`, `ParameterCode.Message`, `ParameterCode.Ts`.
- Key custom: dùng string literal như `"rewardId"`, `"sourceUserId"`.

## Common Options

Áp dụng cho mọi attribute:

<!-- prettier-ignore -->
| Option | Type | Default | Ý nghĩa |
| --- | --- | --- | --- |
| `code` | `string` | bắt buộc | Key trong `GNHashtable` khi serialize/deserialize. |
| `isOptional` | `bool` | `false` | Khi serialize, field `null`/missing có thể được bỏ qua thay vì gửi `null`. |
| `defaultValue` | theo field | `null` / default của type | Giá trị được fill khi deserialize mà wire payload thiếu field. |

## Chọn Attribute Nhanh

<!-- prettier-ignore -->
| C# field | Attribute |
| --- | --- |
| `string` | `[StringDataMember(code = ...)]` |
| `int`, `long`, `float`, `double` | `[NumberDataMember(code = ...)]` |
| `bool` | `[BooleanDataMember(code = ...)]` |
| `object` hoặc raw mixed value | `[DataMember(code = ...)]` |
| `GNHashtable` hoặc nested object payload | `[GNHashtableDataMember(code = ...)]` |
| `List<T>` / array-like payload | `[GNArrayDataMember(code = ..., elementCls = typeof(T))]` |

## Ví dụ dùng đủ 6 attribute

Ví dụ này mô tả một custom event payload `playerAttributeUpdated` có đủ các dạng attribute public:

```csharp
using System.Collections.Generic;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;

public class AttributeMeta
{
    [StringDataMember(code = "source")]
    public string source;

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}

public class AttributeHistoryItem
{
    [StringDataMember(code = ParameterCode.Key)]
    public string key;

    [DataMember(code = ParameterCode.Value)]
    public object value;
}

public class PlayerAttributeUpdatedEvent
{
    [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
    public string userId;

    [NumberDataMember(code = ParameterCode.Amount, minValue = 0, mustInt = true)]
    public int amount;

    [BooleanDataMember(code = "isCritical", isOptional = true, defaultValue = false)]
    public bool isCritical;

    [DataMember(code = ParameterCode.Value)]
    public object rawValue;

    [GNHashtableDataMember(code = "meta", isOptional = true)]
    public AttributeMeta meta;

    [GNHashtableDataMember(code = "rawMeta", isOptional = true)]
    public GNHashtable rawMeta;

    [GNArrayDataMember(code = "history", elementCls = typeof(AttributeHistoryItem), isOptional = true, maxLength = 32)]
    public List<AttributeHistoryItem> history;

    [GNArrayDataMember(code = ParameterCode.Keys, elementCls = typeof(string), isOptional = true)]
    public List<string> changedKeys;
}
```

Mapping trong ví dụ:

<!-- prettier-ignore -->
| Attribute | Field |
| --- | --- |
| `[StringDataMember]` | `userId`, `AttributeMeta.source`, `AttributeHistoryItem.key` |
| `[NumberDataMember]` | `amount`, `AttributeMeta.ts` |
| `[BooleanDataMember]` | `isCritical` |
| `[DataMember]` | `rawValue`, `AttributeHistoryItem.value` |
| `[GNHashtableDataMember]` | `meta`, `rawMeta` |
| `[GNArrayDataMember]` | `history`, `changedKeys` |

## `[StringDataMember]`

Dùng cho string field.

Options riêng:

<!-- prettier-ignore -->
| Option | Type | Default khi validation active | Ý nghĩa |
| --- | --- | --- | --- |
| `mustNonNull` | `bool` | `false` | Không cho phép `null`. |
| `minLength` | `int` | no constraint | Độ dài tối thiểu. |
| `maxLength` | `int` | no constraint | Độ dài tối đa. |
| `defaultValue` | `string` | `null` | Fill khi thiếu field lúc deserialize. |

Ví dụ:

```csharp
public class LoginParam
{
    [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
    public string username;

    [StringDataMember(code = "displayLabel", isOptional = true)]
    public string displayLabel;
}
```

## `[NumberDataMember]`

Dùng cho numeric field.

Options riêng:

<!-- prettier-ignore -->
| Option | Type | Default khi validation active | Ý nghĩa |
| --- | --- | --- | --- |
| `mustInt` | `bool` | `false` | Yêu cầu số nguyên. |
| `minValue` | `double` | no constraint | Giá trị tối thiểu. |
| `maxValue` | `double` | no constraint | Giá trị tối đa. |
| `defaultValue` | `double` | `0` | Fill khi thiếu field lúc deserialize. |

Ví dụ:

```csharp
public class PagingParam
{
    [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 1, maxValue = 100, mustInt = true, isOptional = true)]
    public int limit;
}
```

## `[BooleanDataMember]`

Dùng cho boolean field.

Options riêng:

<!-- prettier-ignore -->
| Option | Type | Ý nghĩa |
| --- | --- | --- |
| `defaultValue` | `bool` | Fill khi thiếu field lúc deserialize. |

Ví dụ:

```csharp
public class IncludeParam
{
    [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
    public bool displayName;
}
```

## `[DataMember]`

Dùng cho raw value hoặc field mixed type (`object`). Đây là attribute ít ràng buộc nhất.

Ví dụ:

```csharp
public class DataItem
{
    [StringDataMember(code = ParameterCode.Key)]
    public string key;

    [DataMember(code = ParameterCode.Value)]
    public object value;
}
```

Ưu tiên attribute cụ thể (`StringDataMember`, `NumberDataMember`, `BooleanDataMember`, `GNHashtableDataMember`, `GNArrayDataMember`) khi biết type. Dùng `DataMember` cho value có thể là primitive, `GNHashtable`, `GNArray`, hoặc object tùy backend.

## `[GNHashtableDataMember]`

Dùng cho payload object/nested hashtable.

Options riêng:

<!-- prettier-ignore -->
| Option | Type | Default khi validation active | Ý nghĩa |
| --- | --- | --- | --- |
| `mustNonNull` | `bool` | `false` | Không cho phép `null`. |
| `minLength` | `int` | no constraint | Số key tối thiểu. |
| `maxLength` | `int` | no constraint | Số key tối đa. |
| `defaultValue` | `GNHashtable` | `null` | Fill khi thiếu field lúc deserialize. |

Ví dụ dùng raw `GNHashtable`:

```csharp
public class EventEnvelope
{
    [GNHashtableDataMember(code = ParameterCode.EventParameters, isOptional = true, minLength = 0, maxLength = 128)]
    public GNHashtable eventParameters;
}
```

Ví dụ nested object typed:

```csharp
public class AvatarInfo
{
    [StringDataMember(code = ParameterCode.Value)]
    public string value;
}

public class PlayerSummary
{
    [StringDataMember(code = ParameterCode.DisplayName, isOptional = true)]
    public string displayName;

    [GNHashtableDataMember(code = ParameterCode.Avatar, isOptional = true)]
    public AvatarInfo avatar;
}
```

## `[GNArrayDataMember]`

Dùng cho array/list. Với list object typed, luôn truyền `elementCls` để deserializer biết class phần tử.

Options riêng:

<!-- prettier-ignore -->
| Option | Type | Default khi validation active | Ý nghĩa |
| --- | --- | --- | --- |
| `elementCls` | `Type` | theo reflection của field nếu bỏ qua | Class phần tử; nên truyền rõ ràng cho list. |
| `mustNonNull` | `bool` | `false` | Không cho phép `null`. |
| `minLength` | `int` | no constraint | Số phần tử tối thiểu. |
| `maxLength` | `int` | no constraint | Số phần tử tối đa. |
| `defaultValue` | `GNArray` | `null` | Fill khi thiếu field lúc deserialize. |

List primitive:

```csharp
public class KeysParam
{
    [GNArrayDataMember(code = ParameterCode.Keys, isOptional = true, elementCls = typeof(string))]
    public List<string> keys;
}
```

List object typed:

```csharp
public class CurrencyItem
{
    [StringDataMember(code = ParameterCode.Key)]
    public string key;

    [NumberDataMember(code = ParameterCode.Value)]
    public int value;
}

public class CurrencyUpdateEvent
{
    [GNArrayDataMember(code = ParameterCode.PlayerCurrencies, elementCls = typeof(CurrencyItem), minLength = 1, maxLength = 32, mustNonNull = true)]
    public List<CurrencyItem> playerCurrencies;
}
```

## Custom `OperationEvent` Typed Payload

Server/CloudScript gửi:

```ts
const operationEvent = new OperationEvent(
    "cloudScriptRewardGranted",
    GNHashtable.builder()
        .add("rewardId", "daily-login")
        .add("amount", 100)
        .add("reason", "dailyLogin")
        .add("ts", Date.now())
        .build()
);
```

Client DTO:

```csharp
public class CloudScriptRewardGrantedEvent
{
    [StringDataMember(code = "rewardId")]
    public string rewardId;

    [NumberDataMember(code = ParameterCode.Amount)]
    public int amount;

    [StringDataMember(code = ParameterCode.Reason)]
    public string reason;

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}
```

Client handler:

```csharp
public void handle(OperationEvent operationEvent)
{
    var payload = ConverterService.deserializeObject<CloudScriptRewardGrantedEvent>(
        operationEvent.getParameters()
    );

    // use payload.rewardId / payload.amount / payload.reason / payload.ts
}
```

## Pitfalls

- Attribute `code` sai key thì field deserialize ra `null`, `0`, `false`, hoặc `defaultValue`.
- Quên `elementCls` với `[GNArrayDataMember]` chứa object typed thì list có thể không deserialize đúng class phần tử.
- Dùng anonymous object/dictionary thay DTO không tạo metadata mới; hãy tạo class có attribute và truyền class đó vào `ConverterService`.
