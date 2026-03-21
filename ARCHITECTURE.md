# Architecture Overview

## Layer Map

1. `GNNetwork`
2. `NetworkingPeer`
3. `HttpPeer` and `SocketPeer`
4. request wrappers in `Runtime/Entity/Models/*RequestModels.cs`
5. payload DTOs in `Runtime/Entity/Models/*Models.cs`
6. typed responses in `Runtime/Entity/Models/*ResponseModels.cs`

`GNNetwork` is the stable facade. Everything else exists to convert Unity-side method calls into GearN transport messages and back into typed response objects.

## Initialization Flow

1. `GNNetwork` static constructor loads `GNServerSettings` from `Resources`.
2. `GNNetwork` applies logging settings through `GNDebug`.
3. During play mode, `GNNetwork` creates a `NetworkingPeer`.
4. `NetworkingPeer` creates and initializes `HttpPeer` and `SocketPeer`.
5. `GNNetwork` creates `[GN] ServiceUpdate`, marks it `DontDestroyOnLoad`, and uses it to call `peer.service()`.
6. Stored auth token, user ID, and game ID are restored from `PlayerPrefs`.
7. Domain API singletons are created and exposed through `GNNetwork`.

## Runtime Modules

### `Runtime/GNNetwork*.cs`

- public facade methods
- domain-specific API wrappers
- convenience async wrappers around callback-based transport methods

### `Runtime/Networking/`

- request queueing
- request timeout tracking
- ping tracking
- HTTP and socket dispatch
- socket event fan-out
- auth token and server timestamp refresh from responses

### `Runtime/Entity/`

- raw operation request and response types
- typed DTOs for every public operation
- serializer metadata through `*DataMember` attributes

### `Runtime/Helper/`

- serialization glue
- parser utilities
- dictionary conversion helpers
- `PlayerPrefs` persistence wrappers

### `Runtime/Config/`

- `GNServerSettings`
- transport settings
- role secret keys
- logging and backend-selection settings

### `Editor/`

- custom inspector for `GNServerSettings`
- Unity menu entries for creating the settings asset and opening external docs

## Transport Model

### HTTP

- Default path for almost all typed domain API methods
- URI pattern:
  - `api/json/{requestType}/{role}/{operationCode}`
  - `api/msgpack/{requestType}/{role}/{operationCode}`
- Additional helper endpoints:
  - `ts`
  - `getAuthInfo`
  - `healthcheck`
  - `upload/{fileId}`
  - `download/...`

### Socket

- Optional and disabled unless enabled in `GNServerSettings`
- Mainly used for realtime events and raw request transport
- Supports multiple backends depending on compile symbols and socket version settings
- Auto-discovers `IServerEventHandler` implementations at runtime

## Auth And State Persistence

- auth token is stored under `[GN]_AUTH_TOKEN_KEY`
- user ID is stored under `[GN]_USER_ID_KEY`
- game ID is stored under `[GN]_GAME_ID_KEY`
- successful responses can refresh auth token, user ID, and server timestamp

## Domain API Shape

Each domain API follows the same pattern:

- root API for client-scoped operations
- `.server` nested API for server-scoped operations
- `.admin` nested API for admin-scoped operations
- callback-based method
- async wrapper returning `Task<TResponse>`

This shape is deliberate and mirrors server request roles instead of hiding them.