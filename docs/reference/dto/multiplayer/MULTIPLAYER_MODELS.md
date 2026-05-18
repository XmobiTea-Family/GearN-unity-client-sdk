### CancelAllMatchmakingTicketRequestData

Defines the request payload for CancelAllMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerCancelAllMatchmakingTicketRequestData

Extends: `CancelAllMatchmakingTicketRequestData`

Defines the request payload for ServerCancelAllMatchmakingTicket.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CancelAllMatchmakingTicketRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

Reference links:

- [MultiplayerModels.CancelAllMatchmakingTicketRequestData:1-9](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#cancelallmatchmakingticketrequestdata)

### AdminCancelAllMatchmakingTicketRequestData

Extends: `ServerCancelAllMatchmakingTicketRequestData`

Defines the request payload for AdminCancelAllMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCancelAllMatchmakingTicketRequestData` (bao gồm `userId` required)._

Reference links:

- [MultiplayerModels.ServerCancelAllMatchmakingTicketRequestData:1-26](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servercancelallmatchmakingticketrequestdata)

### CancelMatchmakingTicketRequestData

Defines the request payload for CancelMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerCancelMatchmakingTicketRequestData

Extends: `CancelMatchmakingTicketRequestData`

Defines the request payload for ServerCancelMatchmakingTicket.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CancelMatchmakingTicketRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

Reference links:

- [MultiplayerModels.CancelMatchmakingTicketRequestData:39-47](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#cancelmatchmakingticketrequestdata)

### AdminCancelMatchmakingTicketRequestData

Extends: `ServerCancelMatchmakingTicketRequestData`

Defines the request payload for AdminCancelMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCancelMatchmakingTicketRequestData` (bao gồm `userId` required)._

Reference links:

- [MultiplayerModels.ServerCancelMatchmakingTicketRequestData:39-64](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servercancelmatchmakingticketrequestdata)

### CreateMatchmakingTicketRequestData

Creates a new matchmaking ticket for the current or target player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `giveUpAfterSeconds` | `int` | yes | Maximum wait time before the ticket gives up. — _min=20_ |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |
| `attribute` | `GNHashtable?` | no | Backend-defined matchmaking attribute payload. |
| `members` | `List<string>?` | no | Optional extra members joined into the same matchmaking party. — _elementCls=String_ |

### ServerCreateMatchmakingTicketRequestData

Extends: `CreateMatchmakingTicketRequestData`

Defines the request payload for ServerCreateMatchmakingTicket.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `CreateMatchmakingTicketRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

Reference links:

- [MultiplayerModels.CreateMatchmakingTicketRequestData:77-88](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#creatematchmakingticketrequestdata)

### AdminCreateMatchmakingTicketRequestData

Extends: `ServerCreateMatchmakingTicketRequestData`

Defines the request payload for AdminCreateMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerCreateMatchmakingTicketRequestData` (bao gồm `userId` required)._

Reference links:

- [MultiplayerModels.ServerCreateMatchmakingTicketRequestData:77-105](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servercreatematchmakingticketrequestdata)

### GetMatchmakingTicketRequestData

Polls the current state of one matchmaking ticket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketId` | `string` | yes | _minLength=10, maxLength=10_ |
| `returnMember` | `bool?` | no | Requests member details in addition to the ticket summary. — _default=false_ |

### ServerGetMatchmakingTicketRequestData

Extends: `GetMatchmakingTicketRequestData`

Defines the request payload for ServerGetMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetMatchmakingTicketRequestData`._

Reference links:

- [MultiplayerModels.GetMatchmakingTicketRequestData:118-127](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchmakingticketrequestdata)

### AdminGetMatchmakingTicketRequestData

Extends: `ServerGetMatchmakingTicketRequestData`

Defines the request payload for AdminGetMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetMatchmakingTicketRequestData`._

Reference links:

- [MultiplayerModels.ServerGetMatchmakingTicketRequestData:118-139](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servergetmatchmakingticketrequestdata)

### GetMatchRequestData

Reads a match after matchmaking has produced a `matchId`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `matchId` | `string` | yes | _minLength=15, maxLength=15_ |
| `returnMember` | `bool?` | no | Requests member details in addition to the match summary. — _default=false_ |

### ServerGetMatchRequestData

Extends: `GetMatchRequestData`

Defines the request payload for ServerGetMatch.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetMatchRequestData`._

Reference links:

- [MultiplayerModels.GetMatchRequestData:152-161](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchrequestdata)

### AdminGetMatchRequestData

Extends: `ServerGetMatchRequestData`

Defines the request payload for AdminGetMatch.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetMatchRequestData`._

Reference links:

- [MultiplayerModels.ServerGetMatchRequestData:152-173](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servergetmatchrequestdata)

### GetAllMatchRequestData

Defines the request payload for GetAllMatch.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `returnMember` | `bool?` | no | _default=false_ |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetAllMatchRequestData

Extends: `GetAllMatchRequestData`

Defines the request payload for ServerGetAllMatch.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAllMatchRequestData`._

Reference links:

- [MultiplayerModels.GetAllMatchRequestData:186-196](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getallmatchrequestdata)

### AdminGetAllMatchRequestData

Extends: `ServerGetAllMatchRequestData`

Defines the request payload for AdminGetAllMatch.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAllMatchRequestData`._

Reference links:

- [MultiplayerModels.ServerGetAllMatchRequestData:186-208](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servergetallmatchrequestdata)

### GetAllMatchmakingTicketRequestData

Lists matchmaking tickets with optional status filtering.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `status` | `int?` | no | Ticket status filter mapped by the public `MatchmakingTicketStatus` enum. — _min=1, max=5_ |
| `returnMember` | `bool?` | no | _default=false_ |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetAllMatchmakingTicketRequestData

Extends: `GetAllMatchmakingTicketRequestData`

Defines the request payload for ServerGetAllMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetAllMatchmakingTicketRequestData`._

Reference links:

- [MultiplayerModels.GetAllMatchmakingTicketRequestData:221-232](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getallmatchmakingticketrequestdata)

### AdminGetAllMatchmakingTicketRequestData

Extends: `ServerGetAllMatchmakingTicketRequestData`

Defines the request payload for AdminGetAllMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetAllMatchmakingTicketRequestData`._

Reference links:

- [MultiplayerModels.ServerGetAllMatchmakingTicketRequestData:221-244](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servergetallmatchmakingticketrequestdata)

### GetQueueStatisticsRequestData

Defines the request payload for GetQueueStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |
| `timeInSeconds` | `int` | yes | _min=20_ |

### ServerGetQueueStatisticsRequestData

Extends: `GetQueueStatisticsRequestData`

Defines the request payload for ServerGetQueueStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `GetQueueStatisticsRequestData`._

Reference links:

- [MultiplayerModels.GetQueueStatisticsRequestData:257-266](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getqueuestatisticsrequestdata)

### AdminGetQueueStatisticsRequestData

Extends: `ServerGetQueueStatisticsRequestData`

Defines the request payload for AdminGetQueueStatistics.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerGetQueueStatisticsRequestData`._

Reference links:

- [MultiplayerModels.ServerGetQueueStatisticsRequestData:257-278](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servergetqueuestatisticsrequestdata)

### JoinMatchmakingTicketRequestData

Defines the request payload for JoinMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketId` | `string` | yes | _minLength=10, maxLength=10_ |
| `attribute` | `GNHashtable?` | no | Matchmaking attributes for the joining member (e.g. skill rating, region). |

### ServerJoinMatchmakingTicketRequestData

Extends: `JoinMatchmakingTicketRequestData`

Defines the request payload for ServerJoinMatchmakingTicket.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `JoinMatchmakingTicketRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

Reference links:

- [MultiplayerModels.JoinMatchmakingTicketRequestData:291-300](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#joinmatchmakingticketrequestdata)

### AdminJoinMatchmakingTicketRequestData

Extends: `ServerJoinMatchmakingTicketRequestData`

Defines the request payload for AdminJoinMatchmakingTicket.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerJoinMatchmakingTicketRequestData` (bao gồm `userId` required)._

Reference links:

- [MultiplayerModels.ServerJoinMatchmakingTicketRequestData:291-317](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#serverjoinmatchmakingticketrequestdata)

### ListMatchmakingTicketsForPlayerRequestData

Lists ticket IDs for the current or target player within one queue.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerListMatchmakingTicketsForPlayerRequestData

Extends: `ListMatchmakingTicketsForPlayerRequestData`

Defines the request payload for ServerListMatchmakingTicketsForPlayer.

_Khai báo lại field `userId` để đổi Required từ `no` sang `yes`; các field còn lại kế thừa từ `ListMatchmakingTicketsForPlayerRequestData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

Reference links:

- [MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData:330-338](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#listmatchmakingticketsforplayerrequestdata)

### AdminListMatchmakingTicketsForPlayerRequestData

Extends: `ServerListMatchmakingTicketsForPlayerRequestData`

Defines the request payload for AdminListMatchmakingTicketsForPlayer.

_Không khai báo field mới; kế thừa toàn bộ field từ `ServerListMatchmakingTicketsForPlayerRequestData` (bao gồm `userId` required)._

Reference links:

- [MultiplayerModels.ServerListMatchmakingTicketsForPlayerRequestData:330-355](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#serverlistmatchmakingticketsforplayerrequestdata)

### CancelAllMatchmakingTicketResponseData

Defines the response payload for CancelAllMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketIds` | `List<string>` | yes | _elementCls=String_ |

### CreateMatchmakingTicketResponseData

Defines the response payload for CreateMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketId` | `string` | yes | Ticket ID of the newly created matchmaking ticket. |

### MatchmakingTicketMember

Describes one member attached to a matchmaking ticket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |
| `status` | `int` | yes | Member status value defined by backend matchmaking semantics. |
| `attribute` | `GNHashtable` | yes | Matchmaking attributes for this member (e.g. skill rating, region). |

### MatchmakingTicketResponseData

Describes the current state of a matchmaking ticket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsCreate` | `long` | yes | Creation timestamp of the matchmaking ticket. |
| `creatorId` | `string` | yes | User ID of the player who created the ticket. — _minLength=10, maxLength=10_ |
| `giveUpAfterSeconds` | `int` | yes | Maximum wait time in seconds before the ticket gives up. |
| `queueName` | `string` | yes | _minLength=6, maxLength=32_ |
| `status` | `int` | yes | Ticket status mapped by the public `MatchmakingTicketStatus` enum. |
| `matchId` | `string?` | no | Match ID assigned when the ticket is successfully matched. — _minLength=15, maxLength=15_ |
| `members` | `List<MatchmakingTicketMember>?` | no | Members included in this matchmaking party. — _elementCls=MatchmakingTicketMember_ |

Reference links:

- [MultiplayerModels.MatchmakingTicketMember:386-396](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchmakingticketmember)

### MatchmakingTicketWithTicketIdResponseData

Extends: `MatchmakingTicketResponseData`

Defines the response payload for MatchmakingTicketWithTicketId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MatchmakingTicketResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketId` | `string` | yes | Ticket identifier for this matchmaking ticket. |

Reference links:

- [MultiplayerModels.MatchmakingTicketResponseData:397-415](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchmakingticketresponsedata)

### GetMatchmakingTicketResponseData

Defines the response payload for GetMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `matchmakingTicket` | `MatchmakingTicketResponseData` | yes | Current state snapshot of the requested matchmaking ticket. |

Reference links:

- [MultiplayerModels.MatchmakingTicketResponseData:397-415](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchmakingticketresponsedata)

### MatchMember

Describes one member attached to a resolved match.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |
| `teamId` | `string` | yes | Team identifier assigned to this member by the matchmaking algorithm. |
| `attribute` | `GNHashtable` | yes | Matchmaking attributes of this member at the time of match resolution. |

### PortInfo

Represents one port mapping exposed by a game server.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `name` | `string` | yes | Port label used to identify the service (e.g. `game`, `voice`). |
| `publicPort` | `ushort` | yes | Public port number exposed to players. — _min=0_ |
| `privatePort` | `ushort` | yes | Internal port number used by the server process. — _min=0_ |
| `protocol` | `ushort` | yes | Transport protocol (1=UDP, 2=TCP). — _min=1, max=2_ |

### ServerDetail

Represents connection details for a dedicated game server.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ipV4Address` | `string` | yes | Public IPv4 address of the game server. |
| `ports` | `List<PortInfo>` | yes | List of port mappings exposed by the game server. — _elementCls=PortInfo_ |

Reference links:

- [MultiplayerModels.PortInfo:457-468](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#portinfo)

### MatchResponseData

Describes one resolved match. The public contract exposes queue/member data but does not include server endpoint fields here.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsCreate` | `long` | yes | Creation timestamp of the match. |
| `queueName` | `string` | yes | Name of the matchmaking queue that produced this match. — _minLength=6, maxLength=32_ |
| `members` | `List<MatchMember>?` | no | List of players assigned to this match. — _elementCls=MatchMember_ |
| `timeToMatchInSeconds` | `float` | yes | Elapsed time in seconds from ticket creation to match resolution. |
| `status` | `int` | yes | Match status mapped by the public `MatchStatus` enum. |

Reference links:

- [MultiplayerModels.MatchMember:446-456](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchmember)

### MatchWithMatchIdResponseData

Extends: `MatchResponseData`

Defines the response payload for MatchWithMatchId.

_Bảng dưới liệt kê field khai báo thêm hoặc khai báo lại; các field còn lại kế thừa từ `MatchResponseData`._

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `matchId` | `string` | yes | Unique match identifier. |

Reference links:

- [MultiplayerModels.MatchResponseData:483-499](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchresponsedata)

### GetMatchResponseData

Defines the response payload for GetMatch.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `match` | `MatchResponseData` | yes | Full snapshot of the requested match. |

Reference links:

- [MultiplayerModels.MatchResponseData:483-499](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchresponsedata)

### GetQueueStatisticsResponseData

Defines the response payload for GetQueueStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `pendingMemberCount` | `int` | yes | Number of individual players currently waiting in this queue. |
| `pendingTicketCount` | `int` | yes | Number of active matchmaking tickets currently waiting in this queue. |
| `averageMatchmakingTimeInSeconds` | `float` | yes | Rolling average time in seconds for recent successful match formations. |

### ListMatchmakingTicketsForPlayerResponseData

Defines the response payload for ListMatchmakingTicketsForPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `ticketIds` | `List<string>` | yes | List of active ticket IDs for the requested player. — _elementCls=String_ |

### GetAllMatchResponseData

Defines the response payload for GetAllMatch.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MatchWithMatchIdResponseData>?` | no | List of all matches with their match IDs. — _elementCls=MatchWithMatchIdResponseData_ |

Reference links:

- [MultiplayerModels.MatchWithMatchIdResponseData:483-516](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchwithmatchidresponsedata)

### GetAllMatchmakingTicketResponseData

Defines the response payload for GetAllMatchmakingTicket.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MatchmakingTicketWithTicketIdResponseData>?` | no | List of all matchmaking tickets with their ticket IDs. — _elementCls=MatchmakingTicketWithTicketIdResponseData_ |

Reference links:

- [MultiplayerModels.MatchmakingTicketWithTicketIdResponseData:397-432](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#matchmakingticketwithticketidresponsedata)

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._
