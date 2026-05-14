# Reference: GNArray & GNHashtable

`GNArray` và `GNHashtable` là 2 container dữ liệu động trong namespace `XmobiTea.GearN.Common`.
SDK dùng chúng để biểu diễn payload dạng array/object khi gửi request custom, nhận response raw, truyền `customTags`, tham số `OperationEvent`, hoặc field DTO có kiểu `GNArray` / `GNHashtable`.

Public imports:

```csharp
using System.Collections;
using System.Collections.Generic;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Entity;
```

## Khi nào dùng

Dùng `GNHashtable` khi payload có key string:

- `customTags` cho API call.
- `functionParameters` cho CloudScript.
- `OperationEvent` parameters.
- Raw object field trong DTO custom.
- Dữ liệu nested không cần class DTO riêng.

Dùng `GNArray` khi payload là danh sách:

- List key/value, list id, list item.
- Nested array trong `GNHashtable`.
- Raw array field trong DTO custom.

Nếu payload có schema cố định và được serialize/deserialize qua `ConverterService`, ưu tiên viết DTO với DataMember attribute. Xem [DATAMEMBER.md](/docs/reference/DATAMEMBER.md).

## Tạo nhanh

Public C# hiện tại expose nested `Builder`, vì vậy form an toàn là `new GNHashtable.Builder()` và `new GNArray.Builder()`.

```csharp
var tags = new GNHashtable.Builder()
    .add("traceId", "trace-001")
    .add("build", "qa")
    .add("abBucket", "A")
    .build();

var rewards = new GNArray.Builder()
    .add("coin")
    .add("gem")
    .add("ticket")
    .build();
```

Có thể tạo trực tiếp rồi `add`:

```csharp
var payload = new GNHashtable();
payload.add("source", "daily_popup");
payload.add("amount", 100);
payload.add("isBonus", true);

var ids = new GNArray();
ids.add("item_001");
ids.add("item_002");
payload.add("itemIds", ids);
```

## Nested payload

`GNHashtable.add()` và `GNArray.add()` tự convert `IList` thành `GNArray`, `IDictionary` thành `GNHashtable`.
Nếu dùng `Builder`, conversion diễn ra khi gọi `.build()` vì `build()` tạo container thật rồi gọi `add()`.
Với dictionary, chỉ key kiểu `string` được copy bởi `GNHashtable.Builder.addAll()`.

```csharp
var metadata = new Dictionary<string, object>
{
    { "source", "quest" },
    { "questId", "quest_daily_01" },
};

var payload = new GNHashtable.Builder()
    .add("userId", userId)
    .add("amount", 50)
    .add("metadata", metadata)
    .add("items", new List<object> { "coin", "gem" })
    .build();

GNHashtable meta = payload.getGNHashtable("metadata");
GNArray items = payload.getGNArray("items");
```

## Đọc dữ liệu từ GNHashtable

`GNHashtable` đọc theo key string và có getter typed cho primitive, string, object, array/list, `GNArray`, `GNHashtable`.

<!-- prettier-ignore -->
| Method | Return | Ghi chú |
| --- | --- | --- |
| `getByte(key, defaultValue)` | `byte` | Convert bằng `System.Convert`. |
| `getSByte(key, defaultValue)` | `sbyte` | Convert bằng `System.Convert`. |
| `getShort(key, defaultValue)` | `short` | Convert bằng `System.Convert`. |
| `getInt(key, defaultValue)` | `int` | Convert bằng `System.Convert`. |
| `getFloat(key, defaultValue)` | `float` | Convert bằng `System.Convert`. |
| `getLong(key, defaultValue)` | `long` | Convert bằng `System.Convert`. |
| `getDouble(key, defaultValue)` | `double` | Convert bằng `System.Convert`. |
| `getBool(key, defaultValue)` | `bool` | Convert bằng `System.Convert`. |
| `getString(key, defaultValue)` | `string` | Convert bằng `System.Convert`. |
| `getObject(key, defaultValue)` | `object` | Raw value đã lưu trong container. |
| `getArray<T>(key, defaultValue)` | `T[]` | Yêu cầu value là `GNArray`. |
| `getList<T>(key, defaultValue)` | `IList<T>` | Yêu cầu value là `GNArray`. |
| `getGNArray(key, defaultValue)` | `GNArray` | Lấy nested array. |
| `getGNHashtable(key, defaultValue)` | `GNHashtable` | Lấy nested object. |

Ví dụ:

```csharp
string source = payload.getString("source", "unknown");
int amount = payload.getInt("amount", 0);
bool isBonus = payload.getBool("isBonus", false);

GNHashtable meta = payload.getGNHashtable("metadata");
string questId = meta != null ? meta.getString("questId") : null;

IList<string> items = payload.getList<string>("items", new List<string>());
```

Với payload động từ server hoặc CloudScript, nếu không chắc kiểu dữ liệu, kiểm tra bằng `containsKey()` và `getObject()` trước khi dùng typed getter:

```csharp
if (payload.containsKey("amount"))
{
    object rawAmount = payload.getObject("amount");
    if (rawAmount is int || rawAmount is long || rawAmount is float || rawAmount is double)
    {
        int amountValue = payload.getInt("amount", 0);
    }
}
```

## Đọc dữ liệu từ GNArray

`GNArray` đọc theo index `int` và có bộ getter tương tự `GNHashtable`.

<!-- prettier-ignore -->
| Method | Return | Ghi chú |
| --- | --- | --- |
| `getByte(index, defaultValue)` | `byte` | Convert bằng `System.Convert`. |
| `getSByte(index, defaultValue)` | `sbyte` | Convert bằng `System.Convert`. |
| `getShort(index, defaultValue)` | `short` | Convert bằng `System.Convert`. |
| `getInt(index, defaultValue)` | `int` | Convert bằng `System.Convert`. |
| `getFloat(index, defaultValue)` | `float` | Convert bằng `System.Convert`. |
| `getLong(index, defaultValue)` | `long` | Convert bằng `System.Convert`. |
| `getDouble(index, defaultValue)` | `double` | Convert bằng `System.Convert`. |
| `getBool(index, defaultValue)` | `bool` | Convert bằng `System.Convert`. |
| `getString(index, defaultValue)` | `string` | Convert bằng `System.Convert`. |
| `getObject(index, defaultValue)` | `object` | Raw value đã lưu trong container. |
| `getArray<T>(index, defaultValue)` | `T[]` | Yêu cầu value là `GNArray`. |
| `getList<T>(index, defaultValue)` | `IList<T>` | Yêu cầu value là `GNArray`. |
| `getGNArray(index, defaultValue)` | `GNArray` | Lấy nested array. |
| `getGNHashtable(index, defaultValue)` | `GNHashtable` | Lấy nested object. |

Ví dụ:

```csharp
var arr = new GNArray.Builder()
    .add("coin")
    .add(100)
    .add(true)
    .build();

string itemId = arr.getString(0);
int amount = arr.getInt(1);
bool active = arr.getBool(2);
```

Index âm hoặc vượt quá `count() - 1` trả về `defaultValue`.

## Collection API

<!-- prettier-ignore -->
| Type | Method / indexer | Ý nghĩa |
| --- | --- | --- |
| `GNHashtable` | `add(string key, object value)` | Thêm hoặc update key. |
| `GNHashtable` | `this[string key]` | Get/set raw object theo key. |
| `GNHashtable` | `keys()` | Trả về collection key hiện có. |
| `GNHashtable` | `values()` | Trả về collection value hiện có. |
| `GNHashtable` | `containsKey(string key)` | Check key tồn tại. |
| `GNHashtable` | `remove(string key)` | Xóa key, trả về `true` nếu xóa được. |
| `GNHashtable` | `clear()` | Xóa toàn bộ key. |
| `GNHashtable` | `count()` | Số key hiện có. |
| `GNArray` | `add(object value)` | Append value. |
| `GNArray` | `this[int index]` | Get/set raw object theo index. |
| `GNArray` | `values()` | Trả về collection value hiện có. |
| `GNArray` | `remove(int index)` | Xóa index, trả về `true` nếu không throw. |
| `GNArray` | `clear()` | Xóa toàn bộ phần tử. |
| `GNArray` | `count()` | Số phần tử hiện có. |

Ví dụ duyệt:

```csharp
foreach (var key in payload.keys())
{
    object value = payload.getObject(key);
    UnityEngine.Debug.Log(key + " = " + value);
}

for (var i = 0; i < rewards.count(); i++)
{
    UnityEngine.Debug.Log(rewards.getString(i));
}
```

## toData() và ToString()

`toData()` convert container về dữ liệu C# serializable:

- `GNHashtable` -> `Dictionary<string, object>`.
- `GNArray` -> `List<object>`.
- Nested `GNHashtable` / `GNArray` cũng được convert đệ quy.

```csharp
object rawPayload = payload.toData();
```

`ToString()` / `toString()` trả về chuỗi JSON-like để debug/log nhanh.
Không dùng output này như JSON parser contract nghiêm ngặt; string escaping không được thiết kế như serializer JSON đầy đủ.

```csharp
UnityEngine.Debug.Log(payload.ToString());
```

## Convert DTO và GNData

Với payload có schema cố định, nên dùng DTO + DataMember attribute rồi để `ConverterService` convert qua lại với `GNHashtable` / `GNArray`.

```csharp
using XmobiTea.GearN.Helper;

GNHashtable table = ConverterService.serializeObject(dto);
MyDto dto2 = ConverterService.deserializeObject<MyDto>(table);

GNArray array = ConverterService.serializeArray(dtoList);
IList dtoList2 = ConverterService.deserializeArray<MyDto>(array);
```

Rule chọn nhanh:

<!-- prettier-ignore -->
| Nhu cầu | Nên dùng |
| --- | --- |
| Payload ngắn, dynamic, ít field | `GNHashtable` / `GNArray` trực tiếp |
| Request/response có schema ổn định | DTO + DataMember |
| Nested object/list có type rõ | DTO nested + `[GNHashtableDataMember]` / `[GNArrayDataMember]` |
| Debug/log nhanh | `ToString()` |
| Gửi qua serializer ngoài SDK | `toData()` |

## Ví dụ: customTags

`customTags` là `GNHashtable` gắn theo API call để trace/log/route phía backend. Không đưa secret, auth token, PII nhạy cảm hoặc object quá sâu vào `customTags`.

```csharp
var customTags = new GNHashtable.Builder()
    .add("traceId", System.Guid.NewGuid().ToString("N"))
    .add("build", UnityEngine.Application.version)
    .add("source", "daily_reward")
    .build();

var response = await GNNetwork.cloudScript.executeFunctionAsync(
    request,
    customTags: customTags
);
```

## Ví dụ: OperationEvent parameters

```csharp
using XmobiTea.GearN.Entity;

var parameters = new GNHashtable.Builder()
    .add("message", "hello")
    .add("ts", GNNetwork.getServerTimestamp())
    .build();

var evt = new OperationEvent("chatMessage", parameters);
```

Khi nhận event:

```csharp
GNNetwork.setOnEventHandler(evt =>
{
    GNHashtable parameters = evt.getParameters();
    string message = parameters != null ? parameters.getString("message") : null;
    long ts = parameters != null ? parameters.getLong("ts") : 0;
});
```

## Lưu ý quan trọng

- Key của `GNHashtable` là `string`; dictionary có key không phải string sẽ bị bỏ qua khi dùng `Builder.addAll()`.
- Getter numeric/bool/string dùng `System.Convert`; nếu key/index thiếu hoặc value là `null` thì dùng `defaultValue`, nhưng nếu value tồn tại mà không convert được thì C# có thể throw exception. Với dữ liệu từ server, đọc defensive bằng `containsKey()` / `getObject()` rồi mới gọi typed getter khi cần.
- `getGNArray()` / `getGNHashtable()` cast trực tiếp; chỉ gọi khi biết value đúng kiểu container.
- `remove(index)` của `GNArray` gọi `List.RemoveAt(index)`; index không hợp lệ sẽ throw.
- Dùng `new GNHashtable.Builder()` / `new GNArray.Builder()` theo public C# hiện tại. Một số ví dụ cũ có thể viết style `GNHashtable.builder()`; style đó chỉ dùng được nếu project của bạn có helper/extension riêng.
- Với payload có schema ổn định, DTO + DataMember attribute dễ kiểm soát hơn raw `GNHashtable`.
