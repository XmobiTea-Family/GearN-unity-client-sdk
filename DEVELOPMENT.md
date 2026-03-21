# Development Notes

## Repository Layout

- `Runtime/`: package runtime source
- `Editor/`: Unity editor source
- `package.json`: Unity package manifest

## Local Workflow

1. Open a Unity project that references this package.
2. Ensure `Resources/GNServerSettings.asset` exists.
3. Configure server address, ports, transport flags, and secret keys.
4. Play the Unity project and use `GNDebug` output to inspect request flow.

## Important Unity Constraints

- This package assumes Unity runtime availability for `Application`, `Resources`, `PlayerPrefs`, and `GameObject`
- Full runtime initialization only happens during play mode
- Editor code must stay inside `Editor/`

## Transport Backend Constraints

Socket support depends on compile symbols:

- `UNITY_USING_BEST_HTTP`
- `UNITY_USING_SOCKET_IO_UNITY`

HTTP backend selection is controlled by `GNServerSettings.httpRequestType`.

Socket backend selection is controlled by `GNServerSettings.peerSocketVersion`.

## Maintenance Rules

- Keep typed request wrappers aligned with server operation codes
- Keep DTO field names aligned with server parameter codes
- If you change public API shape, update `API_MAP.md`, `REQUEST_FLOW.md`, and `INTEGRATION_GUIDE.md`
- When changing persistence behavior, inspect `GNNetwork.cs`, `NetworkingPeer.cs`, and `StorageService.cs` together

## Known Characteristics

- There is no `.editorconfig` in this repository
- `.meta` files exist because this is a Unity package, but they are not the main source of truth for SDK behavior
- The package already contains multiple transport backends behind conditional compilation
- There are no standalone automated tests in this repository