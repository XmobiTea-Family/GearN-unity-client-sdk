# GearN Unity Client SDK — AI Entry Guide

Entry point cho AI agent / code assistant khi làm việc với repo hoặc package Unity này.

Mục tiêu:

- Sinh code tích hợp SDK đúng từ đầu cho Unity/C#.
- Không cần đọc sâu `Runtime/` để hiểu public contract thông thường.
- Tránh suy diễn sai về route, secret, permission, auth/socket flow.

## 0. Triage nhanh — nhảy thẳng nếu đã biết mình cần gì

<!-- prettier-ignore -->
| Tôi cần... | Nhảy tới (không cần đọc thêm) |
| --- | --- |
| Sinh code gọi 1 method cụ thể (login, get profile, buy item, execute CloudScript…) | [§6 Quick Task Map](#6-quick-task-map) → tìm đúng row → đọc range đó |
| Hiểu rule chung (route, permission, error, socket) | [RULES.md quick-jump](docs/RULES.md) → đọc đúng section |
| Chạy 1 scenario phức tạp end-to-end (daily reward, matchmaking, guild bank…) | [§4.1 Scenario library](#41-scenario-library-docsexamples) → match → đọc 1 file `examples/` |
| Debug `OperationNotAllow` ngay | [RULES.md:143-188](docs/RULES.md) — §6 Permission flags + checklist |
| Không biết API nào làm được | [AI_CHEATSHEET.md §2](docs/AI_CHEATSHEET.md) — decision tree |
| Tìm scenario COOKBOOK (bootstrap, login, socket, store, CloudScript…) | [COOKBOOK.md:7-29](docs/COOKBOOK.md) — đọc Index → nhảy thẳng vào range scenario |

> Nếu không match bất kỳ row nào ở trên, đọc tiếp §1 bên dưới.

---

## 1. Reading order

1. [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md) — one-page reference, decision tree, mandatory pattern.
2. [docs/RULES.md](/docs/RULES.md) — **canonical** cho mọi rule cross-cutting.
3. [docs/reference/API_INDEX.md](/docs/reference/API_INDEX.md) — bảng method theo 11 API group.
4. Guide đúng domain trong [docs/guides/](/docs/guides/).
5. DTO field qua [docs/reference/dto/](/docs/reference/dto/) hoặc grep [docs/reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md).
6. Public type trong `Runtime/**/*.cs` — fallback khi docs chưa cover.

Bảng chọn API group theo yêu cầu: xem [docs/AI_CHEATSHEET.md § 2](/docs/AI_CHEATSHEET.md#2-decision-tree-what-i-need-do). Rule router/permission/socket: xem [docs/RULES.md](/docs/RULES.md); permission operation/flag offline: [docs/reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).

## 2. Đọc link theo range line

Convention: `[file:startLine-endLine](path)` = chỉ thị range-line, KHÔNG phải markdown anchor.

Khi **ĐỌC**:

- Chỉ đọc đúng từ line `startLine` đến `endLine`, không đọc cả file.
- Với Read tool: truyền `offset = startLine - 1`, `limit = endLine - startLine + 1`.

Khi **VIẾT / EDIT** docs:

- KHÔNG đổi `[file:37-66](path)` sang `[file § N](path#anchor)`.
- KHÔNG xoá phần `:startLine-endLine` cho "gọn hơn".
- KHÔNG thay bằng markdown anchor kể cả khi anchor "đúng chuẩn markdown hơn".
- Nếu tự thêm link tới một range nội dung cụ thể, dùng đúng dạng `[file:startLine-endLine](path)`.

Lý do: range-line tiết kiệm token cho AI agent đọc sau. Anchor link buộc AI phải đọc cả file để tìm section.

> Luôn luôn ghi nhớ đọc tài liệu theo range line nếu gặp dạng `[file:startLine-endLine](path)`, và giữ nguyên convention này khi edit docs.

## 3. Khi nào được đọc `Runtime/`

Chỉ đọc `Runtime/` khi:

- Sửa chính SDK.
- Debug behavior nội bộ repo.
- Verify public contract mà docs chưa mô tả đủ.

Với mục tiêu tích hợp package: **không** bắt đầu từ implementation chi tiết. Nguồn chính: `AI_CHEATSHEET.md` → `RULES.md` → guide domain → `API_<GROUP>.md` → `Runtime/**/*.cs` khi cần xác nhận chữ ký public.

Nếu `docs` + public C# type vẫn chưa đủ kết luận, hỏi lại con người hoặc ghi rõ giả định — không bịa behavior.

## 4. Scenario end-to-end

16 scenario end-to-end (config settings asset, login, socket, realtime event, matchmaking, store, cloudscript, cleanup, diagnose permission, ...): đọc [COOKBOOK.md:7-29](docs/COOKBOOK.md) để lấy range của scenario cần → nhảy thẳng vào đó.

### 4.1 Scenario library `docs/examples/`

Một số scenario thường gặp có sẵn dạng end-to-end (data model + cloud handler + publish + Unity client + pitfall trong 1 file). Đọc 1 file ~3k token thay vì ráp 5 guide ~40k token:

- [docs/examples/exam1.md](docs/examples/exam1.md) — 1-1 direct chat bằng CloudScript + raw MongoDB, không Group.
- [docs/examples/exam2.md](docs/examples/exam2.md) — key-value store cho mỗi user (settings, progress flag, draft state) bằng raw collection.
- [docs/examples/exam3.md](docs/examples/exam3.md) — daily reward: cooldown 24h, streak counter, atomic CAS chống double-claim, payout qua `admin.gamePlayer`.
- [docs/examples/exam4.md](docs/examples/exam4.md) — currency-cost flow: action tốn N gem (đổi tên displayName), get-then-change atomic, rollback khi side-effect fail.
- [docs/examples/exam5.md](docs/examples/exam5.md) — leaderboard tự định nghĩa theo kỳ (event tuần / season pass), giữ điểm cao nhất, rank bằng `countDocuments`.
- [docs/examples/exam6.md](docs/examples/exam6.md) — inbox / hộp thư hệ thống: server gửi mail + reward, user list / read / claim, push realtime qua `socket`.
- [docs/examples/exam7.md](docs/examples/exam7.md) — quest progress: track tiến độ nhiệm vụ (`$inc` atomic), tự đánh dấu completed, claim reward payout `admin.gamePlayer`.
- [docs/examples/exam8.md](docs/examples/exam8.md) — daily login streak: đếm ngày liên tiếp theo day index UTC, reset khi bỏ lỡ, payout tăng dần.
- [docs/examples/exam9.md](docs/examples/exam9.md) — referral: sinh mã giới thiệu, invitee redeem 1 lần, inviter nhận reward khi invitee đạt mốc.
- [docs/examples/exam10.md](docs/examples/exam10.md) — rate limit: giới hạn N action / khoảng thời gian (gacha free, watch-ad) bằng fixed-window CAS.
- [docs/examples/exam11.md](docs/examples/exam11.md) — season pass: tích XP theo mùa, claim milestone 2 track free/premium, payout currency.
- [docs/examples/exam12.md](docs/examples/exam12.md) — guild bank: kho currency chung của group, deposit/withdraw + audit log, check membership qua `admin.group`.
- [docs/examples/exam13.md](docs/examples/exam13.md) — inventory trade: giao dịch item giữa 2 user, escrow doc, confirm 2 phía, atomic swap qua `admin.inventory.setOwner`.
- [docs/examples/exam14.md](docs/examples/exam14.md) — audit log: ghi log nghiệp vụ bền vững vào log DB (`logRuntimeGameCollection`), admin query lại.
- [docs/examples/exam15.md](docs/examples/exam15.md) — push campaign: registry device token, lọc segment theo tag/level/last-active, gửi bulk `pushNotification`.
- [docs/examples/exam16.md](docs/examples/exam16.md) — email verify: gửi mã 6 số qua `mail`, verify, gán tag `emailVerified` vào MasterPlayer.
- [docs/examples/exam17.md](docs/examples/exam17.md) — presence: track online/offline bằng heartbeat + timeout, broadcast cho friend list qua `socket`.
- [docs/examples/exam18.md](docs/examples/exam18.md) — webhook callback: trusted backend relay → CloudScript verify độc lập qua `http` → idempotent grant.
- [docs/examples/exam20.md](docs/examples/exam20.md) — group chat: dùng message store built-in `groupRepository` + socket broadcast; so sánh với custom collection.

Khi nào dùng: scenario của bạn match (hoặc gần match) 1 file ở trên → đọc đúng file đó, KHÔNG đọc lại các guide đã được tham chiếu trong file.

Mỗi `examples/<name>.md` follow đúng cấu trúc cố định:

1. §1 Mô hình dữ liệu (collection, schema, index).
2. §2 Script TypeScript (cloud handler).
3. §3 Publish version.
4. §4 Unity client (C# call site).
5. §5 Cảnh báo / pitfall.

Mọi link nội bộ dùng range-line `[file:start-end](path)` (xem §2).

Khi viết scenario mới: tạo file mới theo cấu trúc trên, thêm 1 row link ở danh sách trên — KHÔNG copy lại nội dung vào guide / cookbook.

## 5. Đọc tài liệu bằng utf-8

Docs này toàn tiếng việt, hãy đọc thẳng bằng utf-8 tránh lỗi encoding không mong muốn và phải đọc lại làm tốn context token.

## 6. Quick Task Map

Dùng bảng này để tìm ngay đoạn cần đọc mà không cần load cả file guide. Khi dùng Read tool, truyền `offset = startLine - 1` và `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Task | Đọc đoạn này |
| --- | --- |
| **Authenticate** | |
| Chọn method login phù hợp | [guides/AUTHENTICATE.md:36-76](docs/guides/AUTHENTICATE.md) — §4 bảng 18 method |
| Login bằng username/password | [guides/AUTHENTICATE.md:47-47](docs/guides/AUTHENTICATE.md) — row `loginByAccountAsync` |
| Login bằng Google | [guides/AUTHENTICATE.md:59-59](docs/guides/AUTHENTICATE.md) — row `loginByGoogleAsync` |
| Login bằng device/custom ID | [guides/AUTHENTICATE.md:50-54](docs/guides/AUTHENTICATE.md) — rows device/custom login |
| Refresh auth token | [guides/AUTHENTICATE.md:49-49](docs/guides/AUTHENTICATE.md) — row `refreshAuthTokenAsync` |
| Minimal code pattern (login) | [guides/AUTHENTICATE.md:139-165](docs/guides/AUTHENTICATE.md) — §8 Minimal Pattern |
| Auth + socket flow | [guides/AUTHENTICATE.md:123-138](docs/guides/AUTHENTICATE.md) — §7 Auth Và Socket Flow |
| Ví dụ: guest, Google, refresh, socket | [guides/AUTHENTICATE.md:166-241](docs/guides/AUTHENTICATE.md) — §9 Ví Dụ Khuyến Nghị |
| **Game Player** | |
| Đọc profile/field của game player | [guides/GAME_PLAYER.md:104-127](docs/guides/GAME_PLAYER.md) — §5 bảng "Đọc 1 game player" |
| Search / leaderboard player | [guides/GAME_PLAYER.md:128-144](docs/guides/GAME_PLAYER.md) — §5 bảng "Search, leaderboard và log" |
| Lifecycle friend/group/character/item | [guides/GAME_PLAYER.md:146-159](docs/guides/GAME_PLAYER.md) — §5 bảng "Friend, group, character và item lifecycle" |
| Mutation profile (currency, statistics, data) | [guides/GAME_PLAYER.md:161-177](docs/guides/GAME_PLAYER.md) — §5 bảng "Mutation profile" |
| `InfoRequestParam` rules (GamePlayer) | [guides/GAME_PLAYER.md:217-248](docs/guides/GAME_PLAYER.md) — §8 InfoRequestParam Rules |
| Minimal pattern (GamePlayer) | [guides/GAME_PLAYER.md:287-306](docs/guides/GAME_PLAYER.md) — §10 Minimal Pattern |
| **Character Player** | |
| Chọn method (CharacterPlayer) | [guides/CHARACTER_PLAYER.md:95-229](docs/guides/CHARACTER_PLAYER.md) — §5 Chọn Method (4 bảng: snapshot, metadata, search/leaderboard, lifecycle/mutation) |
| **Master Player** | |
| Đọc profile/field của master player | [guides/MASTER_PLAYER.md:77-100](docs/guides/MASTER_PLAYER.md) — §4 bảng "Đọc 1 master player" |
| Search player, leaderboard, log (MasterPlayer) | [guides/MASTER_PLAYER.md:101-122](docs/guides/MASTER_PLAYER.md) — §4 bảng "Search player, leaderboard và log" |
| Link / unlink identity (Apple, Google, FB…) | [guides/MASTER_PLAYER.md:123-159](docs/guides/MASTER_PLAYER.md) — §4 bảng "Link và unlink identity" |
| Mutation (currency, data, statistics, ban) | [guides/MASTER_PLAYER.md:161-187](docs/guides/MASTER_PLAYER.md) — §4 bảng "Mutation hồ sơ, account và outbound" |
| **Group** | |
| Chọn method (Group) | [guides/GROUP.md:79-144](docs/guides/GROUP.md) — §5 Chọn Method (bảng read, query, mutation) |
| **Inventory** | |
| Đọc / query inventory item | [guides/INVENTORY.md:52-93](docs/guides/INVENTORY.md) — §4 bảng "Đọc 1 item" + "Query danh sách" |
| Mutation inventory item | [guides/INVENTORY.md:94-111](docs/guides/INVENTORY.md) — §4 bảng "Mutation" |
| **Store / Purchase** | |
| Catalog / discovery store items | [guides/STORE_INVENTORY.md:47-66](docs/guides/STORE_INVENTORY.md) — §4 bảng "Catalog và Discovery" |
| Purchase / gift / validate receipt | [guides/STORE_INVENTORY.md:67-86](docs/guides/STORE_INVENTORY.md) — §4 bảng "Purchase, Gift và Receipt" |
| Store log / audit / used state | [guides/STORE_INVENTORY.md:78-98](docs/guides/STORE_INVENTORY.md) — §4 bảng "Audit và Used State" |
| **Matchmaking** | |
| Matchmaking ticket lifecycle (create/join/cancel/poll) | [guides/MULTIPLAYER.md:46-78](docs/guides/MULTIPLAYER.md) — §4 bảng method + decision rules |
| **CloudScript** | |
| Chọn method + decision rules (CloudScript) | [guides/CLOUDSCRIPT.md:56-82](docs/guides/CLOUDSCRIPT.md) — §4 bảng method |
| Execute function từ Unity client (3-tier check pattern) | [guides/CLOUDSCRIPT.md:162-186](docs/guides/CLOUDSCRIPT.md) — §8 Minimal Pattern |
| Publish version mới + promote live (admin) | [guides/CLOUDSCRIPT.md:113-161](docs/guides/CLOUDSCRIPT.md) — §6 field rules (gồm `EditFunctionRequestData.canExecute="true"` string rule, line 128) + §7 publish flow |
| Viết handler TypeScript chạy trong CloudScript | [cloudScript/CLOUDSCRIPT_USAGE.md:164-196](docs/cloudScript/CLOUDSCRIPT_USAGE.md) — §3 rule bắt buộc + [cloudScript/CLOUDSCRIPT_USAGE.md:213-328](docs/cloudScript/CLOUDSCRIPT_USAGE.md) — §5 typing |
| Lưu custom data (chat, kv, log) bằng MongoDB raw | [cloudScript/CLOUDSCRIPT_database.md:43-55](docs/cloudScript/CLOUDSCRIPT_database.md) — raw collection helper + [cloudScript/CLOUDSCRIPT_database.md:81-112](docs/cloudScript/CLOUDSCRIPT_database.md) — naming khi tạo index + [cloudScript/CLOUDSCRIPT_database.md:161-207](docs/cloudScript/CLOUDSCRIPT_database.md) — §6 raw collection dùng khi nào |
| Chọn helper: admin vs database vs http vs socket vs mail vs pushNotification (decision-first quick table) | [cloudScript/CLOUDSCRIPT_USAGE.md:135-149](docs/cloudScript/CLOUDSCRIPT_USAGE.md) — §1.5 quick table, hoặc [cloudScript/CLOUDSCRIPT_USAGE.md:329-351](docs/cloudScript/CLOUDSCRIPT_USAGE.md) — §6 chi tiết |
| Symbol inject sẵn trong cloud script (lookup) | [cloudScript/CLOUDSCRIPT_INJECTED_SYMBOLS.md](docs/cloudScript/CLOUDSCRIPT_INJECTED_SYMBOLS.md) — bảng ~70 symbol grouped |
| **Content** | |
| Chọn method (Content: config, upload, download) | [guides/CONTENT.md:44-72](docs/guides/CONTENT.md) — §4 bảng method + decision rules |
| **Dashboard** | |
| Admin login | [guides/DASHBOARD.md:47-60](docs/guides/DASHBOARD.md) — §4 bảng "Auth và quản trị admin account" |
| Dashboard: game config + secret key | [guides/DASHBOARD.md:61-83](docs/guides/DASHBOARD.md) — §4 bảng "Quản lý game" + "Secret key" |
| Dashboard: analytics + logs + callback CloudScript | [guides/DASHBOARD.md:84-113](docs/guides/DASHBOARD.md) — §4 bảng "Analytics, logs và callback" |
| **DTO** | |
| DTO fields: authenticate | [reference/dto/AUTHENTICATE.md:19-84](docs/reference/dto/AUTHENTICATE.md) — danh sách class + line ranges |
| DTO fields: game player | [reference/dto/GAME_PLAYER.md:19-401](docs/reference/dto/GAME_PLAYER.md) — danh sách class + line ranges |
| DTO fields: character player | [reference/dto/CHARACTER_PLAYER.md:17-413](docs/reference/dto/CHARACTER_PLAYER.md) — danh sách class + line ranges |
| DTO fields: master player | [reference/dto/MASTER_PLAYER.md:19-674](docs/reference/dto/MASTER_PLAYER.md) — danh sách class + line ranges |
| DTO fields: group | [reference/dto/GROUP.md:17-323](docs/reference/dto/GROUP.md) — danh sách class + line ranges |
| DTO fields: inventory | [reference/dto/INVENTORY.md:17-275](docs/reference/dto/INVENTORY.md) — danh sách class + line ranges |
| DTO fields: store inventory | [reference/dto/STORE_INVENTORY.md:17-149](docs/reference/dto/STORE_INVENTORY.md) — danh sách class + line ranges |
| DTO fields: multiplayer | [reference/dto/MULTIPLAYER.md:19-112](docs/reference/dto/MULTIPLAYER.md) — danh sách class + line ranges |
| DTO fields: content | [reference/dto/CONTENT.md:17-80](docs/reference/dto/CONTENT.md) — danh sách class + line ranges |
| DTO fields: cloudScript | [reference/dto/CLOUDSCRIPT.md:19-66](docs/reference/dto/CLOUDSCRIPT.md) — danh sách class + line ranges |
| DTO fields: dashboard | [reference/dto/DASHBOARD.md:17-179](docs/reference/dto/DASHBOARD.md) — danh sách class + line ranges |
| **Cross-cutting** | |
| Route / trust boundary (client/server/admin) | [RULES.md:87-112](docs/RULES.md) — §3 |
| self vs other-self (khi nào dùng otherSelfEnable) | [RULES.md:113-131](docs/RULES.md) — §4 |
| Phân biệt SecretInvalid / OperationInvalid / OperationNotAllow | [RULES.md:132-142](docs/RULES.md) — §5 |
| Response checking (returnCode + errorCode) + throw-vs-early-return + CloudScript 3-tier | [AI_CHEATSHEET.md:11-49](docs/AI_CHEATSHEET.md) — §1 Mandatory pattern (canonical) + [RULES.md:40-86](docs/RULES.md) — §2 |
| Socket flow (connect, auth, re-auth) | [RULES.md:189-218](docs/RULES.md) — §7 |
| Permission flag / checklist `OperationNotAllow` | [RULES.md:143-188](docs/RULES.md) — §6 · [reference/PERMISSION_RULES.md](docs/reference/PERMISSION_RULES.md) |
| Anti-patterns & pitfalls (15 items) | [RULES.md:264-286](docs/RULES.md) — §10 |
| Error codes và cách xử lý | [reference/ERROR_HANDLING.md](docs/reference/ERROR_HANDLING.md) |
| Scenario end-to-end (cookbook) | [COOKBOOK.md Index:7-29](docs/COOKBOOK.md) — đọc Index → nhảy thẳng vào range scenario |
