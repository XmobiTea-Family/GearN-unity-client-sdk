# DTO Reference: Authenticate

Player login (account, social, device id), register, refresh auth token.

Related API reference: [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md).

Mỗi section bên dưới là 1 class DTO public trong namespace `XmobiTea.GearN.Entity.Models`. `AuthenticateModels`, `AuthenticateRequestModels`, và `AuthenticateResponseModels` là các container class chứa DTO tương ứng. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new AuthenticateModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Pitfall**: `infoRequestParam` là field required ở các flow login/register. Truyền một instance `new AuthenticateModels.InfoRequestParam()` kể cả khi không cần hydrate field nào, và chỉ bật field bạn thật sự render. Đừng `null` (request có thể invalid hoặc backend không hydrate gì) và đừng bulk-set hết (payload bự, slow). Xem [RULES § 10 #11-12](/docs/RULES.md#10-anti-patterns--pitfalls).

> **Lưu ý route**: `AuthenticateApi` operations chỉ qua route `client` — không có Server/Admin variant cho các operation authenticate.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

> **Operation base**: Nếu class `*OperationRequest` extends `CustomOperationRequestAbstract<TRequestData>` hoặc class `*OperationResponse` extends `CustomOperationResponseAbstract<TResponseData>`, xem [OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) để hiểu `requestData`, `build()`, `setupOperationResponse()`, và `responseData`.

## Danh sách

- **AuthenticateModels** (from `Runtime/Entity/Models/AuthenticateModels.cs`)
  - [AuthenticateModels.InfoRequestParam:1-29](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#inforequestparam)
  - [AuthenticateModels.LoginByAccountRequestData:30-44](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyaccountrequestdata)
  - [AuthenticateModels.LoginByAndroidDeviceIdRequestData:45-59](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyandroiddeviceidrequestdata)
  - [AuthenticateModels.LoginByAppleRequestData:60-74](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyapplerequestdata)
  - [AuthenticateModels.LoginByCustomDeviceIdRequestData:75-89](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbycustomdeviceidrequestdata)
  - [AuthenticateModels.LoginByCustomIdRequestData:90-104](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbycustomidrequestdata)
  - [AuthenticateModels.LoginByEditorDeviceIdRequestData:105-119](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyeditordeviceidrequestdata)
  - [AuthenticateModels.LoginByFacebookRequestData:120-134](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyfacebookrequestdata)
  - [AuthenticateModels.LoginByGenericServiceRequestData:135-150](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygenericservicerequestdata)
  - [AuthenticateModels.LoginByGoogleRequestData:151-166](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygooglerequestdata)
  - [AuthenticateModels.LoginByGooglePlayGameServiceRequestData:167-181](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygoogleplaygameservicerequestdata)
  - [AuthenticateModels.LoginByGameCenterRequestData:182-201](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbygamecenterrequestdata)
  - [AuthenticateModels.LoginByiOSDeviceIdRequestData:202-216](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbyiosdeviceidrequestdata)
  - [AuthenticateModels.LoginByLinuxDeviceIdRequestData:217-231](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbylinuxdeviceidrequestdata)
  - [AuthenticateModels.LoginByMacOSDeviceIdRequestData:232-246](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbymacosdeviceidrequestdata)
  - [AuthenticateModels.LoginByWindowsDeviceIdRequestData:247-261](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbywindowsdeviceidrequestdata)
  - [AuthenticateModels.LoginByWindowsPhoneDeviceIdRequestData:262-276](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#loginbywindowsphonedeviceidrequestdata)
  - [AuthenticateModels.RegisterAccountRequestData:277-291](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#registeraccountrequestdata)
  - [AuthenticateModels.RefreshAuthTokenRequestData:292-297](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#refreshauthtokenrequestdata)
  - [AuthenticateModels.AuthenticateResponseData:298-315](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#authenticateresponsedata)
  - [AuthenticateModels.GenericServiceAuthenticateResponseData:298-332](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#genericserviceauthenticateresponsedata)
  - [AuthenticateModels.RefreshAuthTokenResponseData:333-346](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#refreshauthtokenresponsedata)
  - [AuthenticateModels.EmptyResponseData:347-351](/docs/reference/dto/authenticate/AUTHENTICATE_MODELS.md#emptyresponsedata)
- **AuthenticateRequestModels** (from `Runtime/Entity/Models/AuthenticateRequestModels.cs`)
  - [AuthenticateRequestModels.LoginByAccountOperationRequest:1-12](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyaccountoperationrequest)
  - [AuthenticateRequestModels.LoginByAndroidDeviceIdOperationRequest:13-24](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyandroiddeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByAppleOperationRequest:25-36](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyappleoperationrequest)
  - [AuthenticateRequestModels.LoginByCustomDeviceIdOperationRequest:37-48](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbycustomdeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByCustomIdOperationRequest:49-60](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbycustomidoperationrequest)
  - [AuthenticateRequestModels.LoginByEditorDeviceIdOperationRequest:61-72](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyeditordeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByFacebookOperationRequest:73-84](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyfacebookoperationrequest)
  - [AuthenticateRequestModels.LoginByGenericServiceOperationRequest:85-96](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbygenericserviceoperationrequest)
  - [AuthenticateRequestModels.LoginByGoogleOperationRequest:97-108](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbygoogleoperationrequest)
  - [AuthenticateRequestModels.LoginByGooglePlayGameServiceOperationRequest:109-120](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbygoogleplaygameserviceoperationrequest)
  - [AuthenticateRequestModels.LoginByGameCenterOperationRequest:121-132](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbygamecenteroperationrequest)
  - [AuthenticateRequestModels.LoginByiOSDeviceIdOperationRequest:133-144](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbyiosdeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByLinuxDeviceIdOperationRequest:145-156](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbylinuxdeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByMacOSDeviceIdOperationRequest:157-168](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbymacosdeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByWindowsDeviceIdOperationRequest:169-180](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbywindowsdeviceidoperationrequest)
  - [AuthenticateRequestModels.LoginByWindowsPhoneDeviceIdOperationRequest:181-192](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#loginbywindowsphonedeviceidoperationrequest)
  - [AuthenticateRequestModels.RegisterAccountOperationRequest:193-204](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#registeraccountoperationrequest)
  - [AuthenticateRequestModels.RefreshAuthTokenOperationRequest:205-215](/docs/reference/dto/authenticate/AUTHENTICATE_REQUEST_MODELS.md#refreshauthtokenoperationrequest)
- **AuthenticateResponseModels** (from `Runtime/Entity/Models/AuthenticateResponseModels.cs`)
  - [AuthenticateResponseModels.LoginByAccountOperationResponse:1-12](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyaccountoperationresponse)
  - [AuthenticateResponseModels.LoginByAndroidDeviceIdOperationResponse:13-24](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyandroiddeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByAppleOperationResponse:25-36](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyappleoperationresponse)
  - [AuthenticateResponseModels.LoginByCustomDeviceIdOperationResponse:37-48](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbycustomdeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByCustomIdOperationResponse:49-60](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbycustomidoperationresponse)
  - [AuthenticateResponseModels.LoginByEditorDeviceIdOperationResponse:61-72](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyeditordeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByFacebookOperationResponse:73-84](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyfacebookoperationresponse)
  - [AuthenticateResponseModels.LoginByGenericServiceOperationResponse:85-96](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbygenericserviceoperationresponse)
  - [AuthenticateResponseModels.LoginByGoogleOperationResponse:97-108](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbygoogleoperationresponse)
  - [AuthenticateResponseModels.LoginByGooglePlayGameServiceOperationResponse:109-120](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbygoogleplaygameserviceoperationresponse)
  - [AuthenticateResponseModels.LoginByGameCenterOperationResponse:121-132](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbygamecenteroperationresponse)
  - [AuthenticateResponseModels.LoginByiOSDeviceIdOperationResponse:133-144](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbyiosdeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByLinuxDeviceIdOperationResponse:145-156](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbylinuxdeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByMacOSDeviceIdOperationResponse:157-168](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbymacosdeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByWindowsDeviceIdOperationResponse:169-180](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbywindowsdeviceidoperationresponse)
  - [AuthenticateResponseModels.LoginByWindowsPhoneDeviceIdOperationResponse:181-192](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#loginbywindowsphonedeviceidoperationresponse)
  - [AuthenticateResponseModels.RegisterAccountOperationResponse:193-204](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#registeraccountoperationresponse)
  - [AuthenticateResponseModels.RefreshAuthTokenOperationResponse:205-215](/docs/reference/dto/authenticate/AUTHENTICATE_RESPONSE_MODELS.md#refreshauthtokenoperationresponse)

---
