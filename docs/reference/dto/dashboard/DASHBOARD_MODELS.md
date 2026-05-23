### PermissionRulesParam

Defines the reusable permission-rule block used by secret-info and master settings payloads. These flags map directly to the GearN Server permission checks described in the public docs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `selfEnable` | `bool?` | no | Allows the operation on resources that belong to the authenticated user context. |
| `otherSelfEnable` | `bool?` | no | Allows the operation on resources that do not belong to the authenticated user context. |
| `adminSelfEnable` | `bool?` | no | Allows the operation through admin-scoped execution context. |
| `serverSelfEnable` | `bool?` | no | Allows the operation through server-scoped execution context. |

### FriendCatalogSettingsParam

Defines the reusable parameter block FriendCatalogSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `description` | `string` | yes | Human-readable description of this friend catalog. |
| `forceAcceptFriend` | `bool` | yes | When `true`, friend requests are automatically accepted without explicit approval from the recipient. |

### ItemClassSettingsParam

Defines the reusable parameter block ItemClassSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `description` | `string` | yes | Human-readable description of this item class. |

### ItemCatalogSettingsParam

Defines the reusable parameter block ItemCatalogSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `itemType` | `int` | yes | Item type identifier. Map with the public `ItemType` enum. |
| `itemClassSettings` | `List<ItemClassSettingsParam>` | yes | List of item class configurations belonging to this catalog. — _elementCls=ItemClassSettingsParam_ |

Reference links:

- [DashboardModels.ItemClassSettingsParam:24-33](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#itemclasssettingsparam)

### GroupCatalogSettingsParam

Defines the reusable parameter block GroupCatalogSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `description` | `string` | yes | Human-readable description of this group catalog. |
| `forceAcceptMember` | `bool` | yes | When `true`, member join requests are automatically accepted without explicit approval from the group owner. |

### TagSettingsParam

Defines the reusable parameter block TagSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `description` | `string` | yes | Human-readable description of this tag key. |
| `index` | `bool` | yes | Whether this tag key is indexed for query filtering (e.g. `getPlayersWithTag`). |

### DataSettingsParam

Defines the reusable parameter block DataSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string` | yes | _minLength=2, maxLength=64_ |
| `permission` | `int` | yes | Read/write permission level for this data key. Map with the public permission enum. |

### StatisticsSettingsParam

Defines the reusable parameter block StatisticsSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `statisticsAggregationMethod` | `int` | yes | Aggregation method applied when updating this statistic. Map with the public `StatisticsAggregationMethod` enum. |
| `maximumValue` | `double?` | no | Maximum allowed value for this statistic; 0 means no upper bound. — _default=0_ |
| `minimumValue` | `double?` | no | Minimum allowed value for this statistic; 0 means no lower bound. — _default=0_ |
| `initialValue` | `double` | yes | Initial value assigned to this statistic when a player/entity is first created. |
| `description` | `string` | yes | Human-readable description of this statistic. |
| `index` | `bool` | yes | Whether this statistic is indexed for leaderboard queries. |

### CurrencySettingsParam

Defines the reusable parameter block CurrencySettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `initialValue` | `double` | yes | Initial balance assigned when a player/entity is first created. |
| `description` | `string` | yes | Human-readable description of this currency. |
| `index` | `bool` | yes | Whether this currency balance is indexed for leaderboard queries. |

### CharacterCatalogSettingsParam

Defines the reusable parameter block CharacterCatalogSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `description` | `string` | yes | Human-readable description of this character catalog. |

### CharacterPlayerPermissionRulesParam

Defines the reusable parameter block CharacterPlayerPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `addSegment` | `PermissionRulesParam?` | no | — |
| `removeSegment` | `PermissionRulesParam?` | no | — |
| `getSegment` | `PermissionRulesParam?` | no | — |
| `setTag` | `PermissionRulesParam?` | no | — |
| `removeTag` | `PermissionRulesParam?` | no | — |
| `getTag` | `PermissionRulesParam?` | no | — |
| `getDisplayName` | `PermissionRulesParam?` | no | — |
| `setDisplayName` | `PermissionRulesParam?` | no | — |
| `getTsCreate` | `PermissionRulesParam?` | no | — |
| `getIpAddressCreate` | `PermissionRulesParam?` | no | — |
| `getTsLastLogin` | `PermissionRulesParam?` | no | — |
| `setPlayerBan` | `PermissionRulesParam?` | no | — |
| `getPlayerBan` | `PermissionRulesParam?` | no | — |
| `setCountryCode` | `PermissionRulesParam?` | no | — |
| `getCountryCode` | `PermissionRulesParam?` | no | — |
| `setAvatar` | `PermissionRulesParam?` | no | — |
| `getAvatar` | `PermissionRulesParam?` | no | — |
| `changePlayerCurrency` | `PermissionRulesParam?` | no | — |
| `getPlayerCurrency` | `PermissionRulesParam?` | no | — |
| `changePlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getPlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboardAroundPlayer` | `PermissionRulesParam?` | no | — |
| `getCustomData` | `PermissionRulesParam?` | no | — |
| `setCustomData` | `PermissionRulesParam?` | no | — |
| `setPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerInformation` | `PermissionRulesParam?` | no | — |
| `getPlayersWithSegment` | `PermissionRulesParam?` | no | — |
| `getPlayersWithTag` | `PermissionRulesParam?` | no | — |
| `getCatalogId` | `PermissionRulesParam?` | no | — |
| `getOwner` | `PermissionRulesParam?` | no | — |
| `getRemoveStatus` | `PermissionRulesParam?` | no | — |
| `getPlayerFriend` | `PermissionRulesParam?` | no | — |
| `getPlayerGroup` | `PermissionRulesParam?` | no | — |
| `getPlayerInventory` | `PermissionRulesParam?` | no | — |
| `removePlayerItem` | `PermissionRulesParam?` | no | — |
| `createPlayerItem` | `PermissionRulesParam?` | no | — |
| `createGroup` | `PermissionRulesParam?` | no | — |
| `joinGroup` | `PermissionRulesParam?` | no | — |
| `leaveGroup` | `PermissionRulesParam?` | no | — |
| `setOwner` | `PermissionRulesParam?` | no | — |
| `addPlayerFriend` | `PermissionRulesParam?` | no | — |
| `removePlayerFriend` | `PermissionRulesParam?` | no | — |
| `getPlayersWithDisplayName` | `PermissionRulesParam?` | no | — |
| `setRemoveStatus` | `PermissionRulesParam?` | no | — |
| `getFriendStatisticsLeaderboardAroundPlayer` | `PermissionRulesParam?` | no | — |
| `getFriendStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCurrencyLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `getLastLoginLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLog` | `PermissionRulesParam?` | no | — |
| `getCurrencyLog` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### CharacterPlayerSettingsParam

Defines the reusable parameter block CharacterPlayerSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerCurrenciesSettings` | `List<CurrencySettingsParam>?` | no | _elementCls=CurrencySettingsParam_ |
| `playerStatisticsSettings` | `List<StatisticsSettingsParam>?` | no | _elementCls=StatisticsSettingsParam_ |
| `playerDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `customDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `tagsSettings` | `List<TagSettingsParam>?` | no | _elementCls=TagSettingsParam_ |
| `playerGroupCatalogSettings` | `List<GroupCatalogSettingsParam>?` | no | _elementCls=GroupCatalogSettingsParam_ |
| `playerItemCatalogSettings` | `List<ItemCatalogSettingsParam>?` | no | _elementCls=ItemCatalogSettingsParam_ |
| `playerFriendCatalogSettings` | `List<FriendCatalogSettingsParam>?` | no | _elementCls=FriendCatalogSettingsParam_ |

Reference links:

- [DashboardModels.CurrencySettingsParam:97-108](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#currencysettingsparam)
- [DashboardModels.StatisticsSettingsParam:82-96](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#statisticssettingsparam)
- [DashboardModels.DataSettingsParam:71-81](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#datasettingsparam)
- [DashboardModels.TagSettingsParam:60-70](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#tagsettingsparam)
- [DashboardModels.GroupCatalogSettingsParam:49-59](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#groupcatalogsettingsparam)
- [DashboardModels.ItemCatalogSettingsParam:34-48](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#itemcatalogsettingsparam)
- [DashboardModels.FriendCatalogSettingsParam:13-23](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#friendcatalogsettingsparam)

### ContentPermissionRulesParam

Defines the reusable parameter block ContentPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `getContentData` | `PermissionRulesParam?` | no | — |
| `setContentData` | `PermissionRulesParam?` | no | — |
| `createNewFileUploadInfo` | `PermissionRulesParam?` | no | — |
| `getFileUploadInfoList` | `PermissionRulesParam?` | no | — |
| `getFileUploadInfo` | `PermissionRulesParam?` | no | — |
| `removeFileUploadInfo` | `PermissionRulesParam?` | no | — |
| `requestDownloadFileUploadInfo` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### ThirtPartyAppleSettingsParam

Defines the reusable parameter block ThirtPartyAppleSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleClientId` | `string` | yes | Apple client ID (Services ID) from App Store Connect, used for Sign in with Apple. |
| `sandboxEnable` | `bool` | yes | When `true`, use Apple's sandbox environment for in-app purchase validation. |

### ThirtPartyFacebookSettingsParam

Defines the reusable parameter block ThirtPartyFacebookSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookAppId` | `string` | yes | Facebook application ID from the Meta Developer Portal. |
| `facebookAppToken` | `string` | yes | Facebook app access token used for server-side token validation. |
| `facebookInappSecret` | `string` | yes | Facebook in-app purchase secret used for payment receipt validation. |

### ThirtPartyGoogleSettingsParam

Defines the reusable parameter block ThirtPartyGoogleSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleClientId` | `string` | yes | Google OAuth 2.0 client ID used to verify Google Sign-In tokens. |
| `packageId` | `string` | yes | Android package name used for Google Play in-app purchase validation. |
| `publicRSAKey` | `string` | yes | Google Play public RSA key used for receipt signature verification. |

### ThirtPartyGameCenterSettingsParam

Defines the reusable parameter block ThirtPartyGameCenterSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `packageId` | `string` | yes | iOS bundle ID used for Apple Game Center identity validation. |

### ThirtPartyGooglePlayGameSettingsParam

Defines the reusable parameter block ThirtPartyGooglePlayGameSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `redirectUri` | `string` | yes | OAuth redirect URI configured in Google Cloud Console for Google Play Game Services. |
| `clientId` | `string` | yes | Google OAuth 2.0 client ID for Google Play Game Services. |
| `clientSecret` | `string` | yes | Google OAuth 2.0 client secret for Google Play Game Services. |
| `applicationId` | `string` | yes | Google Play application ID. |

### ThirtPartyParam

Defines the reusable parameter block ThirtPartyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleSettings` | `ThirtPartyGoogleSettingsParam?` | no | — |
| `facebookSettings` | `ThirtPartyFacebookSettingsParam?` | no | — |
| `appleSettings` | `ThirtPartyAppleSettingsParam?` | no | — |
| `googlePlayGameSettings` | `ThirtPartyGooglePlayGameSettingsParam?` | no | — |
| `gameCenterSettings` | `ThirtPartyGameCenterSettingsParam?` | no | — |

Reference links:

- [DashboardModels.ThirtPartyGoogleSettingsParam:250-260](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartygooglesettingsparam)
- [DashboardModels.ThirtPartyFacebookSettingsParam:239-249](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartyfacebooksettingsparam)
- [DashboardModels.ThirtPartyAppleSettingsParam:229-238](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartyapplesettingsparam)
- [DashboardModels.ThirtPartyGooglePlayGameSettingsParam:270-281](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartygoogleplaygamesettingsparam)
- [DashboardModels.ThirtPartyGameCenterSettingsParam:261-269](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartygamecentersettingsparam)

### EmailSettingsParam

Defines the reusable parameter block EmailSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `sendFrom` | `string` | yes | Sender email address displayed in outgoing system emails. |
| `secure` | `bool` | yes | Whether to use TLS for the SMTP connection. |
| `host` | `string` | yes | SMTP server hostname. |
| `port` | `int` | yes | SMTP server port number (typically 465 for TLS, 587 for STARTTLS). |
| `username` | `string` | yes | SMTP authentication username. |
| `password` | `string` | yes | SMTP authentication password. |

### PushNotificationSettingsParam

Defines the reusable parameter block PushNotificationSettingsParam. Uses Firebase Cloud Messaging (FCM) credentials.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `projectId` | `string` | yes | Firebase project ID from the Firebase Console. |
| `clientEmail` | `string` | yes | Firebase service account client email for authentication. |
| `privateKey` | `string` | yes | Firebase service account private key for authentication. |

### GamePlayerPermissionRulesParam

Defines the reusable parameter block GamePlayerPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `addSegment` | `PermissionRulesParam?` | no | — |
| `removeSegment` | `PermissionRulesParam?` | no | — |
| `getSegment` | `PermissionRulesParam?` | no | — |
| `setTag` | `PermissionRulesParam?` | no | — |
| `removeTag` | `PermissionRulesParam?` | no | — |
| `getTag` | `PermissionRulesParam?` | no | — |
| `getDisplayName` | `PermissionRulesParam?` | no | — |
| `setDisplayName` | `PermissionRulesParam?` | no | — |
| `getTsCreate` | `PermissionRulesParam?` | no | — |
| `getIpAddressCreate` | `PermissionRulesParam?` | no | — |
| `getTsLastLogin` | `PermissionRulesParam?` | no | — |
| `setPlayerBan` | `PermissionRulesParam?` | no | — |
| `getPlayerBan` | `PermissionRulesParam?` | no | — |
| `setCountryCode` | `PermissionRulesParam?` | no | — |
| `getCountryCode` | `PermissionRulesParam?` | no | — |
| `setAvatar` | `PermissionRulesParam?` | no | — |
| `getAvatar` | `PermissionRulesParam?` | no | — |
| `changePlayerCurrency` | `PermissionRulesParam?` | no | — |
| `getPlayerCurrency` | `PermissionRulesParam?` | no | — |
| `changePlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getPlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboardAroundPlayer` | `PermissionRulesParam?` | no | — |
| `getCustomData` | `PermissionRulesParam?` | no | — |
| `setCustomData` | `PermissionRulesParam?` | no | — |
| `setPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerInformation` | `PermissionRulesParam?` | no | — |
| `getPlayersWithSegment` | `PermissionRulesParam?` | no | — |
| `getPlayersWithTag` | `PermissionRulesParam?` | no | — |
| `getPlayerCharacter` | `PermissionRulesParam?` | no | — |
| `getPlayerInventory` | `PermissionRulesParam?` | no | — |
| `getPlayerGroup` | `PermissionRulesParam?` | no | — |
| `getPlayerFriend` | `PermissionRulesParam?` | no | — |
| `removePlayerItem` | `PermissionRulesParam?` | no | — |
| `createGroup` | `PermissionRulesParam?` | no | — |
| `createPlayerItem` | `PermissionRulesParam?` | no | — |
| `createPlayerCharacter` | `PermissionRulesParam?` | no | — |
| `addPlayerFriend` | `PermissionRulesParam?` | no | — |
| `removePlayerFriend` | `PermissionRulesParam?` | no | — |
| `removePlayerCharacter` | `PermissionRulesParam?` | no | — |
| `joinGroup` | `PermissionRulesParam?` | no | — |
| `leaveGroup` | `PermissionRulesParam?` | no | — |
| `getPlayersWithDisplayName` | `PermissionRulesParam?` | no | — |
| `getFriendStatisticsLeaderboardAroundPlayer` | `PermissionRulesParam?` | no | — |
| `getFriendStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCurrencyLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `getLastLoginLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLog` | `PermissionRulesParam?` | no | — |
| `getCurrencyLog` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### GamePlayerSettingsParam

Defines the reusable parameter block GamePlayerSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerCurrenciesSettings` | `List<CurrencySettingsParam>?` | no | _elementCls=CurrencySettingsParam_ |
| `playerStatisticsSettings` | `List<StatisticsSettingsParam>?` | no | _elementCls=StatisticsSettingsParam_ |
| `playerDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `customDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `tagsSettings` | `List<TagSettingsParam>?` | no | _elementCls=TagSettingsParam_ |
| `playerCharacterCatalogSettings` | `List<CharacterCatalogSettingsParam>?` | no | _elementCls=CharacterCatalogSettingsParam_ |
| `playerGroupCatalogSettings` | `List<GroupCatalogSettingsParam>?` | no | _elementCls=GroupCatalogSettingsParam_ |
| `playerItemCatalogSettings` | `List<ItemCatalogSettingsParam>?` | no | _elementCls=ItemCatalogSettingsParam_ |
| `playerFriendCatalogSettings` | `List<FriendCatalogSettingsParam>?` | no | _elementCls=FriendCatalogSettingsParam_ |

Reference links:

- [DashboardModels.CurrencySettingsParam:97-108](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#currencysettingsparam)
- [DashboardModels.StatisticsSettingsParam:82-96](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#statisticssettingsparam)
- [DashboardModels.DataSettingsParam:71-81](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#datasettingsparam)
- [DashboardModels.TagSettingsParam:60-70](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#tagsettingsparam)
- [DashboardModels.CharacterCatalogSettingsParam:109-118](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#charactercatalogsettingsparam)
- [DashboardModels.GroupCatalogSettingsParam:49-59](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#groupcatalogsettingsparam)
- [DashboardModels.ItemCatalogSettingsParam:34-48](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#itemcatalogsettingsparam)
- [DashboardModels.FriendCatalogSettingsParam:13-23](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#friendcatalogsettingsparam)

### GroupSettingsParam

Defines the reusable parameter block GroupSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `groupCurrenciesSettings` | `List<CurrencySettingsParam>?` | no | _elementCls=CurrencySettingsParam_ |
| `groupStatisticsSettings` | `List<StatisticsSettingsParam>?` | no | _elementCls=StatisticsSettingsParam_ |
| `groupDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `customDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `tagsSettings` | `List<TagSettingsParam>?` | no | _elementCls=TagSettingsParam_ |
| `groupItemCatalogSettings` | `List<ItemCatalogSettingsParam>?` | no | _elementCls=ItemCatalogSettingsParam_ |

Reference links:

- [DashboardModels.CurrencySettingsParam:97-108](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#currencysettingsparam)
- [DashboardModels.StatisticsSettingsParam:82-96](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#statisticssettingsparam)
- [DashboardModels.DataSettingsParam:71-81](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#datasettingsparam)
- [DashboardModels.TagSettingsParam:60-70](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#tagsettingsparam)
- [DashboardModels.ItemCatalogSettingsParam:34-48](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#itemcatalogsettingsparam)

### InventorySettingsParam

Defines the reusable parameter block InventorySettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `itemStatisticsSettings` | `List<StatisticsSettingsParam>?` | no | _elementCls=StatisticsSettingsParam_ |
| `itemDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `customDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `tagsSettings` | `List<TagSettingsParam>?` | no | _elementCls=TagSettingsParam_ |

Reference links:

- [DashboardModels.StatisticsSettingsParam:82-96](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#statisticssettingsparam)
- [DashboardModels.DataSettingsParam:71-81](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#datasettingsparam)
- [DashboardModels.TagSettingsParam:60-70](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#tagsettingsparam)

### GameSettingsParam

Defines the reusable parameter block GameSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gamePlayerSettings` | `GamePlayerSettingsParam?` | no | — |
| `characterPlayerSettings` | `CharacterPlayerSettingsParam?` | no | — |
| `groupSettings` | `GroupSettingsParam?` | no | — |
| `inventorySettings` | `InventorySettingsParam?` | no | — |

Reference links:

- [DashboardModels.GamePlayerSettingsParam:391-418](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#gameplayersettingsparam)
- [DashboardModels.CharacterPlayerSettingsParam:184-209](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#characterplayersettingsparam)
- [DashboardModels.GroupSettingsParam:419-440](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#groupsettingsparam)
- [DashboardModels.InventorySettingsParam:441-458](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#inventorysettingsparam)

### GenericServiceSettingsParam

Defines the reusable parameter block GenericServiceSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | _minLength=2, maxLength=32_ |

### GroupPermissionRulesParam

Defines the reusable parameter block GroupPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `addSegment` | `PermissionRulesParam?` | no | — |
| `removeSegment` | `PermissionRulesParam?` | no | — |
| `getSegment` | `PermissionRulesParam?` | no | — |
| `setTag` | `PermissionRulesParam?` | no | — |
| `removeTag` | `PermissionRulesParam?` | no | — |
| `getTag` | `PermissionRulesParam?` | no | — |
| `getDisplayName` | `PermissionRulesParam?` | no | — |
| `setDisplayName` | `PermissionRulesParam?` | no | — |
| `getTsCreate` | `PermissionRulesParam?` | no | — |
| `setAvatar` | `PermissionRulesParam?` | no | — |
| `getAvatar` | `PermissionRulesParam?` | no | — |
| `changeGroupCurrency` | `PermissionRulesParam?` | no | — |
| `getGroupCurrency` | `PermissionRulesParam?` | no | — |
| `changeGroupStatistics` | `PermissionRulesParam?` | no | — |
| `getGroupStatistics` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboardAroundGroup` | `PermissionRulesParam?` | no | — |
| `getCustomData` | `PermissionRulesParam?` | no | — |
| `setCustomData` | `PermissionRulesParam?` | no | — |
| `setGroupData` | `PermissionRulesParam?` | no | — |
| `getGroupData` | `PermissionRulesParam?` | no | — |
| `getGroupInformation` | `PermissionRulesParam?` | no | — |
| `getGroupsWithSegment` | `PermissionRulesParam?` | no | — |
| `getGroupsWithTag` | `PermissionRulesParam?` | no | — |
| `getCatalogId` | `PermissionRulesParam?` | no | — |
| `getRemoveStatus` | `PermissionRulesParam?` | no | — |
| `getGroupInventory` | `PermissionRulesParam?` | no | — |
| `removeGroupItem` | `PermissionRulesParam?` | no | — |
| `createGroupItem` | `PermissionRulesParam?` | no | — |
| `getMembers` | `PermissionRulesParam?` | no | — |
| `addMember` | `PermissionRulesParam?` | no | — |
| `removeMember` | `PermissionRulesParam?` | no | — |
| `sendGroupMessage` | `PermissionRulesParam?` | no | — |
| `getGroupMessage` | `PermissionRulesParam?` | no | — |
| `setRemoveStatus` | `PermissionRulesParam?` | no | — |
| `getGroupsWithDisplayName` | `PermissionRulesParam?` | no | — |
| `getCurrencyLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLog` | `PermissionRulesParam?` | no | — |
| `getCurrencyLog` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### InventoryPermissionRulesParam

Defines the reusable parameter block InventoryPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `addSegment` | `PermissionRulesParam?` | no | — |
| `removeSegment` | `PermissionRulesParam?` | no | — |
| `getSegment` | `PermissionRulesParam?` | no | — |
| `setTag` | `PermissionRulesParam?` | no | — |
| `removeTag` | `PermissionRulesParam?` | no | — |
| `getTag` | `PermissionRulesParam?` | no | — |
| `getDisplayName` | `PermissionRulesParam?` | no | — |
| `setDisplayName` | `PermissionRulesParam?` | no | — |
| `getTsCreate` | `PermissionRulesParam?` | no | — |
| `setAvatar` | `PermissionRulesParam?` | no | — |
| `getAvatar` | `PermissionRulesParam?` | no | — |
| `changeItemStatistics` | `PermissionRulesParam?` | no | — |
| `getItemStatistics` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboardAroundItem` | `PermissionRulesParam?` | no | — |
| `getCustomData` | `PermissionRulesParam?` | no | — |
| `setCustomData` | `PermissionRulesParam?` | no | — |
| `setItemData` | `PermissionRulesParam?` | no | — |
| `getItemData` | `PermissionRulesParam?` | no | — |
| `getItemInformation` | `PermissionRulesParam?` | no | — |
| `getItemsWithSegment` | `PermissionRulesParam?` | no | — |
| `getItemsWithTag` | `PermissionRulesParam?` | no | — |
| `getCatalogId` | `PermissionRulesParam?` | no | — |
| `getClassId` | `PermissionRulesParam?` | no | — |
| `getItemType` | `PermissionRulesParam?` | no | — |
| `getAmount` | `PermissionRulesParam?` | no | — |
| `getOwner` | `PermissionRulesParam?` | no | — |
| `getRemoveStatus` | `PermissionRulesParam?` | no | — |
| `setAmount` | `PermissionRulesParam?` | no | — |
| `setOwner` | `PermissionRulesParam?` | no | — |
| `setRemoveStatus` | `PermissionRulesParam?` | no | — |
| `getItemsWithDisplayName` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLog` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### DashboardPermissionRulesParam

Defines the reusable parameter block DashboardPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `setMasterGameSettings` | `PermissionRulesParam?` | no | — |
| `createAdminAccount` | `PermissionRulesParam?` | no | — |
| `removeAdminAccount` | `PermissionRulesParam?` | no | — |
| `setPasswordAdminAccount` | `PermissionRulesParam?` | no | — |
| `setSecretKeyAdminAccount` | `PermissionRulesParam?` | no | — |
| `setGameInformation` | `PermissionRulesParam?` | no | — |
| `createGame` | `PermissionRulesParam?` | no | — |
| `changePasswordAdminAccount` | `PermissionRulesParam?` | no | — |
| `getAdminAccountList` | `PermissionRulesParam?` | no | — |
| `getGameInformation` | `PermissionRulesParam?` | no | — |
| `getGameList` | `PermissionRulesParam?` | no | — |
| `getMasterGameSettings` | `PermissionRulesParam?` | no | — |
| `getServerLog` | `PermissionRulesParam?` | no | — |
| `getSecretInfoInformation` | `PermissionRulesParam?` | no | — |
| `getSecretInfoList` | `PermissionRulesParam?` | no | — |
| `createSecretInfo` | `PermissionRulesParam?` | no | — |
| `setSecretInfoInformation` | `PermissionRulesParam?` | no | — |
| `getUsernameAdminAccount` | `PermissionRulesParam?` | no | — |
| `getAnalytics` | `PermissionRulesParam?` | no | — |
| `getEventCallbackCloudScript` | `PermissionRulesParam?` | no | — |
| `setEventCallbackCloudScript` | `PermissionRulesParam?` | no | — |
| `resetStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getBackupStatisticsLeaderboardVersion` | `PermissionRulesParam?` | no | — |
| `getServerGameData` | `PermissionRulesParam?` | no | — |
| `deleteInDatabase` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### MultiplayerPermissionRulesParam

Defines the reusable parameter block MultiplayerPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `cancelAllMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `cancelMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `createMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `getMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `getMatch` | `PermissionRulesParam?` | no | — |
| `getQueueStatistics` | `PermissionRulesParam?` | no | — |
| `joinMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `listMatchmakingTicketsForPlayer` | `PermissionRulesParam?` | no | — |
| `getAllMatchmakingTicket` | `PermissionRulesParam?` | no | — |
| `getAllMatch` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### MasterPlayerPermissionRulesParam

Defines the reusable parameter block MasterPlayerPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `linkAccount` | `PermissionRulesParam?` | no | — |
| `linkAndroidDeviceId` | `PermissionRulesParam?` | no | — |
| `linkApple` | `PermissionRulesParam?` | no | — |
| `linkCustomDeviceId` | `PermissionRulesParam?` | no | — |
| `linkCustomId` | `PermissionRulesParam?` | no | — |
| `linkEditorDeviceId` | `PermissionRulesParam?` | no | — |
| `linkFacebook` | `PermissionRulesParam?` | no | — |
| `linkGenericService` | `PermissionRulesParam?` | no | — |
| `linkGoogle` | `PermissionRulesParam?` | no | — |
| `linkGooglePlayGameService` | `PermissionRulesParam?` | no | — |
| `linkGameCenter` | `PermissionRulesParam?` | no | — |
| `linkiOSDeviceId` | `PermissionRulesParam?` | no | — |
| `linkLinuxDeviceId` | `PermissionRulesParam?` | no | — |
| `linkMacOSDeviceId` | `PermissionRulesParam?` | no | — |
| `linkWindowsDeviceId` | `PermissionRulesParam?` | no | — |
| `linkWindowsPhoneDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkAccount` | `PermissionRulesParam?` | no | — |
| `unlinkAndroidDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkApple` | `PermissionRulesParam?` | no | — |
| `unlinkCustomDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkCustomId` | `PermissionRulesParam?` | no | — |
| `unlinkEditorDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkFacebook` | `PermissionRulesParam?` | no | — |
| `unlinkGenericService` | `PermissionRulesParam?` | no | — |
| `unlinkGoogle` | `PermissionRulesParam?` | no | — |
| `unlinkGooglePlayGameService` | `PermissionRulesParam?` | no | — |
| `unlinkGameCenter` | `PermissionRulesParam?` | no | — |
| `unlinkiOSDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkLinuxDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkMacOSDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkWindowsDeviceId` | `PermissionRulesParam?` | no | — |
| `unlinkWindowsPhoneDeviceId` | `PermissionRulesParam?` | no | — |
| `addSegment` | `PermissionRulesParam?` | no | — |
| `removeSegment` | `PermissionRulesParam?` | no | — |
| `getSegment` | `PermissionRulesParam?` | no | — |
| `setTag` | `PermissionRulesParam?` | no | — |
| `removeTag` | `PermissionRulesParam?` | no | — |
| `getTag` | `PermissionRulesParam?` | no | — |
| `getDisplayName` | `PermissionRulesParam?` | no | — |
| `setDisplayName` | `PermissionRulesParam?` | no | — |
| `getTsCreate` | `PermissionRulesParam?` | no | — |
| `getIpAddressCreate` | `PermissionRulesParam?` | no | — |
| `updateTsLastLogin` | `PermissionRulesParam?` | no | — |
| `getTsLastLogin` | `PermissionRulesParam?` | no | — |
| `setPlayerBan` | `PermissionRulesParam?` | no | — |
| `getPlayerBan` | `PermissionRulesParam?` | no | — |
| `setCountryCode` | `PermissionRulesParam?` | no | — |
| `getCountryCode` | `PermissionRulesParam?` | no | — |
| `changeAccountPassword` | `PermissionRulesParam?` | no | — |
| `resetAccountPassword` | `PermissionRulesParam?` | no | — |
| `setAvatar` | `PermissionRulesParam?` | no | — |
| `getAvatar` | `PermissionRulesParam?` | no | — |
| `changePlayerCurrency` | `PermissionRulesParam?` | no | — |
| `getPlayerCurrency` | `PermissionRulesParam?` | no | — |
| `changePlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getPlayerStatistics` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLeaderboardAroundPlayer` | `PermissionRulesParam?` | no | — |
| `getCustomData` | `PermissionRulesParam?` | no | — |
| `setCustomData` | `PermissionRulesParam?` | no | — |
| `setPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerData` | `PermissionRulesParam?` | no | — |
| `getPlayerInformation` | `PermissionRulesParam?` | no | — |
| `getPlayersWithApple` | `PermissionRulesParam?` | no | — |
| `getPlayersWithFacebook` | `PermissionRulesParam?` | no | — |
| `getPlayersWithGoogle` | `PermissionRulesParam?` | no | — |
| `getPlayersWithGenericService` | `PermissionRulesParam?` | no | — |
| `getPlayersWithSegment` | `PermissionRulesParam?` | no | — |
| `getPlayersWithTag` | `PermissionRulesParam?` | no | — |
| `getPlayersWithGooglePlayGameService` | `PermissionRulesParam?` | no | — |
| `getPlayersWithGameCenter` | `PermissionRulesParam?` | no | — |
| `getExternal` | `PermissionRulesParam?` | no | — |
| `getPlayersWithDisplayName` | `PermissionRulesParam?` | no | — |
| `getEmail` | `PermissionRulesParam?` | no | — |
| `setEmail` | `PermissionRulesParam?` | no | — |
| `getCurrencyLeaderboard` | `PermissionRulesParam?` | no | — |
| `getLastLoginLeaderboard` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `getStatisticsLog` | `PermissionRulesParam?` | no | — |
| `getCurrencyLog` | `PermissionRulesParam?` | no | — |
| `sendSocketOperationEvent` | `PermissionRulesParam?` | no | — |
| `sendEmail` | `PermissionRulesParam?` | no | — |
| `sendPushNotification` | `PermissionRulesParam?` | no | — |
| `addPushNotification` | `PermissionRulesParam?` | no | — |
| `removePushNotification` | `PermissionRulesParam?` | no | — |
| `getPushNotification` | `PermissionRulesParam?` | no | — |
| `getOnlineStatus` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### MasterPlayerSettingsParam

Defines the reusable parameter block MasterPlayerSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `genericServiceSettings` | `List<GenericServiceSettingsParam>?` | no | _elementCls=GenericServiceSettingsParam_ |
| `playerCurrenciesSettings` | `List<CurrencySettingsParam>?` | no | _elementCls=CurrencySettingsParam_ |
| `playerStatisticsSettings` | `List<StatisticsSettingsParam>?` | no | _elementCls=StatisticsSettingsParam_ |
| `playerDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `customDatasSettings` | `List<DataSettingsParam>?` | no | _elementCls=DataSettingsParam_ |
| `tagsSettings` | `List<TagSettingsParam>?` | no | _elementCls=TagSettingsParam_ |

Reference links:

- [DashboardModels.GenericServiceSettingsParam:478-486](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#genericservicesettingsparam)
- [DashboardModels.CurrencySettingsParam:97-108](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#currencysettingsparam)
- [DashboardModels.StatisticsSettingsParam:82-96](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#statisticssettingsparam)
- [DashboardModels.DataSettingsParam:71-81](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#datasettingsparam)
- [DashboardModels.TagSettingsParam:60-70](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#tagsettingsparam)

### SizeParam

Defines the reusable parameter block SizeParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `min` | `int` | yes | _min=1_ |
| `max` | `int` | yes | _min=1_ |

### TeamParam

Defines the reusable parameter block TeamParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `teamId` | `string` | yes | _minLength=1, maxLength=32_ |
| `teamSize` | `SizeParam` | yes | — |

Reference links:

- [DashboardModels.SizeParam:765-774](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#sizeparam)

### LinearExpansionsParam

Defines the reusable parameter block LinearExpansionsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secondsBetweenExpansions` | `int` | yes | _min=1_ |
| `delta` | `int?` | no | — |
| `limit` | `int?` | no | — |

### CustomExpansionsParam

Defines the reusable parameter block CustomExpansionsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secondsBetweenExpansions` | `int` | yes | _min=1_ |
| `overrideValue` | `List<object>?` | no | _elementCls=Object_ |
| `overrideMin` | `List<object>?` | no | _elementCls=Object_ |
| `overrideMax` | `List<object>?` | no | _elementCls=Object_ |

### AdvancedSettingsParam

Defines the reusable parameter block AdvancedSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secondsUntilOptional` | `int` | yes | _min=1_ |
| `expansionType` | `int?` | no | _min=1, max=3_ |
| `linearExpansions` | `LinearExpansionsParam?` | no | — |
| `customExpansions` | `CustomExpansionsParam?` | no | — |

Reference links:

- [DashboardModels.LinearExpansionsParam:789-799](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#linearexpansionsparam)
- [DashboardModels.CustomExpansionsParam:800-811](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#customexpansionsparam)

### RuleParam

Defines the reusable parameter block RuleParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `name` | `string` | yes | _minLength=1, maxLength=32_ |
| `type` | `int` | yes | _min=1, max=8_ |
| `attributeSource` | `int?` | no | _min=1, max=2_ |
| `attributePath` | `string?` | no | _minLength=1, maxLength=32_ |
| `defaultValue` | `object?` | no | — |
| `compairType` | `int?` | no | _min=1, max=2_ |
| `allowedDifference` | `int?` | no | _min=0_ |
| `min` | `int?` | no | — |
| `max` | `int?` | no | — |
| `advancedSettings` | `AdvancedSettingsParam?` | no | — |

Reference links:

- [DashboardModels.AdvancedSettingsParam:812-828](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#advancedsettingsparam)

### ServerAllocationParam

Defines the reusable parameter block ServerAllocationParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `enable` | `bool` | yes | — |

### MatchmakingQueueSettingsParam

Defines the reusable parameter block MatchmakingQueueSettingsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |
| `matchSize` | `SizeParam` | no | — |
| `ticketSize` | `SizeParam` | no | — |
| `serverAllocation` | `ServerAllocationParam` | no | — |
| `teams` | `List<TeamParam>?` | no | _elementCls=TeamParam_ |
| `rules` | `List<RuleParam>?` | no | _elementCls=RuleParam_ |
| `remove` | `bool?` | no | — |

Reference links:

- [DashboardModels.SizeParam:765-774](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#sizeparam)
- [DashboardModels.ServerAllocationParam:851-859](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#serverallocationparam)
- [DashboardModels.TeamParam:775-788](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#teamparam)
- [DashboardModels.RuleParam:829-850](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#ruleparam)

### AuthenticatePermissionRulesParam

Defines the reusable parameter block AuthenticatePermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `loginByAccount` | `PermissionRulesParam?` | no | — |
| `loginByAndroidDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByApple` | `PermissionRulesParam?` | no | — |
| `loginByCustomDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByCustomId` | `PermissionRulesParam?` | no | — |
| `loginByFacebook` | `PermissionRulesParam?` | no | — |
| `loginByGenericService` | `PermissionRulesParam?` | no | — |
| `loginByGoogle` | `PermissionRulesParam?` | no | — |
| `loginByGooglePlayGameService` | `PermissionRulesParam?` | no | — |
| `loginByGameCenter` | `PermissionRulesParam?` | no | — |
| `loginByiOSDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByWindowsPhoneDeviceId` | `PermissionRulesParam?` | no | — |
| `registerAccount` | `PermissionRulesParam?` | no | — |
| `loginByEditorDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByLinuxDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByMacOSDeviceId` | `PermissionRulesParam?` | no | — |
| `loginByWindowsDeviceId` | `PermissionRulesParam?` | no | — |
| `refreshAuthToken` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### StoreInventoryPermissionRulesParam

Defines the reusable parameter block StoreInventoryPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `buyStoreItem` | `PermissionRulesParam?` | no | — |
| `getStoreItemInformation` | `PermissionRulesParam?` | no | — |
| `getStoreItemsWithTag` | `PermissionRulesParam?` | no | — |
| `createStoreItem` | `PermissionRulesParam?` | no | — |
| `setRemoveStatus` | `PermissionRulesParam?` | no | — |
| `setStoreItemInformation` | `PermissionRulesParam?` | no | — |
| `validateAppleAppStoreReceipt` | `PermissionRulesParam?` | no | — |
| `validateGooglePlayStoreReceipt` | `PermissionRulesParam?` | no | — |
| `validateFacebookStoreReceipt` | `PermissionRulesParam?` | no | — |
| `getCreateLeaderboard` | `PermissionRulesParam?` | no | — |
| `presentStoreItem` | `PermissionRulesParam?` | no | — |
| `getStoreLog` | `PermissionRulesParam?` | no | — |
| `getStoreUsed` | `PermissionRulesParam?` | no | — |
| `removeStoreUsed` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### CloudScriptPermissionRulesParam

Defines the reusable parameter block CloudScriptPermissionRulesParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `executeFunction` | `PermissionRulesParam?` | no | — |
| `addFunction` | `PermissionRulesParam?` | no | — |
| `getFunctions` | `PermissionRulesParam?` | no | — |
| `getFunction` | `PermissionRulesParam?` | no | — |
| `editFunction` | `PermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.PermissionRulesParam:1-12](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionrulesparam)

### PermissionParam

Defines the top-level permission tree assigned to one secret info entry. Each optional property groups `permission rules` by API domain.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `authenticate` | `AuthenticatePermissionRulesParam?` | no | — |
| `masterPlayer` | `MasterPlayerPermissionRulesParam?` | no | — |
| `gamePlayer` | `GamePlayerPermissionRulesParam?` | no | — |
| `characterPlayer` | `CharacterPlayerPermissionRulesParam?` | no | — |
| `content` | `ContentPermissionRulesParam?` | no | — |
| `group` | `GroupPermissionRulesParam?` | no | — |
| `inventory` | `InventoryPermissionRulesParam?` | no | — |
| `storeInventory` | `StoreInventoryPermissionRulesParam?` | no | — |
| `dashboard` | `DashboardPermissionRulesParam?` | no | — |
| `multiplayer` | `MultiplayerPermissionRulesParam?` | no | — |
| `cloudScript` | `CloudScriptPermissionRulesParam?` | no | — |

Reference links:

- [DashboardModels.AuthenticatePermissionRulesParam:882-911](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#authenticatepermissionrulesparam)
- [DashboardModels.MasterPlayerPermissionRulesParam:644-742](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#masterplayerpermissionrulesparam)
- [DashboardModels.GamePlayerPermissionRulesParam:328-390](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#gameplayerpermissionrulesparam)
- [DashboardModels.CharacterPlayerPermissionRulesParam:119-183](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#characterplayerpermissionrulesparam)
- [DashboardModels.ContentPermissionRulesParam:210-228](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#contentpermissionrulesparam)
- [DashboardModels.GroupPermissionRulesParam:487-538](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#grouppermissionrulesparam)
- [DashboardModels.InventoryPermissionRulesParam:539-584](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#inventorypermissionrulesparam)
- [DashboardModels.StoreInventoryPermissionRulesParam:912-937](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#storeinventorypermissionrulesparam)
- [DashboardModels.DashboardPermissionRulesParam:585-621](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#dashboardpermissionrulesparam)
- [DashboardModels.MultiplayerPermissionRulesParam:622-643](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#multiplayerpermissionrulesparam)
- [DashboardModels.CloudScriptPermissionRulesParam:938-954](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#cloudscriptpermissionrulesparam)

### ChangePasswordAdminAccountRequestData

Defines the request payload for ChangePasswordAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `currentPassword` | `string` | yes | _minLength=6, maxLength=64_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### GetAdminAccountListRequestData

Defines the request payload for GetAdminAccountList.

_Không có field public (payload rỗng)._

### GetGameInformationRequestData

Defines the request payload for GetGameInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |

### GetGameListRequestData

Defines the request payload for GetGameList.

_Không có field public (payload rỗng)._

### GetMasterGameSettingsRequestData

Defines the request payload for GetMasterGameSettings.

_Không có field public (payload rỗng)._

### GetSecretInfoInformationRequestData

Defines the request payload for GetSecretInfoInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKey` | `string` | yes | _minLength=6, maxLength=64_ |

### GetSecretInfoListRequestData

Defines the request payload for GetSecretInfoList.

_Không có field public (payload rỗng)._

### GetServerLogRequestData

Defines the request payload for GetServerLog.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `skip` | `int?` | no | Pagination offset. — _default=0, minValue=0, mustInt_ |
| `limit` | `int?` | no | Page size. — _default=50, minValue=5, maxValue=200, mustInt_ |

### CreateAdminAccountRequestData

Defines the request payload for CreateAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `secretKey` | `string` | yes | _minLength=6, maxLength=64_ |

### CreateGameRequestData

Defines the request payload for CreateGame.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |

### CreateSecretInfoRequestData

Defines the request payload for `createSecretInfo`. `permissionParam` is the authoritative permission tree that controls which operations the created secret key may execute on the GearN Server.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKey` | `string?` | no | Optional custom secret key. If omitted, the backend may generate one. — _minLength=6, maxLength=64_ |
| `gameId` | `string?` | no | Optional target game id when creating a secret for a specific game. — _minLength=2, maxLength=32_ |
| `permissionParam` | `PermissionParam?` | no | Optional permission tree granted to the new secret key. |

Reference links:

- [DashboardModels.PermissionParam:955-987](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionparam)

### LoginByAdminAccountRequestData

Defines the request payload for `loginByAdminAccount`. A successful response returns an auth token that later dashboard calls reuse so backend middleware can resolve admin context.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | _minLength=4, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### RemoveAdminAccountRequestData

Defines the request payload for RemoveAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

### SetGameInformationRequestData

Defines the request payload for SetGameInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |
| `gameName` | `string?` | no | — |
| `gameDescription` | `string?` | no | — |
| `gameIconUrl` | `string?` | no | — |
| `gameSettings` | `GameSettingsParam?` | no | — |
| `matchmakingQueueSettings` | `List<MatchmakingQueueSettingsParam>?` | no | _elementCls=MatchmakingQueueSettingsParam_ |

Reference links:

- [DashboardModels.GameSettingsParam:459-477](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#gamesettingsparam)
- [DashboardModels.MatchmakingQueueSettingsParam:860-881](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#matchmakingqueuesettingsparam)

### SetMasterGameSettingsRequestData

Defines the request payload for SetMasterGameSettings.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `thirtPartySettings` | `ThirtPartyParam?` | no | — |
| `masterPlayerSettings` | `MasterPlayerSettingsParam?` | no | — |
| `emailSettings` | `EmailSettingsParam?` | no | — |
| `pushNotificationSettings` | `PushNotificationSettingsParam?` | no | — |

Reference links:

- [DashboardModels.ThirtPartyParam:282-302](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartyparam)
- [DashboardModels.MasterPlayerSettingsParam:743-764](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#masterplayersettingsparam)
- [DashboardModels.EmailSettingsParam:303-316](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#emailsettingsparam)
- [DashboardModels.PushNotificationSettingsParam:317-327](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#pushnotificationsettingsparam)

### SetPasswordAdminAccountRequestData

Defines the request payload for SetPasswordAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### SetSecretInfoInformationRequestData

Defines the request payload for SetSecretInfoInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKey` | `string` | yes | _minLength=6, maxLength=64_ |
| `remove` | `bool?` | no | — |
| `tsExpire` | `long?` | no | — |
| `description` | `string?` | no | — |
| `permissionParam` | `PermissionParam?` | no | — |

Reference links:

- [DashboardModels.PermissionParam:955-987](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionparam)

### SetSecretKeyAdminAccountRequestData

Defines the request payload for SetSecretKeyAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |
| `secretKey` | `string` | yes | _minLength=6, maxLength=64_ |

### GetAnalyticsRequestData

Defines the request payload for GetAnalytics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `timestamp` | `long?` | no | _min=0_ |
| `analyticsItem` | `bool?` | no | — |
| `country` | `bool?` | no | — |
| `requestComplete` | `bool?` | no | — |
| `operationSystem` | `bool?` | no | — |
| `databaseSystem` | `bool?` | no | — |
| `logDatabaseSystem` | `bool?` | no | — |
| `cost` | `bool?` | no | — |
| `monthlyCost` | `bool?` | no | — |

### GetUsernameAdminAccountRequestData

Defines the request payload for GetUsernameAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

### GetEventCallbackCloudScriptRequestData

Defines the request payload for GetEventCallbackCloudScript.

_Không có field public (payload rỗng)._

### SetEventCallbackCloudScriptRequestData

Defines the request payload for SetEventCallbackCloudScript.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `eventName` | `string` | yes | _minLength=6, maxLength=128_ |
| `script` | `string` | yes | _minLength=6, maxLength=Number.MAX_SAFE_INTEGER_ |

### ResetStatisticsLeaderboardRequestData

Defines the request payload for ResetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | — |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `version` | `string` | yes | _minLength=2, maxLength=32_ |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |
| `catalogId` | `string?` | no | _minLength=2, maxLength=32_ |

### DeleteInDatabaseRequestData

Defines the request payload for DeleteInDatabase.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `int` | yes | — |
| `id` | `string` | yes | _minLength=2, maxLength=32_ |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### GetBackupStatisticsLeaderboardVersionRequestData

Defines the request payload for GetBackupStatisticsLeaderboardVersion.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |
| `type` | `int` | yes | — |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### GetServerGameDataRequestData

Defines the request payload for GetServerGameData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | _minLength=2, maxLength=32_ |
| `masterPlayerCount` | `bool?` | no | — |
| `gamePlayerCount` | `bool?` | no | — |
| `characterPlayerCount` | `bool?` | no | — |
| `inventoryCount` | `bool?` | no | — |
| `storeInventoryCount` | `bool?` | no | — |
| `groupCount` | `bool?` | no | — |
| `country` | `bool?` | no | — |
| `version` | `bool?` | no | — |

### AdminAccountResponseData

Defines the response payload for AdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | — |
| `username` | `string` | yes | — |
| `secretKey` | `string` | yes | — |

### GetAdminAccountListResponseData

Defines the response payload for GetAdminAccountList.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<AdminAccountResponseData>` | yes | _elementCls=AdminAccountResponseData_ |

Reference links:

- [DashboardModels.AdminAccountResponseData:1275-1285](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#adminaccountresponsedata)

### GetGameInformationResponseData

Defines the response payload for GetGameInformation.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | — |
| `tsCreate` | `long` | yes | — |
| `creatorId` | `string` | yes | — |
| `gameDescription` | `string` | yes | — |
| `gameIconUrl` | `string` | yes | — |
| `gameSettings` | `GameSettingsParam` | yes | — |
| `matchmakingQueueSettings` | `List<MatchmakingQueueSettingsParam>` | yes | _elementCls=MatchmakingQueueSettingsParam_ |

Reference links:

- [DashboardModels.GameSettingsParam:459-477](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#gamesettingsparam)
- [DashboardModels.MatchmakingQueueSettingsParam:860-881](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#matchmakingqueuesettingsparam)

### GameWithGameIdResponseData

Defines the response payload for GameWithGameId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `gameId` | `string` | yes | — |

### GetGameListResponseData

Defines the response payload for GetGameList.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GameWithGameIdResponseData>` | yes | _elementCls=GameWithGameIdResponseData_ |

Reference links:

- [DashboardModels.GameWithGameIdResponseData:1319-1327](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#gamewithgameidresponsedata)

### GetMasterGameSettingsResponseData

Defines the response payload for `getMasterGameSettings`. This payload contains the full top-level dashboard configuration snapshot used to provision a game.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `thirtPartySettings` | `ThirtPartyParam` | yes | — |
| `masterPlayerSettings` | `MasterPlayerSettingsParam` | yes | — |
| `emailSettings` | `EmailSettingsParam` | yes | — |
| `pushNotificationSettings` | `PushNotificationSettingsParam` | yes | — |

Reference links:

- [DashboardModels.ThirtPartyParam:282-302](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#thirtpartyparam)
- [DashboardModels.MasterPlayerSettingsParam:743-764](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#masterplayersettingsparam)
- [DashboardModels.EmailSettingsParam:303-316](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#emailsettingsparam)
- [DashboardModels.PushNotificationSettingsParam:317-327](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#pushnotificationsettingsparam)

### GetSecretInfoInformationResponseData

Defines the response payload for `getSecretInfoInformation`. This is the detailed secret-info record, including role, lifecycle flags, and permission tree.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKey` | `string` | yes | Secret key whose detailed configuration was requested. |
| `gameId` | `string` | yes | — |
| `tsCreate` | `long` | yes | — |
| `creatorId` | `string` | yes | — |
| `remove` | `bool` | yes | — |
| `tsExpire` | `long` | yes | — |
| `description` | `string` | yes | — |
| `permissionParam` | `PermissionParam` | yes | Permission tree granted to this secret key. |

Reference links:

- [DashboardModels.PermissionParam:955-987](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#permissionparam)

### SecretInfoWithSecretKeyResponseData

Defines a lightweight secret-info item returned by secret-list queries.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKey` | `string` | yes | — |

### GetSecretInfoListResponseData

Defines the response payload for `getSecretInfoList`. Results are grouped by secret role instead of being returned as one flat array.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `secretKeys` | `List<SecretInfoWithSecretKeyResponseData>` | yes | Secret keys. — _elementCls=SecretInfoWithSecretKeyResponseData_ |

Reference links:

- [DashboardModels.SecretInfoWithSecretKeyResponseData:1380-1388](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#secretinfowithsecretkeyresponsedata)

### AdminAccountWithUserIdResponseData

Defines the response payload for AdminAccountWithUserId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | — |

### CreateAdminAccountResponseData

Defines the response payload for CreateAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<AdminAccountWithUserIdResponseData>` | yes | _elementCls=AdminAccountWithUserIdResponseData_ |

Reference links:

- [DashboardModels.AdminAccountWithUserIdResponseData:1402-1410](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#adminaccountwithuseridresponsedata)

### LoginByAdminAccountResponseData

Defines the response payload for `loginByAdminAccount`. The returned auth token should be cached and reused for subsequent dashboard requests.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `authToken` | `string` | yes | Auth token representing the authenticated admin account. |

### GetServerLogResponseData

Defines the response payload for GetServerLog.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<string>` | yes | _elementCls=String_ |

### CountryRegionResponseData

Defines the response payload for CountryRegion.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `regionCode` | `string` | yes | — |
| `regionName` | `string` | yes | — |
| `ccu` | `int` | yes | — |
| `latitude` | `double?` | no | _default=0_ |
| `longitude` | `double?` | no | _default=0_ |

### CountryResponseData

Defines the response payload for Country.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `countryCode` | `string` | yes | — |
| `regions` | `List<CountryRegionResponseData>` | yes | _elementCls=CountryRegionResponseData_ |

Reference links:

- [DashboardModels.CountryRegionResponseData:1442-1454](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#countryregionresponsedata)

### AnalyticsItemResponseData

Defines the response payload for AnalyticsItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ccu` | `int` | yes | — |
| `dau` | `int` | yes | — |
| `dauSince0h` | `int` | yes | — |
| `dnu` | `int` | yes | — |
| `dnuSince0h` | `int` | yes | — |
| `drt` | `int` | yes | — |
| `drtSince0h` | `int` | yes | — |
| `mau` | `int` | yes | — |
| `mauSince0h1` | `int` | yes | — |
| `mnu` | `int` | yes | — |
| `mnuSince0h1` | `int` | yes | — |
| `mrt` | `int` | yes | — |
| `mrtSince0h1` | `int` | yes | — |
| `analyticsPrice` | `double` | yes | — |

### MemoryUsageResponseData

Defines the response payload for MemoryUsage.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `freeMemoryInBytes` | `double` | yes | — |
| `totalMemoryInBytes` | `double` | yes | — |

### StorageUsageResponseData

Defines the response payload for StorageUsage.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `name` | `string` | yes | — |
| `fsTotalSizeInBytes` | `double` | yes | — |
| `fsUsedSizeInBytes` | `double` | yes | — |

### DatabaseSystemResponseData

Defines the response payload for DatabaseSystem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `fsTotalSizeInBytes` | `double` | yes | — |
| `fsUsedSizeInBytes` | `double` | yes | — |
| `totalSizeInBytes` | `double` | yes | — |
| `collections` | `int` | yes | — |
| `objects` | `int` | yes | — |
| `indexes` | `int` | yes | — |

### OperationSystemResponseData

Defines the response payload for OperationSystem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `cpuUsage` | `double` | yes | — |
| `memoryUsage` | `MemoryUsageResponseData` | yes | — |
| `storageUsage` | `List<StorageUsageResponseData>?` | no | _elementCls=StorageUsageResponseData_ |

Reference links:

- [DashboardModels.MemoryUsageResponseData:1491-1500](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#memoryusageresponsedata)
- [DashboardModels.StorageUsageResponseData:1501-1511](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#storageusageresponsedata)

### RequestCompleteErrorCodeResponseData

Defines the response payload for RequestCompleteErrorCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorCode` | `int` | yes | — |
| `count` | `int` | yes | — |

### RequestCompleteResponseData

Defines the response payload for RequestComplete.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `eventName` | `string` | yes | — |
| `results` | `List<RequestCompleteErrorCodeResponseData>?` | no | _elementCls=RequestCompleteErrorCodeResponseData_ |

Reference links:

- [DashboardModels.RequestCompleteErrorCodeResponseData:1542-1551](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#requestcompleteerrorcoderesponsedata)

### CostResponseData

Defines the response payload for Cost.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `requestCount` | `int` | yes | — |
| `matchmakingRequestCount` | `int` | yes | — |
| `cloudScriptGBs` | `double` | yes | — |
| `storageSizeInBytes` | `double` | yes | — |
| `dataTransferSizeInBytes` | `long` | yes | — |

### GetAnalyticsResponseData

Defines the response payload for GetAnalytics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `analyticsItem` | `AnalyticsItemResponseData?` | no | — |
| `country` | `List<CountryResponseData>?` | no | _elementCls=CountryResponseData_ |
| `operationSystem` | `OperationSystemResponseData?` | no | — |
| `requestComplete` | `List<RequestCompleteResponseData>?` | no | _elementCls=RequestCompleteResponseData_ |
| `databaseSystem` | `DatabaseSystemResponseData?` | no | — |
| `logDatabaseSystem` | `DatabaseSystemResponseData?` | no | — |
| `cost` | `CostResponseData?` | no | — |
| `monthlyCost` | `CostResponseData?` | no | — |

Reference links:

- [DashboardModels.AnalyticsItemResponseData:1469-1490](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#analyticsitemresponsedata)
- [DashboardModels.CountryResponseData:1455-1468](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#countryresponsedata)
- [DashboardModels.OperationSystemResponseData:1526-1541](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#operationsystemresponsedata)
- [DashboardModels.RequestCompleteResponseData:1552-1565](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#requestcompleteresponsedata)
- [DashboardModels.DatabaseSystemResponseData:1512-1525](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#databasesystemresponsedata)
- [DashboardModels.CostResponseData:1566-1578](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#costresponsedata)

### GetUsernameAdminAccountResponseData

Defines the response payload for GetUsernameAdminAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string` | yes | — |

### ChildScriptResponseData

Defines the response payload for ChildScript.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `eventName` | `string` | yes | — |
| `script` | `string` | yes | — |
| `hasEdit` | `bool` | yes | — |

### EventCallbackCloudScriptResponseData

Defines the response payload for EventCallbackCloudScript.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `type` | `string` | yes | — |
| `tsCreate` | `long` | yes | — |
| `version` | `string` | yes | — |
| `childScripts` | `List<ChildScriptResponseData>` | yes | _elementCls=ChildScriptResponseData_ |

Reference links:

- [DashboardModels.ChildScriptResponseData:1613-1623](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#childscriptresponsedata)

### GetEventCallbackCloudScriptResponseData

Defines the response payload for `getEventCallbackCloudScript`. Each result links one event callback registration to a CloudScript target.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<EventCallbackCloudScriptResponseData>` | yes | _elementCls=EventCallbackCloudScriptResponseData_ |

Reference links:

- [DashboardModels.EventCallbackCloudScriptResponseData:1624-1639](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#eventcallbackcloudscriptresponsedata)

### SetEventCallbackCloudScriptResponseData

Defines the response payload for SetEventCallbackCloudScript.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string` | yes | — |

### BackupStatisticsLeaderboardVersionResponseData

Defines the response payload for BackupStatisticsLeaderboardVersion.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `version` | `string` | yes | — |
| `log` | `string` | yes | — |
| `tsCreate` | `long` | yes | — |

### GetBackupStatisticsLeaderboardVersionResponseData

Defines the response payload for GetBackupStatisticsLeaderboardVersion.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<BackupStatisticsLeaderboardVersionResponseData>` | yes | _elementCls=BackupStatisticsLeaderboardVersionResponseData_ |

Reference links:

- [DashboardModels.BackupStatisticsLeaderboardVersionResponseData:1662-1672](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#backupstatisticsleaderboardversionresponsedata)

### GetServerGameDataResponseData

Defines the response payload for `getServerGameData`. This is a high-level telemetry snapshot of entity counts, country breakdown, and server version data.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `masterPlayerCount` | `int?` | no | — |
| `gamePlayerCount` | `int?` | no | — |
| `characterPlayerCount` | `int?` | no | — |
| `inventoryCount` | `int?` | no | — |
| `storeInventoryCount` | `int?` | no | — |
| `groupCount` | `int?` | no | — |
| `country` | `List<CountryResponseData>?` | no | Optional country-level breakdown returned by the backend. — _elementCls=CountryResponseData_ |
| `version` | `string?` | no | Optional server or game-data version string reported by the backend. |

Reference links:

- [DashboardModels.CountryResponseData:1455-1468](/docs/reference/dto/dashboard/DASHBOARD_MODELS.md#countryresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
