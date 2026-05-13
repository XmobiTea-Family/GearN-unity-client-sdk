# Reference: Enums

Toàn bộ enum public của Unity SDK. Mỗi bảng liệt kê tên, giá trị numeric thật, và ý nghĩa business.

**Rule cứng cho AI consumer:**

- So sánh giá trị bằng chính symbol của enum (`ReturnCode.Ok`), không hardcode số.
- Không giả định success là `0`. Success ở cả 2 tầng là `1` (`ReturnCode.Ok == 1`, `ErrorCode.Ok == 1`).
- Nếu backend trả về giá trị không có trong bảng này, xử lý như unknown và log lại; không suy diễn.

## Mục lục

- [ReturnCode](#returncode) — transport/gateway
- [ErrorCode](#errorcode) — business domain
- [RequestRole](#requestrole)
- [RequestType](#requesttype)
- [MessageType](#messagetype)
- [PostType](#posttype)
- [LogType](#logtype)
- [FriendStatus](#friendstatus)
- [GroupStatus](#groupstatus)
- [GoogleLoginType](#googlelogintype)
- [InvalidMemberType](#invalidmembertype)
- [ItemType](#itemtype)
- [OwnerType](#ownertype)
- [PushPlatformType](#pushplatformtype)
- [MatchmakingMemberStatus](#matchmakingmemberstatus)
- [MatchmakingTicketStatus](#matchmakingticketstatus)
- [MatchStatus](#matchstatus)
- [ExecuteResponseStatus](#executeresponsestatus)
- [StoreItemType](#storeitemtype)
- [StoreReceiveType](#storereceivetype)
- [PermissionDataItem](#permissiondataitem)
- [FieldDataType](#fielddatatype)

---

## ReturnCode

Transport/gateway return code. **Truy cập bằng field public `res.returnCode`** trên typed response (`*Async()` và callback form). Getter `OperationResponse.getReturnCode()` chỉ dùng khi xử lý raw `OperationResponse` (custom op). **Luôn kiểm tra trước `errorCode`.**

C# namespace: `XmobiTea.GearN.Constant.ReturnCode` - các member là hằng số public.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `SecretInvalid` | -10 | Secret key sai / thiếu / không khớp route hoặc game context |
| `MaxSizeRequestReject` | -9 | Payload vượt size tối đa backend chấp nhận |
| `MaxRequestReject` | -8 | Caller vượt rate limit |
| `MaxCCUReject` | -7 | Vượt giới hạn concurrent user/session |
| `OperationNotAuthorized` | -6 | Operation tồn tại nhưng caller không đủ quyền với role/target |
| `InvalidRequestParameters` | -5 | Request shape hoặc field invalid; inspect `invalidMembers` |
| `OperationInvalid` | -4 | Operation code không tồn tại hoặc không hợp lệ với request type/role |
| `InternalServerError` | -3 | Backend lỗi unhandled trước khi produce valid business response |
| `OperationNotAllow` | -2 | Operation tồn tại + secret hợp lệ, nhưng permission rule không cho chạy ở target context |
| `OperationTimeout` | -1 | Request timeout; có thể do SDK timeout layer hoặc backend |
| `UnknownError` | 0 | Request fail, không có mapped return code cụ thể |
| `Ok` | 1 | Protocol-level thành công; vẫn phải check `errorCode` trong response |

Xem thêm: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

---

## ErrorCode

Business domain error code, nằm trong response payload khi `returnCode == ReturnCode.Ok`. Chỉ trust khi đã pass tầng `ReturnCode`.

C# namespace: `XmobiTea.GearN.Constant.ErrorCode` - các member là hằng số public.

<!-- prettier-ignore -->
| Name | Value | Meaning | Typical context |
| --- | --- | --- | --- |
| `Ok` | 1 | Business operation thành công | mọi response happy path |
| `AccountNotFound` | 2 | Username/account không tồn tại | login flows |
| `AccountPasswordWrong` | 3 | Password sai | login by account |
| `AccountUsernameExists` | 4 | Username đã tồn tại | register |
| `VerifyTokenError` | 5 | Token không verify/decode được | refresh token, social login |
| `VerifyFailed` | 6 | External/provider verification fail | social login, receipt |
| `CharacterPlayerNotFound` | 7 | Character player không tồn tại | character APIs |
| `NotEnoughCurrency` | 8 | Wallet/owner thiếu currency | store purchase, transfer |
| `KeyNotFound` | 9 | Key không tồn tại trong target data set | data/profile get |
| `ItemNotFound` | 10 | Inventory item không tồn tại | inventory APIs |
| `CatalogIdNotFound` | 11 | Catalog id không tồn tại | content/store |
| `GroupNotFound` | 12 | Group không tồn tại | group APIs |
| `OwnerNotFound` | 13 | Owner entity không tồn tại | cross-domain writes |
| `ClassIdNotFound` | 14 | Class id không tồn tại | content config |
| `MemberNotFound` | 15 | Group member / relation member không tồn tại | group / friend APIs |
| `PlayerNotMember` | 16 | Player không phải member của group | group write APIs |
| `GamePlayerNotFound` | 17 | Game player không tồn tại | game player APIs |
| `FileNotFound` | 18 | File metadata hoặc physical file không tồn tại | content APIs |
| `FileNotUpload` | 19 | File metadata tồn tại nhưng content chưa upload | content APIs |
| `OwnerTypeNotSupport` | 20 | Owner type không support cho operation | cross-domain writes |
| `ItemNotStackable` | 21 | Item không stackable, thao tác amount invalid | inventory APIs |
| `GameNotFound` | 22 | Game không tồn tại | dashboard APIs |
| `GameExists` | 23 | Game đã tồn tại (không tạo lại được) | dashboard create game |
| `SecretInfoNotFound` | 24 | Secret-info record không tồn tại | dashboard secret mgmt |
| `SecretInfoExists` | 25 | Secret-info record đã tồn tại | dashboard secret mgmt |
| `ExternalNotLinked` | 26 | External identity chưa link account hiện tại | external identity unlink |
| `ExternalLinkedOtherAccount` | 27 | External identity đã link account khác | external identity link |
| `ExternalLinkedOtherValue` | 28 | External provider/value pair conflict giá trị đã link | external identity link |
| `MasterPlayerNotFound` | 29 | Master player không tồn tại | master player APIs |
| `StoreItemNotFound` | 30 | Store item không tồn tại | store APIs |
| `BuyerNotFound` | 31 | Buyer entity không tồn tại | store buy/present |
| `CanNotBuyThisStoreItem` | 32 | Store item không mua được ở state/buyer hiện tại | store buy |
| `ExceptionWhenValidateReceipt` | 33 | Exception khi validate receipt | store receipt validate |
| `StoreInvalid` | 34 | Store/provider config invalid | store receipt validate |
| `ReceiptInvalid` | 35 | Receipt invalid | store receipt validate |
| `StoreItemRemoved` | 36 | Store item đã removed, không dùng purchase flow nữa | store APIs |
| `DisplayNameUsed` | 37 | Display name đã có người dùng | player profile update |
| `PlayerBan` | 38 | Player hiện bị ban | login / gameplay |
| `MatchmakingTicketNotFound` | 39 | Matchmaking ticket không tồn tại | multiplayer APIs |
| `MatchmakingTicketAlreadyCompleted` | 40 | Ticket đã completed, không modify được | multiplayer APIs |
| `MatchmakingPlayerNotJoinedTicket` | 41 | Player không phải member của ticket | multiplayer APIs |
| `MatchNotFound` | 42 | Match không tồn tại | multiplayer query match |
| `MatchmakingPlayerJoinedOtherTicket` | 43 | Player đã join ticket khác (conflict) | multiplayer create ticket |
| `MatchmakingQueueNotFound` | 44 | Matchmaking queue không tồn tại | multiplayer APIs |
| `TicketSizeError` | 45 | Ticket size vi phạm queue config | multiplayer create ticket |
| `ExecuteError` | 46 | CloudScript function fail khi execute | cloudscript execute |
| `VersionInvalid` | 47 | CloudScript version invalid/unavailable | cloudscript APIs |
| `EmailInvalid` | 48 | Email sai format/semantically invalid | register, profile update |
| `StoreItemPurchasedAndNonConsumable` | 49 | Buyer đã own non-consumable này rồi | store buy |
| `StoreItemExists` | 50 | Store item đã tồn tại (không tạo lại được) | dashboard store mgmt |

Xem thêm: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).

---

## RequestRole

Trust boundary của caller. Chọn route theo caller thật (client app / trusted backend / admin tool), không theo mối quan hệ với target.

```csharp
public enum RequestRole {
    Admin = 1,
    Server = 2,
    Client = 3,
}
```

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Admin` | 1 | Admin tool / backoffice / GM tool / migration tool |
| `Server` | 2 | Trusted backend: game server, internal service, worker, cron, webhook |
| `Client` | 3 | Player app / client code |

---

## RequestType

Top-level domain phân loại route khi build transport path.

```csharp
public enum RequestType {
    Custom = 0,
    Authenticate = 1,
    CharacterPlayer = 2,
    Content = 3,
    GamePlayer = 4,
    Group = 5,
    Inventory = 6,
    MasterPlayer = 7,
    StoreInventory = 8,
    Dashboard = 9,
    Multiplayer = 10,
    CloudScript = 11,
}
```

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Custom` | 0 | Custom operation ngoài các domain tiêu chuẩn |
| `Authenticate` | 1 | Login, register, token management |
| `CharacterPlayer` | 2 | Character-player profile và data |
| `Content` | 3 | Content data và file upload/download |
| `GamePlayer` | 4 | Game-player profile và data |
| `Group` | 5 | Group lifecycle, member, message |
| `Inventory` | 6 | Inventory item management |
| `MasterPlayer` | 7 | Master-player account và external identity |
| `StoreInventory` | 8 | Store item, purchase, receipt validation |
| `Dashboard` | 9 | Game settings và admin configuration |
| `Multiplayer` | 10 | Matchmaking ticket và match lifecycle |
| `CloudScript` | 11 | CloudScript function management và execute |

---

## MessageType

Payload encoding preferred bởi transport.

```csharp
public enum MessageType {
    Json = 1,
    MsgPack = 2,
}
```

<!-- prettier-ignore -->
| Name | Value | Notes |
| --- | --- | --- |
| `Json` | 1 | JSON payload |
| `MsgPack` | 2 | Compact binary khi transport/server hỗ trợ |

---

## PostType

Low-level HTTP body encoding dùng bởi `HttpPeer`. App tích hợp thông thường không cần truyền trực tiếp enum này.

<!-- prettier-ignore -->
| Name | Value | Notes |
| --- | --- | --- |
| `Json` | 0 | UTF-8 JSON request/response body |
| `MsgPack` | 1 | Binary MessagePack request/response body |

---

## LogType

Verbosity cho `GNDebug`.

```csharp
public enum LogType {
    Off = 0,
    Exception = 1,
    Error = 2,
    Warning = 3,
    All = 4,
}
```

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Off` | 0 | Tắt hoàn toàn mọi output từ `GNDebug` |
| `Exception` | 1 | Chỉ log unhandled exception |
| `Error` | 2 | Exception + runtime error |
| `Warning` | 3 | Error + cảnh báo potential issue |
| `All` | 4 | Log toàn bộ bao gồm info/debug verbose |

---

## FriendStatus

Lifecycle state của quan hệ bạn bè.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Friend` | 1 | Đã là bạn |
| `WaitingAccept` | 2 | Đang chờ mình accept incoming request |
| `SentRequestAndWaitingAccept` | 3 | Mình đã gửi request, chờ bên kia accept |
| `NotFriend` | 4 | Không có quan hệ bạn bè |

---

## GroupStatus

Lifecycle state của quan hệ group membership.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Member` | 1 | Đã là member active |
| `WaitingAccept` | 2 | Đang chờ group accept join request từ bên mình |
| `SentRequestAndWaitingAccept` | 3 | Đã gửi join request, chờ group approve |
| `NotMember` | 4 | Chưa là member |

---

## GoogleLoginType

Loại credential Google được cung cấp cho login/link flow.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `AccessToken` | 1 | OAuth access token |
| `IdToken` | 2 | OpenID Connect ID token |

---

## InvalidMemberType

Category lỗi validation expose qua `res.invalidMembers`. Chỉ xuất hiện khi `res.returnCode == ReturnCode.InvalidRequestParameters`.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `UnknownError` | 1 | Không map được category cụ thể |
| `DataRequired` | 2 | Field required nhưng thiếu |
| `TypeInvalid` | 3 | Runtime type không match expected |
| `StringNull` | 4 | Required string null/empty |
| `StringMinLength` | 5 | String ngắn hơn min length |
| `StringMaxLength` | 6 | String dài hơn max length |
| `NumberMinValue` | 7 | Number thấp hơn min value |
| `NumberMaxValue` | 8 | Number cao hơn max value |
| `NumberMustInt` | 9 | Number phải integer nhưng nhận non-integer |
| `GNHashtableNull` | 10 | `GNHashtable` required null |
| `GNHashtableMinLength` | 11 | `GNHashtable` ít entry hơn min |
| `GNHashtableMaxLength` | 12 | `GNHashtable` nhiều entry hơn max |
| `GNArrayNull` | 13 | `GNArray` required null |
| `GNArrayMinLength` | 14 | `GNArray` ít item hơn min |
| `GNArrayMaxLength` | 15 | `GNArray` nhiều item hơn max |

---

## ItemType

Kiểu inventory item hỗ trợ stacking hay không.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `NonStackable` | 1 | Mỗi instance unique, track riêng |
| `Stackable` | 2 | Nhiều unit gộp chung amount |

---

## OwnerType

Top-level entity owner của resource.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `MasterPlayer` | 1 | Master-player account |
| `GamePlayer` | 2 | Game-player entity |
| `CharacterPlayer` | 3 | Character-player entity |
| `Group` | 4 | Group entity |
| `Inventory` | 5 | Inventory item khác |
| `StoreInventory` | 6 | Store-inventory entity |

---

## PushPlatformType

Mobile push platform.

<!-- prettier-ignore -->
| Name | Value |
| --- | --- |
| `Android` | 1 |
| `iOS` | 2 |

---

## MatchmakingMemberStatus

State của 1 member trong matchmaking ticket.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Pending` | 1 | Declared nhưng chưa join/confirm |
| `Joined` | 2 | Đã join ticket |
| `Canceled` | 3 | Hủy tham gia ticket |

---

## MatchmakingTicketStatus

Lifecycle state của matchmaking ticket.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `WaitingForMembers` | 1 | Chờ tất cả member declared join |
| `WaitingForMatch` | 2 | Đủ member, chờ matchmaking engine tìm match |
| `WaitingForServer` | 3 | Đã có match, chờ server allocation |
| `Matched` | 4 | Complete → pointer sang match |
| `Canceled` | 5 | Ticket bị hủy, không produce match |

---

## MatchStatus

Lifecycle state của match record sau khi matchmaking tạo match.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `WaitingForServer` | 1 | Match đã tạo nhưng server allocation chưa sẵn sàng |
| `Matched` | 2 | Server đã sẵn sàng; app có thể tiếp tục flow connect theo backend contract |
| `Canceled` | 3 | Match bị hủy trước khi hoàn tất |

---

## ExecuteResponseStatus

Status CloudScript execute function.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Ok` | 1 | Execute thành công |
| `Exception` | 2 | Execute nhưng function throw exception |
| `FunctionNameNotFound` | 3 | Function name không tồn tại trong version |
| `VersionInvalid` | 4 | Version invalid/không execute được |
| `Timeout` | 5 | Function vượt thời gian cho phép |

---

## StoreItemType

Kiểu store item: mua 1 lần hay nhiều lần.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `NonConsumable` | 1 | Chỉ own 1 bản persistent |
| `Consumable` | 2 | Mua lại và tiêu thụ nhiều lần |

---

## StoreReceiveType

Cách store item được trao cho buyer.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Buy` | 1 | Buy flow trong game bình thường |
| `Present` | 2 | Present/gift flow |
| `AppleAppStore` | 3 | Apple App Store receipt validation |
| `FacebookStore` | 4 | Facebook Store receipt validation |
| `GooglePlayStore` | 5 | Google Play receipt validation |

---

## PermissionDataItem

Cách config 1 data item có thể ghi lại sau khi tạo.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `ReadOnly` | 1 | Read được nhưng write flow thường không ghi đè |
| `CanOverride` | 2 | Write được, ghi đè giá trị cũ |

---

## FieldDataType

Runtime metadata type ghi nhận bởi metadata `DataMember`. App tích hợp SDK bình thường hiếm khi cần đọc trực tiếp enum này.

<!-- prettier-ignore -->
| Name | Value | Meaning |
| --- | --- | --- |
| `Boolean` | 0 | Field boolean |
| `Number` | 1 | Field number |
| `String` | 2 | Field string |
| `Array` | 3 | Field array |
| `Object` | 4 | Field class/object |
