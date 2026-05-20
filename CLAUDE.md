# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What This Repository Is

Unity package (`com.xmobitea.changx.gearn-unity-client-sdk`, Unity 2020.3+) that provides a typed client SDK for the GearN backend. The SDK is a pure runtime library — there are no automated tests and no build CLI. All validation is done by opening a Unity project that references this package.

If the task is **package consumption / integration**, start from [docs/START_HERE.md](docs/START_HERE.md), [docs/AI_CHEATSHEET.md](docs/AI_CHEATSHEET.md), and [docs/RULES.md](docs/RULES.md) before reading `Runtime/`.

## Local Workflow

1. Reference this package from a Unity project (local path or git URL).
2. Ensure `Resources/GNServerSettings.asset` exists — create it via **XmobiTea GearN → Open Settings**.
3. Configure server address, ports, SSL, message type (`JSON` or `MsgPack`), `secretKey`, and `gameId` as needed.
4. Enter Play Mode; use `GNDebug` console output to inspect request/response flow.

No build, lint, or test commands exist in this repo. Validation requires a live Unity project.

## Transport Backend Compile Symbols

Socket support is behind conditional compilation:

- `UNITY_USING_BEST_HTTP` — BestHTTP/2 socket backend
- `UNITY_USING_SOCKET_IO_UNITY` — Socket.IO for Unity backend

HTTP backend is selected via `GNServerSettings.httpRequestType`. Socket backend via `GNServerSettings.peerSocketVersion`.

## Architecture

See [ARCHITECTURE.md](ARCHITECTURE.md) for the full layer map and initialization flow. Short version:

```
GNNetwork  (static facade, partial class split across GNNetwork*.cs)
  └── NetworkingPeer  (request queue, timeout, ping, auth injection)
        ├── HttpPeer  (UnityWebRequest or HttpClient backend)
        └── SocketPeer  (Socket.IO or BestHTTP backend)
```

`GNNetwork` is the only stable public surface. Everything below it is internal wiring.

## Domain APIs

`GNNetwork` exposes one property per server domain:

| Property | Domain |
|---|---|
| `GNNetwork.authenticate` | Login, registration, token |
| `GNNetwork.masterPlayer` | Global account identity |
| `GNNetwork.gamePlayer` | Per-game gameplay profile |
| `GNNetwork.characterPlayer` | Character-scoped state |
| `GNNetwork.group` | Groups and membership |
| `GNNetwork.inventory` | Item ownership |
| `GNNetwork.content` | File and content ops |
| `GNNetwork.storeInventory` | Purchases and store catalog |
| `GNNetwork.dashboard` | Admin / control plane |
| `GNNetwork.multiplayer` | Matchmaking |
| `GNNetwork.cloudScript` | Versioned script execution |

Each domain API has three scopes: root (client), `.server`, `.admin`. Each method has a callback form and an `Async` Task wrapper.

Route selection follows caller trust boundary, not target ownership. Canonical explanation lives in [docs/RULES.md](docs/RULES.md).

See [DOMAIN_RELATIONSHIP.md](DOMAIN_RELATIONSHIP.md) for the dependency graph between domains.

## Request Flow

See [REQUEST_FLOW.md](REQUEST_FLOW.md) for full detail. Short version:

1. Caller → `GNNetwork.<domain>.<method>(requestData)` or `…Async()`
2. Domain API builds a typed request wrapper from `Runtime/Entity/Models/*RequestModels.cs`
3. `NetworkingPeer` injects auth token + secret key
4. `HttpPeer` serializes to JSON or MsgPack and POSTs to `api/{format}/{requestType}/{role}/{operationCode}`
5. Response is parsed into `GNHashtable` → `OperationResponse` → typed `CustomOperationResponse`
6. Successful responses automatically refresh `AuthToken`, `UserId`, and server timestamp via `PeerBase`

## Key Files

| Task | Files |
|---|---|
| Add or change a domain API method | `Runtime/GNNetwork<Domain>Api.cs`, `Runtime/Entity/Models/<Domain>Models.cs` |
| Change transport or serialization | `Runtime/Networking/Http/HttpPeer.cs`, `Runtime/Networking/PeerBase.cs` |
| Change persistence | `Runtime/GNNetwork.cs`, `Runtime/Networking/NetworkingPeer.cs`, `Runtime/Helper/StorageService.cs` |
| Change settings schema | `Runtime/Config/GNServerSettings.cs`, `Editor/GNServerSettingsEditor.cs` |
| Socket event handlers | `Runtime/Networking/Handler/IServerEventHandler.cs` and sibling files |

## Maintenance Rules

- Keep typed request wrappers aligned with server operation codes (`Runtime/Constant/OperationCode.cs`, `Runtime/Constant/ParameterCode/ParameterCode.cs`).
- If you change public API shape, update `docs/reference/API_INDEX.md`, `REQUEST_FLOW.md`, and `INTEGRATION_GUIDE.md`.
- When changing persistence behavior, inspect `GNNetwork.cs`, `NetworkingPeer.cs`, and `StorageService.cs` together.
- `.meta` files exist because this is a Unity package; they are not behavior-defining and should not be edited manually.
