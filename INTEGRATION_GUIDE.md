# Integration Guide

Guide ngắn cho project Unity khác đang **dùng package**, không phải sửa source bên trong package.

Nếu cần router chi tiết hơn, đọc [docs/START_HERE.md](/docs/START_HERE.md). Rule canonical nằm ở [docs/RULES.md](/docs/RULES.md).

## 1. Setup Tối Thiểu

1. Add package `com.xmobitea.changx.gearn-unity-client-sdk` vào Unity project.
2. Mở menu `XmobiTea GearN/Open Settings`.
3. Tạo/cấu hình `Resources/GNServerSettings`.
4. Điền các field bắt buộc:
   - `serverAddress`
   - `serverPort`
   - `serverSocketPort` nếu cần realtime
   - `useSsl`
   - `messageType`
   - `secretKey`
   - `gameId` nếu backend yêu cầu chọn game context runtime

`GNNetwork` sẽ tự load asset này khi được dùng trong Play Mode. Không cần `GNNetwork.init(...)`.

## 2. Flow Tích Hợp Chuẩn

1. Gọi method public qua `GNNetwork.<group>.*Async(...)`.
2. Check `returnCode` trước.
3. Check `errorCode` sau.
4. Chỉ đọc `responseData` khi cả hai tầng đều `Ok`.

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

public class GearNBootstrap : MonoBehaviour
{
    private async void Start()
    {
        var infoRequestParam = new AuthenticateModels.InfoRequestParam();
        infoRequestParam.displayName = true;
        infoRequestParam.avatar = true;

        var requestData = new AuthenticateModels.LoginByCustomIdRequestData();
        requestData.customId = SystemInfo.deviceUniqueIdentifier;
        requestData.createPlayerIfNotExists = true;
        requestData.infoRequestParam = infoRequestParam;

        var loginResponse = await GNNetwork.authenticate.loginByCustomIdAsync(requestData);

        if (loginResponse.returnCode != ReturnCode.Ok)
        {
            Debug.LogError("Transport/permission error: " + loginResponse.debugMessage);
            return;
        }

        if (loginResponse.errorCode != ErrorCode.Ok)
        {
            Debug.LogError("Business error: " + loginResponse.errorCode);
            return;
        }

        var infoResponse = await GNNetwork.gamePlayer.getPlayerInformationAsync(
            new GamePlayerModels.GetPlayerInformationRequestData()
        );

        if (infoResponse.returnCode != ReturnCode.Ok) return;
        if (infoResponse.errorCode != ErrorCode.Ok) return;

        Debug.Log("UserId: " + loginResponse.responseData.userId);
    }
}
```

## 3. Chọn Route Đúng

- Unity game client: dùng `GNNetwork.<group>`
- Trusted backend / worker / CloudScript runtime: dùng `GNNetwork.<group>.server`
- Admin tool / dashboard script / backoffice: dùng `GNNetwork.<group>.admin`

Route là **trust boundary của caller**, không phải “target thuộc user nào”. Nếu đang ở Unity client, đừng nhảy sang `.server` hoặc `.admin` để vượt permission.

## 4. Socket Đúng Cách

Flow chuẩn:

1. Login HTTP thành công.
2. Subscribe handler.
3. Gọi `GNNetwork.connectSocket()`.
4. Chỉ gọi `GNNetwork.sendRequestAuthSocket()` khi socket đã connect trước khi có token, hoặc token vừa đổi và cần re-auth ngay.

```csharp
GNNetwork.subscriberOnConnectHandler(() => Debug.Log("socket connected"));
GNNetwork.subscriberOnDisconnectHandler(() => Debug.Log("socket disconnected"));
GNNetwork.setOnEventHandler(operationEvent => Debug.Log(operationEvent.toString()));

GNNetwork.connectSocket();
```

## 5. Khi Nào Cần Đọc Thêm

- Chọn method login đúng: [docs/guides/AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md)
- Chọn API group: [docs/reference/API_INDEX.md](/docs/reference/API_INDEX.md)
- Tra field DTO: [docs/reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md)
- Rule permission / `OperationNotAllow`: [docs/RULES.md](/docs/RULES.md)
- Scenario end-to-end: [docs/COOKBOOK.md](/docs/COOKBOOK.md)

## 6. Không Cần Đọc Đầu Tiên

- `Runtime/`
- `ARCHITECTURE.md`
- `REQUEST_FLOW.md`
- `DEVELOPMENT.md`
- `internal-docs/*`

Những file này dành cho maintainer hoặc cho task sửa SDK, không phải public contract đầu tiên để tích hợp package.
