# Request Flow

> Maintainer-only flow note. Package consumer thường **không cần** đọc file này để gọi SDK đúng; dùng [docs/START_HERE.md](/docs/START_HERE.md), [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), và [docs/RULES.md](/docs/RULES.md) trước.

## Typed HTTP Operation Flow

1. A Unity project calls a facade method such as `GNNetwork.gamePlayer.getPlayerInformation(...)`.
2. The domain API creates a typed request wrapper from `*RequestModels.cs`.
3. `GNNetwork` forwards the request to `NetworkingPeer`.
4. `NetworkingPeer` injects auth token and secret key if the caller did not override them.
5. `HttpPeer` converts the request into:
   - request type
   - request role
   - operation code
   - serialized parameter payload
6. `HttpPeer` selects JSON or MsgPack based on `GNServerSettings.messageType`.
7. The configured HTTP backend sends the request.
8. `HttpPeer` parses the response into `GNHashtable`.
9. `PeerBase.onResponseHandler(...)` creates `OperationResponse`.
10. Typed async and callback wrappers convert `OperationResponse` into the requested `CustomOperationResponse` type.

## Raw Socket Flow

1. A caller enables socket usage in `GNServerSettings`.
2. `GNNetwork.connectSocket()` delegates to `SocketPeer`.
3. `SocketPeer` uses the configured socket backend implementation.
4. Requests can be sent through raw socket helpers in `GNNetwork`.
5. Server events are delivered as `OperationEvent`.
6. `SocketPeer` forwards events to:
   - the callback registered by `GNNetwork.setOnEventHandler(...)`
   - auto-discovered `IServerEventHandler` implementations
   - manually registered handlers from `GNNetwork.subscriberServerEventHandler(...)`

## Auth And Response Side Effects

When a response has no SDK-level error, `PeerBase` also refreshes shared runtime state when these parameters exist:

- `AuthToken`
- `UserId`
- `Ts`

That means a successful response can update:

- `GNNetwork.getAuthenticateStatus()`
- persisted `PlayerPrefs` auth token
- persisted `PlayerPrefs` user ID
- client-side server timestamp offset

## File Upload Flow

1. Caller provides `fileId`, bytes, filename, and MIME type.
2. `GNNetwork.uploadFile(...)` delegates to `NetworkingPeerAPI.uploadFile(...)`.
3. `HttpPeer` verifies the current auth token exists.
4. The selected HTTP backend posts the file to `upload/{fileId}`.
5. The callback receives `UploadFileResponse`.

## Health And Auth Helper Flow

The helper endpoints do not use the normal typed operation wrapper path:

- `syncTs`
- `getAuthInfo`
- `healthCheck`
- `uploadFile`
- `getDownloadFileUrl`

These are implemented in `Runtime/GNNetworkApi.cs` and `Runtime/Networking/NetworkingPeerAPI.cs`.
