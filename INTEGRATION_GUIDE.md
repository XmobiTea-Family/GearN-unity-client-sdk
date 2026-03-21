# Integration Guide

This guide shows how another Unity project should consume the GearN Unity Client SDK without reading the package source first.

## 1. Add And Configure The Package

1. Add the package to the Unity project.
2. Open `XmobiTea GearN/Open Settings`.
3. Fill `GNServerSettings` with:
   - server address
   - HTTP port
   - socket port if realtime is needed
   - SSL flag
   - message type
   - secret keys for client, server, and admin scopes

## 2. Basic Runtime Usage

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Entity.Models;

public class GearNBootstrap : UnityEngine.MonoBehaviour
{
    private async void Start()
    {
        await GNNetwork.syncTsAsync();

        var loginResponse = await GNNetwork.authenticate.loginByCustomIdAsync(new AuthenticateModels.LoginByCustomIdRequestData
        {
            customId = SystemInfo.deviceUniqueIdentifier,
            createAccount = true,
        });

        if (loginResponse.hasError())
        {
            UnityEngine.Debug.LogError(loginResponse.getDebugMessage());
            return;
        }

        GNNetwork.setGameId("your-game-id");

        var infoResponse = await GNNetwork.gamePlayer.getPlayerInformationAsync(new GamePlayerModels.GetPlayerInformationRequestData());
        UnityEngine.Debug.Log(infoResponse.getDebugMessage());
    }
}
```

## 3. Using Roles Correctly

- default root API methods use the `Client` scope
- `.server` methods use the `Server` scope
- `.admin` methods use the `Admin` scope

Examples:

- `GNNetwork.gamePlayer.getPlayerInformation(...)`
- `GNNetwork.gamePlayer.server.getPlayerInformation(...)`
- `GNNetwork.dashboard.getGameList(...)`

The SDK automatically chooses the matching secret key from `GNServerSettings` unless you pass `overrideSecretKey`.

## 4. Socket Usage

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Networking;

public class GearNSocketBootstrap : UnityEngine.MonoBehaviour
{
    private void Start()
    {
        GNNetwork.setOnEventHandler(operationEvent =>
        {
            UnityEngine.Debug.Log(operationEvent.toString());
        });

        GNNetwork.subscriberOnConnectHandler(() => UnityEngine.Debug.Log("Socket connected"));
        GNNetwork.subscriberOnDisconnectHandler(() => UnityEngine.Debug.Log("Socket disconnected"));

        GNNetwork.connectSocket(() =>
        {
            GNNetwork.sendRequestAuthSocket();
        });
    }
}
```

## 5. Persistence Behavior

The SDK persists:

- auth token
- user ID
- game ID

If you want to replace the current auth state manually, use:

- `GNNetwork.setNewAuthenticateStatus(...)`
- `GNNetwork.setGameId(...)`

## 6. When To Use Raw Transport

Use the high-level domain APIs first.

Use raw `GNNetwork.sendViaHttp(...)` or `GNNetwork.sendViaSocket(...)` only when:

- the package does not expose a typed wrapper yet
- you are building a custom operation path
- you need transport-level experimentation

## 7. Where To Look For Operation Names

- `API_MAP.md`
- `Runtime/GNNetwork*Api.cs`
- `Runtime/Entity/Models/*RequestModels.cs`
- `Runtime/Entity/Models/*Models.cs`