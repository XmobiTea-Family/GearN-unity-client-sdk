# Operation base classes

Reference nhanh cho các base class operation wrapper thường xuất hiện trong `Extends` của DTO reference:

- `CustomOperationRequest`
- `CustomOperationRequestAbstract<TRequestData>`
- `CustomOperationResponse`
- `CustomOperationResponseAbstract<TResponseData>`

Các class này là **wrapper cấp thấp** quanh `OperationRequest` / `OperationResponse`. Khi tích hợp SDK bình thường, ưu tiên gọi public API qua `GNNetwork.<group>.<method>Async(requestData, ...)`; chỉ cần đọc file này khi bạn:

- gặp dòng `Extends: CustomOperationRequestAbstract<...>` hoặc `Extends: CustomOperationResponseAbstract<...>` trong [DTO_INDEX.md](/docs/reference/DTO_INDEX.md);
- tự viết custom operation/request wrapper;
- debug behavior nội bộ SDK hoặc CloudScript helper.

## Request wrapper

`CustomOperationRequestAbstract<TRequestData>` kế thừa `CustomOperationRequest` và thêm typed payload:

```csharp
public TRequestData requestData { get; }
```

Contract:

- `TRequestData` phải có constructor rỗng (`where TRequestData : new()`).
- Constructor `(int timeout)` tự tạo `requestData = new TRequestData()`.
- Constructor `(TRequestData requestData, int timeout)` dùng instance đã truyền vào.
- `build()` tạo `OperationRequest(operationCode, operationTimeout)` rồi serialize toàn bộ `requestData` vào parameters.
- `operationCode`, `requestType`, `role` đến từ class operation cụ thể sinh sẵn trong từng API group.

Ví dụ đọc DTO reference:

```text
LoginByAccountOperationRequest
Extends: CustomOperationRequestAbstract<AuthenticateModels.LoginByAccountRequestData>
```

Nghĩa là operation request này chứa `requestData` kiểu `AuthenticateModels.LoginByAccountRequestData`. Khi gọi API cấp cao, bạn **không cần** tự tạo operation wrapper:

```csharp
var requestData = new AuthenticateModels.LoginByAccountRequestData();
requestData.username = username;
requestData.password = password;

var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);
```

Chỉ dùng `OperationRequest` / `CustomOperationRequestAbstract<T>` trực tiếp khi đang viết hoặc debug lớp SDK cấp thấp.

## Response wrapper

`CustomOperationResponse` chứa metadata chung của mọi response:

```csharp
res.operationCode;
res.parameters;
res.returnCode;
res.debugMessage;
res.errorCode;
res.invalidMembers;
res.hasReturnCodeError();
res.toString();
```

`CustomOperationResponseAbstract<TResponseData>` kế thừa `CustomOperationResponse` và thêm typed payload:

```csharp
public TResponseData responseData { get; private set; }
```

Contract:

- `setupOperationResponse(operationResponse)` gọi base để copy `operationCode`, `returnCode`, `debugMessage`, `parameters`, `invalidMembers`.
- Chỉ khi `returnCode == ReturnCode.Ok`, SDK mới đọc `errorCode` từ parameters.
- Chỉ khi `returnCode == ReturnCode.Ok`, `CustomOperationResponseAbstract<TResponseData>` mới deserialize parameters sang `responseData`.
- Vì vậy `errorCode` và `responseData` chỉ đáng tin sau khi đã check `returnCode`.

Pattern bắt buộc:

```csharp
if (res.returnCode != ReturnCode.Ok) return;
if (res.errorCode != ErrorCode.Ok) return;

UseResult(res.responseData);
```

## Khi dùng base response

Helper xử lý lỗi chung nên nhận `CustomOperationResponse`, không nhận generic abstract:

```csharp
void EnsureOk(CustomOperationResponse res)
{
    if (res.returnCode != ReturnCode.Ok) return;
    if (res.errorCode != ErrorCode.Ok) return;
}
```

Dùng `CustomOperationResponseAbstract<TResponseData>` hoặc response class cụ thể khi cần đọc `responseData` typed:

```csharp
AuthenticateRequestModels.LoginByAccountOperationResponse res;
AuthenticateModels.AuthenticateResponseData data = res.responseData;
```

Rule này cũng áp dụng cho CloudScript TypeScript helpers: helper generic nhận `CustomOperationResponse`; chỉ dùng `CustomOperationResponseAbstract<T>` khi cần `responseData` typed cụ thể.

## Anti-patterns

- Không bỏ qua check `returnCode` rồi đọc thẳng `responseData`.
- Không dùng `OperationResponse` raw cho helper public nếu response đã là `CustomOperationResponse`.
- Không dùng `CustomOperationResponseAbstract<T>` cho helper generic chỉ cần check lỗi.
- Không suy ra route/permission từ base class generic; route đến từ namespace gọi (`client`, `.server`, `.admin`) và operation concrete.
- Không sửa `requestData` sau khi đã gọi `build()` và kỳ vọng `OperationRequest` đã build tự cập nhật.

## Source fallback

Nếu docs chưa đủ, public implementation nằm ở:

- `Runtime/Entity/Request/CustomOperationRequest.cs`
- `Runtime/Entity/Response/CustomOperationResponse.cs`
