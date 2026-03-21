# AGENTS

This file tells an AI agent how to work inside this Unity package without re-exploring the codebase from scratch.

## Read These Files First

1. `Runtime/GNNetwork.cs`
2. `Runtime/Networking/NetworkingPeer.cs`
3. `Runtime/Networking/Http/HttpPeer.cs`
4. `Runtime/Networking/Socket/SocketPeer.cs`
5. `Runtime/Config/GNServerSettings.cs`
6. `API_MAP.md`
7. `REQUEST_FLOW.md`
8. `DOMAIN_RELATIONSHIP.md`

## Repository Boundaries

- SDK runtime source lives in `Runtime/`
- Unity editor tooling for the package lives in `Editor/`
- Ignore all `.meta` files unless the task is explicitly about Unity asset metadata
- There is no third-party package cache or build output checked into this repository

## What This Package Is

- A Unity client SDK for the GearN server
- A facade package that hides HTTP and socket transport details behind `GNNetwork`
- A strongly-typed wrapper over GearN request types, operation codes, request roles, and DTOs

## What This Package Is Not

- Not a gameplay sample project
- Not a server implementation
- Not a standalone app with scenes, gameplay state, or content assets

## Public Contract Rules

- `Runtime/GNNetwork.cs` is the public entry point that other Unity projects are expected to call
- `GNNetwork` persists auth token, user ID, and game ID in `PlayerPrefs`
- HTTP is the default request path for almost every typed domain operation
- Socket is mainly for realtime events and optional raw transport use
- Request role controls which secret key is used when no override is provided:
  - `Client` -> `clientSecretKey`
  - `Server` -> `serverSecretKey`
  - `Admin` -> `adminSecretKey`
- Domain APIs map directly to server `RequestType` values:
  - `Authenticate`
  - `CharacterPlayer`
  - `Content`
  - `Dashboard`
  - `GamePlayer`
  - `Group`
  - `Inventory`
  - `MasterPlayer`
  - `StoreInventory`
  - `Multiplayer`
  - `CloudScript`

## Important Runtime Facts

- `GNServerSettings` is loaded from Unity `Resources`
- `GNNetwork` static initialization only finishes the full runtime setup when `Application.isPlaying` is true
- `ServiceUpdate` is created automatically and marked as `DontDestroyOnLoad`
- Socket event handlers are auto-discovered from `IServerEventHandler` implementations
- Extra server event handlers can also be registered manually with `GNNetwork.subscriberServerEventHandler(...)`

## When Editing

- Preserve the public method names in `GNNetwork*Api.cs` unless the task explicitly changes the SDK contract
- Keep request wrappers aligned with `OperationCode`, `RequestType`, and `RequestRole`
- If a change affects a domain API, update the matching DTO files under `Runtime/Entity/Models/`
- If a change affects transport, check both `NetworkingPeer`, `HttpPeer`, and `SocketPeer`
- If a change affects configuration, check both `GNServerSettings` and `GNServerSettingsEditor`

## High-Risk Areas

- `Runtime/Networking/Socket/`: compile-symbol-dependent implementations
- `Runtime/Networking/Http/`: behavior differs by HTTP backend selection
- `Runtime/Entity/Models/`: request and response DTO compatibility with the server contract
- `Runtime/Helper/ConverterService.cs` and `Runtime/Helper/ParseGNHelper.cs`: serialization and parsing glue

## Unity Define Symbols

- `UNITY_USING_BEST_HTTP`
- `UNITY_USING_SOCKET_IO_UNITY`

Those defines change which socket and HTTP implementations are available at compile time.