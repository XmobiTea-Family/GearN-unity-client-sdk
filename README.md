# GearN Unity Client SDK

SDK Unity/C# client cho GearN Server.

`GNNetwork` là entrypoint public chính. Khi Unity runtime load SDK, `GNNetwork` tự đọc `GNServerSettings` từ `Resources/GNServerSettings`, tạo networking peer, cache auth state, và expose 11 API group: `GNNetwork.authenticate`, `GNNetwork.masterPlayer`, `GNNetwork.gamePlayer`, `GNNetwork.characterPlayer`, `GNNetwork.group`, `GNNetwork.inventory`, `GNNetwork.storeInventory`, `GNNetwork.content`, `GNNetwork.multiplayer`, `GNNetwork.cloudScript`, `GNNetwork.dashboard`.

> **Mục tiêu chính của repo này:** đây là package để import vào game Unity khác. Nếu bạn chỉ cần dùng SDK, **đừng bắt đầu từ `Runtime/`**.

> **AI / code assistant:** đọc [docs/START_HERE.md](/docs/START_HERE.md) trước, rồi [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) và [docs/RULES.md](/docs/RULES.md).

Package Unity: `com.xmobitea.changx.gearn-unity-client-sdk`. Rule canonical: [docs/RULES.md](/docs/RULES.md).

## Start Here

<!-- prettier-ignore -->
| Tôi cần... | Mở file này |
| --- | --- |
| Luồng đọc tối thiểu cho package consumer | [docs/START_HERE.md](/docs/START_HERE.md) |
| One-page reference cho AI | [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) |
| Rule canonical (route, permission, socket, error) | [docs/RULES.md](/docs/RULES.md) |
| Chọn API group / method | [docs/reference/API_INDEX.md](/docs/reference/API_INDEX.md) |
| Scenario end-to-end | [docs/COOKBOOK.md](/docs/COOKBOOK.md) |
| DTO field cụ thể | [docs/reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md) |
| Tích hợp nhanh vào game | [INTEGRATION_GUIDE.md](/INTEGRATION_GUIDE.md) |

Không cần đọc [ARCHITECTURE.md](/ARCHITECTURE.md), [REQUEST_FLOW.md](/REQUEST_FLOW.md), [DEVELOPMENT.md](/DEVELOPMENT.md), hoặc `Runtime/` nếu mục tiêu chỉ là gọi SDK đúng từ game.

## 1. Yêu cầu

- Unity `2020.3` trở lên.
- Dependency package: `com.xmobitea.changx.app`.
- Một asset `GNServerSettings` trong `Resources/GNServerSettings`.
- Nếu dùng socket realtime, cài transport socket tương ứng và bật define cần thiết (`UNITY_USING_BEST_HTTP` hoặc `UNITY_USING_SOCKET_IO_UNITY`) theo setup project.

## 2. Cài đặt

Thêm package vào Unity project qua UPM/git/local package theo workflow của project. Package name trong `package.json`:

```json
"com.xmobitea.changx.gearn-unity-client-sdk"
```

Sau khi import package, mở menu Unity:

```text
XmobiTea GearN/Open Settings
```

Tạo/cấu hình asset `Resources/GNServerSettings` với host, port, secret key, message type, socket/http options và log type.

## 3. Cách SDK hoạt động

Flow chuẩn:

1. Cấu hình `GNServerSettings` trong Unity Editor hoặc qua setter trước khi gọi API.
2. Truy cập `GNNetwork` lần đầu trong Play Mode; SDK tự load settings và init peer.
3. Gọi API qua `GNNetwork.*`.
4. Check response theo 2 tầng: `returnCode` trước, `errorCode` sau.
5. Nếu app cần realtime, subscribe event handler **trước** rồi mới gọi `GNNetwork.connectSocket()`.

```csharp
using System.Threading.Tasks;
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

public class GearNLoginExample : MonoBehaviour
{
    private async void Start()
    {
        var infoRequestParam = new AuthenticateModels.InfoRequestParam();
        infoRequestParam.countryCode = true;
        infoRequestParam.displayName = true;

        var requestData = new AuthenticateModels.LoginByCustomIdRequestData();
        requestData.customId = "a-custom-id-store-this-for-next-login";
        requestData.createPlayerIfNotExists = true;
        requestData.infoRequestParam = infoRequestParam;

        var response = await GNNetwork.authenticate.loginByCustomIdAsync(requestData);

        if (response.returnCode != ReturnCode.Ok)
        {
            Debug.LogError("Transport/permission error: " + response.debugMessage);
            return;
        }

        if (response.errorCode != ErrorCode.Ok)
        {
            Debug.LogError("Business error: " + response.errorCode);
            return;
        }

        Debug.Log("UserId: " + response.responseData.userId);
        Debug.Log("AuthToken: " + GNNetwork.getAuthenticateStatus().getAuthToken());
    }
}
```

## 4. Config cơ bản

`GNServerSettings` là `ScriptableObject`. SDK load asset theo path:

```text
Resources/GNServerSettings
```

Các field quan trọng:

- `serverAddress`: host/IP GearN Server, không kèm scheme.
- `serverPort`: HTTP port; set `-1` nếu reverse proxy expose default port.
- `serverSocketPort`: socket port; set `-1` nếu reverse proxy expose default port.
- `useSsl`: build URL `https`.
- `useSocket`: bật socket transport.
- `useHttp`: bật HTTP transport.
- `defaultTimeoutInSeconds`: timeout mặc định.
- `messageType`: `MessageType.Json` hoặc `MessageType.MsgPack`.
- `sendRate`, `reconnectDelay`, `pingInterval`, `pingTimeout`: transport timing.
- `secretKey`: secret key lấy từ GearN Dashboard.
- `logType`: mức log của `GNDebug`.

Có thể chỉnh runtime bằng setter khi thật sự cần:

```csharp
GNNetwork.gnServerSettings.setServerAddress("api.example.com");
GNNetwork.gnServerSettings.setServerPort(443);
GNNetwork.gnServerSettings.setUseSsl(true);
GNNetwork.gnServerSettings.setSecretKey("<secret-key>");
GNNetwork.gnServerSettings.setGameId("<game-id>");
```

Full schema: [docs/reference/CONFIG.md](/docs/reference/CONFIG.md).

## 5. Quick start: login bằng custom device id

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

public class CustomDeviceLogin : MonoBehaviour
{
    private async void Start()
    {
        var infoRequestParam = new AuthenticateModels.InfoRequestParam();
        infoRequestParam.displayName = true;
        infoRequestParam.avatar = true;
        infoRequestParam.playerDatas = true;

        var requestData = new AuthenticateModels.LoginByCustomDeviceIdRequestData();
        requestData.customDeviceId = SystemInfo.deviceUniqueIdentifier;
        requestData.createPlayerIfNotExists = true;
        requestData.infoRequestParam = infoRequestParam;

        var response = await GNNetwork.authenticate.loginByCustomDeviceIdAsync(requestData);

        if (response.returnCode != ReturnCode.Ok) throw new System.Exception(response.debugMessage);
        if (response.errorCode != ErrorCode.Ok) throw new System.Exception("Business error: " + response.errorCode);

        Debug.Log("userId: " + response.responseData.userId);
        Debug.Log("authToken: " + GNNetwork.getAuthenticateStatus().getAuthToken());
    }
}
```

## 6. Login bằng account

```csharp
var infoRequestParam = new AuthenticateModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.playerStatistics = true;

var requestData = new AuthenticateModels.LoginByAccountRequestData();
requestData.username = "player001";
requestData.password = "12345678";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);
if (response.returnCode != ReturnCode.Ok) throw new System.Exception(response.debugMessage);
if (response.errorCode != ErrorCode.Ok) throw new System.Exception("Business error: " + response.errorCode);
```

## 7. Socket

```csharp
GNNetwork.subscriberOnConnectHandler(() =>
{
    Debug.Log("socket connected: " + GNNetwork.getSocketSId());
});

GNNetwork.subscriberOnDisconnectHandler(() =>
{
    Debug.Log("socket disconnected");
});

GNNetwork.setOnEventHandler(operationEvent =>
{
    Debug.Log("eventCode: " + operationEvent.getEventCode());
    Debug.Log("parameters: " + operationEvent.getParameters()?.toString());
});

GNNetwork.connectSocket();
```

Re-auth thủ công chỉ khi socket connect trước token hoặc token vừa đổi:

```csharp
if (GNNetwork.isSocketConnected() && !string.IsNullOrEmpty(GNNetwork.getAuthenticateStatus().getAuthToken()))
{
    GNNetwork.sendRequestAuthSocket();
}
```

Realtime event handler: [docs/reference/EVENTS.md](/docs/reference/EVENTS.md).

## 8. Dashboard / admin login

`DashboardApi` public wrapper đi `RequestRole.Client`. Sau `loginByAdminAccountAsync`, backend resolve admin context từ `authToken`.

```csharp
var requestData = new DashboardModels.LoginByAdminAccountRequestData();
requestData.username = "gnadmin";
requestData.password = "123456";

var response = await GNNetwork.dashboard.loginByAdminAccountAsync(requestData);
if (response.returnCode != ReturnCode.Ok) throw new System.Exception(response.debugMessage);
if (response.errorCode != ErrorCode.Ok) throw new System.Exception("Business error: " + response.errorCode);
```

## 9. Method signature

Đa số method có 2 form:

```csharp
// Callback form:
GNNetwork.authenticate.loginByAccount(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async form:
var res = await GNNetwork.authenticate.loginByAccountAsync(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Signature đầy đủ + override params (`overrideAuthToken`, `overrideSecretKey`, `customTags`, `timeout`): [docs/RULES.md § 8](/docs/RULES.md#8-method-signature--override-params).

## 10. Response model

Typed response có 5 public field: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Pattern check 2 tầng + full table ReturnCode/ErrorCode: [docs/reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

## 11. Auth state, gameId, health check, upload

```csharp
GNNetwork.getAuthenticateStatus().getAuthToken();
GNNetwork.getAuthenticateStatus().getUserId();

GNNetwork.gnServerSettings.setGameId("your-game-id");

await GNNetwork.healthCheckAsync();
await GNNetwork.getAuthInfoAsync("some-auth-token");

var bytes = new byte[] { 1, 2, 3, 4 };
await GNNetwork.uploadFileAsync("file-001", bytes, "demo.bin", "application/octet-stream");

var url = GNNetwork.getDownloadFileUrl("download-token-from-server");
```

## 12. Custom operation

Low-level API dùng khi operation chưa expose wrapper:

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Request;
using XmobiTea.GearN.Entity.Response;

public class ExampleRequestData
{
    [StringDataMember(code = ParameterCode.Key, mustNonNull = true)]
    public string key;
}

public class ExampleResponseData
{
    [StringDataMember(code = ParameterCode.Value, isOptional = true)]
    public string? value;
}

public class ExampleRequest : CustomOperationRequest<ExampleRequestData>
{
    protected override string operationCode => OperationCode.GetCustomData;
    protected override RequestType requestType => RequestType.CharacterPlayer;
    protected override RequestRole role => RequestRole.Client;

    public ExampleRequest(ExampleRequestData requestData, int timeout = OperationRequest.defaultTimeOut)
        : base(requestData, timeout) { }
}

public class ExampleResponse : CustomOperationResponse<ExampleResponseData> { }

var requestData = new ExampleRequestData();
requestData.key = "tutorial";

var response = await GNNetwork.sendViaHttpAsync<ExampleRequest, ExampleResponse>(new ExampleRequest(requestData));
```

## 13. Platform / Unity

- Detect platform: `GNNetwork.getPlatform()`.
- Auth token/user id được cache qua `StorageService`.
- `MessageType.MsgPack` giúp payload nhỏ hơn nếu server bật msgpack.
- Socket phụ thuộc `PeerSocketVersion`/define compile trong project.

## 14. Build & publish

Build SDK qua Unity/package workflow của repo. Không dùng `npm build` cho Unity package này.

## 15. Lỗi hay gặp

Full checklist + anti-patterns: [docs/RULES.md § 10](/docs/RULES.md#10-anti-patterns--pitfalls). Return/error code table: [docs/reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

## 16. File tham khảo trong repo

- Entry public API: `Runtime/GNNetwork.cs`
- API groups: `Runtime/GNNetwork*Api.cs`
- Config asset type: `Runtime/Config/GNServerSettings.cs`
- DTO/models: `Runtime/Entity/Models/*.cs`

## 17. TL;DR

1. Tạo/cấu hình `Resources/GNServerSettings` (trên thanh menu Unity, chọn XmobiTea GearN/Open Settings).
2. Mọi call qua `GNNetwork.*`.
3. Check `returnCode` trước, `errorCode` sau.
4. Socket: login HTTP → subscribe handler → `connectSocket()`; chỉ `sendRequestAuthSocket()` khi cần re-auth thủ công.
5. Rule chi tiết → [docs/RULES.md](/docs/RULES.md).
