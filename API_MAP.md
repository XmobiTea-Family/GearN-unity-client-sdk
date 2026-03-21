# API Map

This file lists the typed operation surface exposed by the GearN Unity Client SDK.

## Authenticate

Request type: `Authenticate`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `loginByAccount` | Yes | No | No |
| `loginByAndroidDeviceId` | Yes | No | No |
| `loginByApple` | Yes | No | No |
| `loginByCustomDeviceId` | Yes | No | No |
| `loginByCustomId` | Yes | No | No |
| `loginByEditorDeviceId` | Yes | No | No |
| `loginByFacebook` | Yes | No | No |
| `loginByGameCenter` | Yes | No | No |
| `loginByGenericService` | Yes | No | No |
| `loginByGoogle` | Yes | No | No |
| `loginByGooglePlayGameService` | Yes | No | No |
| `loginByLinuxDeviceId` | Yes | No | No |
| `loginByMacOSDeviceId` | Yes | No | No |
| `loginByWindowsDeviceId` | Yes | No | No |
| `loginByWindowsPhoneDeviceId` | Yes | No | No |
| `loginByiOSDeviceId` | Yes | No | No |
| `refreshAuthToken` | Yes | No | No |
| `registerAccount` | Yes | No | No |

## Character Player

Request type: `CharacterPlayer`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addPlayerFriend` | Yes | Yes | Yes |
| `addSegment` | Yes | Yes | Yes |
| `changePlayerCurrency` | Yes | Yes | Yes |
| `changePlayerStatistics` | Yes | Yes | Yes |
| `createGroup` | Yes | Yes | Yes |
| `createPlayerItem` | Yes | Yes | Yes |
| `getAvatar` | Yes | Yes | Yes |
| `getCatalogId` | Yes | Yes | Yes |
| `getCountryCode` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLog` | Yes | Yes | Yes |
| `getCustomData` | Yes | Yes | Yes |
| `getDisplayName` | Yes | Yes | Yes |
| `getFriendStatisticsLeaderboard` | Yes | Yes | Yes |
| `getFriendStatisticsLeaderboardAroundPlayer` | Yes | Yes | Yes |
| `getIpAddressCreate` | Yes | Yes | Yes |
| `getLastLoginLeaderboard` | Yes | Yes | Yes |
| `getOwner` | Yes | Yes | Yes |
| `getPlayerBan` | Yes | Yes | Yes |
| `getPlayerCurrency` | Yes | Yes | Yes |
| `getPlayerData` | Yes | Yes | Yes |
| `getPlayerFriend` | Yes | Yes | Yes |
| `getPlayerGroup` | Yes | Yes | Yes |
| `getPlayerInformation` | Yes | Yes | Yes |
| `getPlayerInventory` | Yes | Yes | Yes |
| `getPlayerStatistics` | Yes | Yes | Yes |
| `getPlayersWithDisplayName` | Yes | Yes | Yes |
| `getPlayersWithSegment` | Yes | Yes | Yes |
| `getPlayersWithTag` | Yes | Yes | Yes |
| `getRemoveStatus` | Yes | Yes | Yes |
| `getSegment` | Yes | Yes | Yes |
| `getStatisticsLeaderboard` | Yes | Yes | Yes |
| `getStatisticsLeaderboardAroundPlayer` | Yes | Yes | Yes |
| `getStatisticsLog` | Yes | Yes | Yes |
| `getTag` | Yes | Yes | Yes |
| `getTsCreate` | Yes | Yes | Yes |
| `getTsLastLogin` | Yes | Yes | Yes |
| `joinGroup` | Yes | Yes | Yes |
| `leaveGroup` | Yes | Yes | Yes |
| `removePlayerFriend` | Yes | Yes | Yes |
| `removePlayerItem` | Yes | Yes | Yes |
| `removeSegment` | Yes | Yes | Yes |
| `removeTag` | Yes | Yes | Yes |
| `setAvatar` | Yes | Yes | Yes |
| `setCountryCode` | Yes | Yes | Yes |
| `setCustomData` | Yes | Yes | Yes |
| `setDisplayName` | Yes | Yes | Yes |
| `setOwner` | Yes | Yes | Yes |
| `setPlayerBan` | Yes | Yes | Yes |
| `setPlayerData` | Yes | Yes | Yes |
| `setRemoveStatus` | Yes | Yes | Yes |
| `setTag` | Yes | Yes | Yes |

## Cloud Script

Request type: `CloudScript`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addFunction` | Yes | Yes | Yes |
| `editFunction` | Yes | Yes | Yes |
| `executeFunction` | Yes | Yes | Yes |
| `getFunction` | Yes | Yes | Yes |
| `getFunctions` | Yes | Yes | Yes |

## Content

Request type: `Content`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `createNewFileUploadInfo` | Yes | Yes | Yes |
| `getContentData` | Yes | Yes | Yes |
| `getFileUploadInfo` | Yes | Yes | Yes |
| `getFileUploadInfoList` | Yes | Yes | Yes |
| `removeFileUploadInfo` | Yes | Yes | Yes |
| `requestDownloadFileUploadInfo` | Yes | Yes | Yes |
| `setContentData` | Yes | Yes | Yes |

## Dashboard

Request type: `Dashboard`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `changePasswordAdminAccount` | Yes | No | No |
| `createAdminAccount` | Yes | No | No |
| `createGame` | Yes | No | No |
| `createSecretInfo` | Yes | No | No |
| `deleteInDatabase` | Yes | No | No |
| `getAdminAccountList` | Yes | No | No |
| `getAnalytics` | Yes | No | No |
| `getBackupStatisticsLeaderboardVersion` | Yes | No | No |
| `getEventCallbackCloudScript` | Yes | No | No |
| `getGameInformation` | Yes | No | No |
| `getGameList` | Yes | No | No |
| `getMasterGameSettings` | Yes | No | No |
| `getSecretInfoInformation` | Yes | No | No |
| `getSecretInfoList` | Yes | No | No |
| `getServerGameData` | Yes | No | No |
| `getServerLog` | Yes | No | No |
| `getUsernameAdminAccount` | Yes | No | No |
| `loginByAdminAccount` | Yes | No | No |
| `removeAdminAccount` | Yes | No | No |
| `resetStatisticsLeaderboard` | Yes | No | No |
| `setEventCallbackCloudScript` | Yes | No | No |
| `setGameInformation` | Yes | No | No |
| `setMasterGameSettings` | Yes | No | No |
| `setPasswordAdminAccount` | Yes | No | No |
| `setSecretInfoInformation` | Yes | No | No |
| `setSecretKeyAdminAccount` | Yes | No | No |

## Game Player

Request type: `GamePlayer`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addPlayerFriend` | Yes | Yes | Yes |
| `addSegment` | Yes | Yes | Yes |
| `changePlayerCurrency` | Yes | Yes | Yes |
| `changePlayerStatistics` | Yes | Yes | Yes |
| `createGroup` | Yes | Yes | Yes |
| `createPlayerCharacter` | Yes | Yes | Yes |
| `createPlayerItem` | Yes | Yes | Yes |
| `getAvatar` | Yes | Yes | Yes |
| `getCountryCode` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLog` | Yes | Yes | Yes |
| `getCustomData` | Yes | Yes | Yes |
| `getDisplayName` | Yes | Yes | Yes |
| `getFriendStatisticsLeaderboard` | Yes | Yes | Yes |
| `getFriendStatisticsLeaderboardAroundPlayer` | Yes | Yes | Yes |
| `getIpAddressCreate` | Yes | Yes | Yes |
| `getOnlineStatus` | Yes | Yes | Yes |
| `getPlayerBan` | Yes | Yes | Yes |
| `getPlayerCharacter` | Yes | Yes | Yes |
| `getPlayerCurrency` | Yes | Yes | Yes |
| `getPlayerData` | Yes | Yes | Yes |
| `getPlayerFriend` | Yes | Yes | Yes |
| `getPlayerGroup` | Yes | Yes | Yes |
| `getPlayerInformation` | Yes | Yes | Yes |
| `getPlayerInventory` | Yes | Yes | Yes |
| `getPlayerStatistics` | Yes | Yes | Yes |
| `getPlayersWithDisplayName` | Yes | Yes | Yes |
| `getPlayersWithSegment` | Yes | Yes | Yes |
| `getPlayersWithTag` | Yes | Yes | Yes |
| `getSegment` | Yes | Yes | Yes |
| `getStatisticsLeaderboard` | Yes | Yes | Yes |
| `getStatisticsLeaderboardAroundPlayer` | Yes | Yes | Yes |
| `getStatisticsLog` | Yes | Yes | Yes |
| `getTag` | Yes | Yes | Yes |
| `getTsCreate` | Yes | Yes | Yes |
| `getTsLastLogin` | Yes | Yes | Yes |
| `joinGroup` | Yes | Yes | Yes |
| `leaveGroup` | Yes | Yes | Yes |
| `removePlayerCharacter` | Yes | Yes | Yes |
| `removePlayerFriend` | Yes | Yes | Yes |
| `removePlayerItem` | Yes | Yes | Yes |
| `removeSegment` | Yes | Yes | Yes |
| `removeTag` | Yes | Yes | Yes |
| `setAvatar` | Yes | Yes | Yes |
| `setCountryCode` | Yes | Yes | Yes |
| `setCustomData` | Yes | Yes | Yes |
| `setDisplayName` | Yes | Yes | Yes |
| `setPlayerBan` | Yes | Yes | Yes |
| `setPlayerData` | Yes | Yes | Yes |
| `setTag` | Yes | Yes | Yes |

## Group

Request type: `Group`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addMember` | Yes | Yes | Yes |
| `addSegment` | Yes | Yes | Yes |
| `changeGroupCurrency` | Yes | Yes | Yes |
| `changeGroupStatistics` | Yes | Yes | Yes |
| `createGroupItem` | Yes | Yes | Yes |
| `getAvatar` | Yes | Yes | Yes |
| `getCatalogId` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLog` | Yes | Yes | Yes |
| `getCustomData` | Yes | Yes | Yes |
| `getDisplayName` | Yes | Yes | Yes |
| `getGroupCurrency` | Yes | Yes | Yes |
| `getGroupData` | Yes | Yes | Yes |
| `getGroupInformation` | Yes | Yes | Yes |
| `getGroupInventory` | Yes | Yes | Yes |
| `getGroupMessage` | Yes | Yes | Yes |
| `getGroupStatistics` | Yes | Yes | Yes |
| `getGroupsWithDisplayName` | Yes | Yes | Yes |
| `getGroupsWithSegment` | Yes | Yes | Yes |
| `getGroupsWithTag` | Yes | Yes | Yes |
| `getMembers` | Yes | Yes | Yes |
| `getRemoveStatus` | Yes | Yes | Yes |
| `getSegment` | Yes | Yes | Yes |
| `getStatisticsLeaderboard` | Yes | Yes | Yes |
| `getStatisticsLeaderboardAroundGroup` | Yes | Yes | Yes |
| `getStatisticsLog` | Yes | Yes | Yes |
| `getTag` | Yes | Yes | Yes |
| `getTsCreate` | Yes | Yes | Yes |
| `removeGroupItem` | Yes | Yes | Yes |
| `removeMember` | Yes | Yes | Yes |
| `removeSegment` | Yes | Yes | Yes |
| `removeTag` | Yes | Yes | Yes |
| `sendGroupMessage` | Yes | Yes | Yes |
| `setAvatar` | Yes | Yes | Yes |
| `setCustomData` | Yes | Yes | Yes |
| `setDisplayName` | Yes | Yes | Yes |
| `setGroupData` | Yes | Yes | Yes |
| `setRemoveStatus` | Yes | Yes | Yes |
| `setTag` | Yes | Yes | Yes |

## Inventory

Request type: `Inventory`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addSegment` | Yes | Yes | Yes |
| `changeItemStatistics` | Yes | Yes | Yes |
| `getAmount` | Yes | Yes | Yes |
| `getAvatar` | Yes | Yes | Yes |
| `getCatalogId` | Yes | Yes | Yes |
| `getClassId` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getCustomData` | Yes | Yes | Yes |
| `getDisplayName` | Yes | Yes | Yes |
| `getItemData` | Yes | Yes | Yes |
| `getItemInformation` | Yes | Yes | Yes |
| `getItemStatistics` | Yes | Yes | Yes |
| `getItemType` | Yes | Yes | Yes |
| `getItemsWithDisplayName` | Yes | Yes | Yes |
| `getItemsWithSegment` | Yes | Yes | Yes |
| `getItemsWithTag` | Yes | Yes | Yes |
| `getOwner` | Yes | Yes | Yes |
| `getRemoveStatus` | Yes | Yes | Yes |
| `getSegment` | Yes | Yes | Yes |
| `getStatisticsLeaderboard` | Yes | Yes | Yes |
| `getStatisticsLeaderboardAroundItem` | Yes | Yes | Yes |
| `getStatisticsLog` | Yes | Yes | Yes |
| `getTag` | Yes | Yes | Yes |
| `getTsCreate` | Yes | Yes | Yes |
| `removeSegment` | Yes | Yes | Yes |
| `removeTag` | Yes | Yes | Yes |
| `setAmount` | Yes | Yes | Yes |
| `setAvatar` | Yes | Yes | Yes |
| `setCustomData` | Yes | Yes | Yes |
| `setDisplayName` | Yes | Yes | Yes |
| `setItemData` | Yes | Yes | Yes |
| `setOwner` | Yes | Yes | Yes |
| `setRemoveStatus` | Yes | Yes | Yes |
| `setTag` | Yes | Yes | Yes |

## Master Player

Request type: `MasterPlayer`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `addPushNotification` | Yes | Yes | Yes |
| `addSegment` | Yes | Yes | Yes |
| `changeAccountPassword` | Yes | No | No |
| `changePlayerCurrency` | Yes | Yes | Yes |
| `changePlayerStatistics` | Yes | Yes | Yes |
| `getAvatar` | Yes | Yes | Yes |
| `getCountryCode` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLeaderboard` | Yes | Yes | Yes |
| `getCurrencyLog` | Yes | Yes | Yes |
| `getCustomData` | Yes | Yes | Yes |
| `getDisplayName` | Yes | Yes | Yes |
| `getEmail` | Yes | Yes | Yes |
| `getExternal` | Yes | Yes | Yes |
| `getIpAddressCreate` | Yes | Yes | Yes |
| `getLastLoginLeaderboard` | Yes | Yes | Yes |
| `getPlayerBan` | Yes | Yes | Yes |
| `getPlayerCurrency` | Yes | Yes | Yes |
| `getPlayerData` | Yes | Yes | Yes |
| `getPlayerInformation` | Yes | Yes | Yes |
| `getPlayerStatistics` | Yes | Yes | Yes |
| `getPlayersWithApple` | Yes | Yes | Yes |
| `getPlayersWithDisplayName` | Yes | Yes | Yes |
| `getPlayersWithFacebook` | Yes | Yes | Yes |
| `getPlayersWithGameCenter` | Yes | Yes | Yes |
| `getPlayersWithGenericService` | Yes | Yes | Yes |
| `getPlayersWithGoogle` | Yes | Yes | Yes |
| `getPlayersWithGooglePlayGameService` | Yes | Yes | Yes |
| `getPlayersWithSegment` | Yes | Yes | Yes |
| `getPlayersWithTag` | Yes | Yes | Yes |
| `getPushNotification` | Yes | Yes | Yes |
| `getSegment` | Yes | Yes | Yes |
| `getStatisticsLeaderboard` | Yes | Yes | Yes |
| `getStatisticsLeaderboardAroundPlayer` | Yes | Yes | Yes |
| `getStatisticsLog` | Yes | Yes | Yes |
| `getTag` | Yes | Yes | Yes |
| `getTsCreate` | Yes | Yes | Yes |
| `getTsLastLogin` | Yes | Yes | Yes |
| `linkAccount` | Yes | Yes | Yes |
| `linkAndroidDeviceId` | Yes | Yes | Yes |
| `linkApple` | Yes | Yes | Yes |
| `linkCustomDeviceId` | Yes | Yes | Yes |
| `linkCustomId` | Yes | Yes | Yes |
| `linkEditorDeviceId` | Yes | Yes | Yes |
| `linkFacebook` | Yes | Yes | Yes |
| `linkGameCenter` | Yes | Yes | Yes |
| `linkGenericService` | Yes | Yes | Yes |
| `linkGoogle` | Yes | Yes | Yes |
| `linkGooglePlayGameService` | Yes | Yes | Yes |
| `linkLinuxDeviceId` | Yes | Yes | Yes |
| `linkMacOSDeviceId` | Yes | Yes | Yes |
| `linkWindowsDeviceId` | Yes | Yes | Yes |
| `linkWindowsPhoneDeviceId` | Yes | Yes | Yes |
| `linkiOSDeviceId` | Yes | Yes | Yes |
| `removePushNotification` | Yes | Yes | Yes |
| `removeSegment` | Yes | Yes | Yes |
| `removeTag` | Yes | Yes | Yes |
| `resetAccountPassword` | Yes | Yes | Yes |
| `sendEmail` | Yes | Yes | Yes |
| `sendPushNotification` | Yes | Yes | Yes |
| `sendSocketOperationEvent` | Yes | Yes | Yes |
| `setAvatar` | Yes | Yes | Yes |
| `setCountryCode` | Yes | Yes | Yes |
| `setCustomData` | Yes | Yes | Yes |
| `setDisplayName` | Yes | Yes | Yes |
| `setEmail` | Yes | Yes | Yes |
| `setPlayerBan` | Yes | Yes | Yes |
| `setPlayerData` | Yes | Yes | Yes |
| `setTag` | Yes | Yes | Yes |
| `setTsLastLogin` | Yes | Yes | Yes |
| `unlinkAccount` | Yes | Yes | Yes |
| `unlinkAndroidDeviceId` | Yes | Yes | Yes |
| `unlinkApple` | Yes | Yes | Yes |
| `unlinkCustomDeviceId` | Yes | Yes | Yes |
| `unlinkCustomId` | Yes | Yes | Yes |
| `unlinkEditorDeviceId` | Yes | Yes | Yes |
| `unlinkFacebook` | Yes | Yes | Yes |
| `unlinkGameCenter` | Yes | Yes | Yes |
| `unlinkGenericService` | Yes | Yes | Yes |
| `unlinkGoogle` | Yes | Yes | Yes |
| `unlinkGooglePlayGameService` | Yes | Yes | Yes |
| `unlinkLinuxDeviceId` | Yes | Yes | Yes |
| `unlinkMacOSDeviceId` | Yes | Yes | Yes |
| `unlinkWindowsDeviceId` | Yes | Yes | Yes |
| `unlinkWindowsPhoneDeviceId` | Yes | Yes | Yes |
| `unlinkiOSDeviceId` | Yes | Yes | Yes |

## Multiplayer

Request type: `Multiplayer`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `cancelAllMatchmakingTicket` | Yes | Yes | Yes |
| `cancelMatchmakingTicket` | Yes | Yes | Yes |
| `createMatchmakingTicket` | Yes | Yes | Yes |
| `getAllMatch` | Yes | Yes | Yes |
| `getAllMatchmakingTicket` | Yes | Yes | Yes |
| `getMatch` | Yes | Yes | Yes |
| `getMatchmakingTicket` | Yes | Yes | Yes |
| `getQueueStatistics` | Yes | Yes | Yes |
| `joinMatchmakingTicket` | Yes | Yes | Yes |
| `listMatchmakingTicketsForPlayer` | Yes | Yes | Yes |

## Store Inventory

Request type: `StoreInventory`

| Operation | Client | Server | Admin |
| --- | --- | --- | --- |
| `buyStoreItem` | Yes | Yes | Yes |
| `createStoreItem` | Yes | Yes | Yes |
| `getCreateLeaderboard` | Yes | Yes | Yes |
| `getStoreItemInformation` | Yes | Yes | Yes |
| `getStoreItemsWithTag` | Yes | Yes | Yes |
| `getStoreLog` | Yes | Yes | Yes |
| `getStoreUsed` | Yes | Yes | Yes |
| `presentStoreItem` | Yes | Yes | Yes |
| `removeStoreUsed` | Yes | Yes | Yes |
| `setRemoveStatus` | Yes | Yes | Yes |
| `setStoreItemInformation` | Yes | Yes | Yes |
| `validateAppleAppStoreReceipt` | Yes | Yes | Yes |
| `validateFacebookStoreReceipt` | Yes | Yes | Yes |
| `validateGooglePlayStoreReceipt` | Yes | Yes | Yes |