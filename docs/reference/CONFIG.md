# Reference: Config (`GNServerSettings`)

`GNServerSettings` là `ScriptableObject` cấu hình runtime cho GearN Unity client SDK. SDK load asset theo path:

```text
Resources/GNServerSettings
```

Tạo hoặc mở settings bằng Unity menu:

```text
XmobiTea GearN/Open Settings
```

## Ví dụ runtime setter

Ưu tiên cấu hình bằng Unity Inspector. Khi cần override runtime:

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Config;
using XmobiTea.GearN.Logger;

GNNetwork.gnServerSettings.setServerAddress("api.example.com");
GNNetwork.gnServerSettings.setServerPort(-1);
GNNetwork.gnServerSettings.setServerSocketPort(-1);
GNNetwork.gnServerSettings.setUseSsl(true);
GNNetwork.gnServerSettings.setUseSocket(true);
GNNetwork.gnServerSettings.setUseHttp(true);
GNNetwork.gnServerSettings.setDefaultTimeoutInSeconds(20);
GNNetwork.gnServerSettings.setMessageType(MessageType.MsgPack);
GNNetwork.gnServerSettings.setSendRate(20);
GNNetwork.gnServerSettings.setReconnectDelay(5000);
GNNetwork.gnServerSettings.setPingInterval(20000);
GNNetwork.gnServerSettings.setPingTimeout(20000);
GNNetwork.gnServerSettings.setSecretKey("<secret-key>");
GNNetwork.gnServerSettings.setLogType(LogType.All);

GNNetwork.gnServerSettings.setGameId("<game-id>");
```

## Rule cứng

- Unity SDK không có flow `new GNServerSettings()` + `GNNetwork.init(settings)` cho app integration thông thường.
- `GNNetwork` tự load settings asset khi được dùng trong Play Mode.
- Không commit `secretKey` có permission `admin` hoặc `server` vào production client.
- Đổi host/port sau khi socket đã connect không tự reconnect; cần `disconnectSocket()` rồi `connectSocket()` lại.

---

## Lấy `secretKey` và `gameId` ở đâu

- Cả 2 do **GearN Dashboard** cấp. Tạo game → tạo secret key → copy chuỗi vào config. Mỗi secret có permission flag riêng (xem [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)).
- Một game thường có nhiều secret theo trust boundary: 1 secret cho app client (chỉ `selfEnable`), 1 cho game server (`serverSelfEnable`), 1 cho admin tool (`adminSelfEnable`). KHÔNG dùng secret admin/server cho app client — secret sẽ bị expose.
- `gameId` phải khớp game của `secretKey`; sai cặp → `ReturnCode.SecretInvalid`.

---

## Bảng field

<!-- prettier-ignore -->
| Field | Type | Required | Default | Unit | Notes |
| --- | --- | --- | --- | --- | --- |
| `serverAddress` | `string` | yes | `"127.0.0.1"` | host | Host name hoặc IP public của GearN Server |
| `serverPort` | `int` | yes | `2202` | port | HTTP port. Set `-1` khi proxy đã expose default port trực tiếp |
| `serverSocketPort` | `int` | yes | `2901` | port | Socket port. Set `-1` khi proxy đã expose default port trực tiếp |
| `useSsl` | `bool` | yes | `false` | — | `true` để build HTTPS URL |
| `useSocket` | `bool` | yes | `true` | — | Bật socket transport và realtime feature |
| `useHttp` | `bool` | yes | `true` | — | Bật HTTP transport |
| `defaultTimeoutInSeconds` | `int` | yes | `20` | giây | Timeout mặc định cho request không override `timeout` |
| `messageType` | `MessageType` | yes | `MessageType.MsgPack` | enum | Payload format: `Json` hoặc `MsgPack` |
| `sendRate` | `int` | yes | `20` | msg/giây | Max send rate request bởi transport loop |
| `reconnectDelay` | `int` | yes | `5000` | ms | Reconnect delay của socket client |
| `pingInterval` | `float` | yes | `20000` | ms | Ping interval socket client |
| `pingTimeout` | `float` | yes | `20000` | ms | Timeout phát hiện socket stale |
| `secretKey` | `string` | yes | — | — | Auto gắn cho mọi route nếu không dùng `overrideSecretKey` |
| `gameId` | `string` | yes | — | — | Game/application id khớp với `secretKey`; dùng để chọn đúng game context trên GearN Server |
| `peerSocketVersion` | `PeerSocketVersion` | yes | `None` | enum | Chọn socket implementation nếu project bật package tương ứng |
| `httpRequestType` | `HttpRequestType` | yes | `UnityWebRequest` | enum | Chọn HTTP implementation |
| `logType` | `LogType` | yes | `LogType.All` | enum | Verbosity `GNDebug` |

---

## URL building behavior

SDK tự build base URL từ `serverAddress` + port + `useSsl`:

- `getHttpUrl()`:
  - `serverPort >= 0` → `{http|https}://{serverAddress}:{serverPort}`
  - `serverPort < 0` → `{http|https}://{serverAddress}`
- `getSocketUrl()`:
  - `serverSocketPort >= 0` → `{http|https}://{serverAddress}:{serverSocketPort}`
  - `serverSocketPort < 0` → `{http|https}://{serverAddress}`

Set `serverPort = -1` hoặc `serverSocketPort = -1` khi proxy đã terminate port 80/443.

---

## Enum liên quan

```csharp
public enum MessageType
{
    Json = 1,
    MsgPack = 2,
}
```

```csharp
public enum HttpRequestType
{
    UnityWebRequest = 0,
    HttpClientRequest = 2,
}
```

`PeerSocketVersion` có thêm variant khi project bật compile define tương ứng:

- `UNITY_USING_BEST_HTTP`
- `UNITY_USING_SOCKET_IO_UNITY`

---

## Liên kết

- Secret key và route permission: xem [RULES.md § 3](/docs/RULES.md#3-route--trust-boundary-của-caller)
- Socket auth flow: xem [RULES.md § 7](/docs/RULES.md#7-auth--socket-flow) và [EVENTS.md](/docs/reference/EVENTS.md)
- Enum value: [ENUMS.md](/docs/reference/ENUMS.md)
