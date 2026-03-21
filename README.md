# GearN Unity Client SDK

GearN Unity Client SDK is a Unity package that exposes the public GearN transport and domain APIs for gameplay clients, server-side Unity tools, and admin tooling built inside Unity.

## Repository Role

This repository contains:

- the runtime package consumed by Unity projects through `Runtime/`
- the editor tooling that creates and edits `GNServerSettings` through `Editor/`
- the public SDK facade entry point in `Runtime/GNNetwork.cs`

## Main Entry Points

- Runtime facade: `Runtime/GNNetwork.cs`
- Runtime transport coordinator: `Runtime/Networking/NetworkingPeer.cs`
- HTTP transport: `Runtime/Networking/Http/HttpPeer.cs`
- Socket transport: `Runtime/Networking/Socket/SocketPeer.cs`
- Settings asset: `Runtime/Config/GNServerSettings.cs`
- Unity editor settings inspector: `Editor/GNServerSettingsEditor.cs`

## Quick Start

1. Add the package to a Unity project.
2. Open `XmobiTea GearN/Open Settings` to create `Resources/GNServerSettings.asset` if it does not exist yet.
3. Fill the server address, ports, transport flags, and secret keys in the settings asset.
4. Call `GNNetwork.syncTs`, `GNNetwork.authenticate.*`, or another domain API from gameplay code.
5. If you need realtime events, enable socket support in the settings asset and call `GNNetwork.connectSocket()`.

## Public API Shape

- `GNNetwork.authenticate`
- `GNNetwork.characterPlayer`
- `GNNetwork.content`
- `GNNetwork.dashboard`
- `GNNetwork.gamePlayer`
- `GNNetwork.group`
- `GNNetwork.inventory`
- `GNNetwork.masterPlayer`
- `GNNetwork.storeInventory`
- `GNNetwork.multiplayer`
- `GNNetwork.cloudScript`

Most domain methods send requests through HTTP. Socket support is mainly for realtime events plus raw request transport when needed.

## Docs For AI

- `AGENTS.md`: editing and usage rules for AI agents
- `ARCHITECTURE.md`: runtime layers, initialization flow, and module boundaries
- `DEVELOPMENT.md`: local workflow, Unity defines, and maintenance caveats
- `DOMAIN_RELATIONSHIP.md`: domain relationship map from the client SDK point of view
- `API_MAP.md`: operation map per domain and request scope
- `REQUEST_FLOW.md`: end-to-end request and response flow through the SDK
- `INTEGRATION_GUIDE.md`: practical usage guide for consuming the SDK inside another Unity project