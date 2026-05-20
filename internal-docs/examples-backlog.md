# Backlog: scenarios cần viết vào `docs/examples/`

> Internal maintenance doc. Đây là backlog biên soạn tài liệu, không phải guide public cho người tích hợp package.

Danh sách scenario ưu tiên cho [Task 3 plan](token-optimization-plan.md). Mỗi scenario sẽ thành 1 file `docs/examples/<name>.md` theo cấu trúc cố định ([AGENTS.md §4.1](/AGENTS.md)):

1. §1 Mô hình dữ liệu (collection, schema, index).
2. §2 Script TypeScript (cloud handler).
3. §3 Publish version.
4. §4 Unity client (C# call site).
5. §5 Cảnh báo / pitfall.

Acceptance từng file: ≤ 3k token, agent đọc 1 file là đủ làm scenario (không cần ráp guide). Khi xong, link vào AGENTS.md §4.1 + xóa row tương ứng dưới đây.

## Rule bắt buộc khi viết scenario file

**Mỗi `docs/examples/<name>.md` phải tự đứng độc lập — KHÔNG cross-link sang file `examX.md` khác.**

- Acceptance của 1 scenario file: AI đọc đúng 1 file là đủ làm, không phải mở file thứ hai.
- Nếu 2 scenario share chung 1 đoạn (vd block publish version, helper `requireString`/`assertResponseOk`, pattern 3-tier check Unity client) → **ghi đầy đủ inline ở cả hai file**, KHÔNG viết "pattern y hệt [examY.md §N]".
- Vẫn được link sang `docs/guides/`, `docs/cloudScript/`, `docs/reference/`, `docs/AI_CHEATSHEET.md` bằng range-line — đó là nguồn canonical, không phải scenario file.
- Lý do: cross-link giữa các `examX.md` ép AI đọc 2+ file, phá vỡ mục tiêu "1 file ~3k token thay vì ráp 5 guide ~40k token". Trùng lặp nội dung giữa scenario file là chấp nhận được; ép đọc thêm file thì không.

---

## Đã có

- ✅ `exam1.md` — 1-1 direct chat bằng CloudScript + raw MongoDB, không Group.
- ✅ `exam2.md` — kv-store cho mỗi user.
- ✅ `exam3.md` — daily reward 24h + streak + atomic CAS.
- ✅ `exam4.md` — currency-cost flow + rollback (rename displayName tốn 50 gem).
- ✅ `exam5.md` — leaderboard tự định nghĩa theo kỳ (event tuần / season pass).
- ✅ `exam6.md` — inbox hệ thống: server gửi mail + reward, list/read/claim, socket push.
- ✅ `exam7.md` — quest progress: track tiến độ, check milestone, payout reward.
- ✅ `exam8.md` — daily login streak: đếm ngày liên tiếp UTC, reset khi miss.
- ✅ `exam9.md` — referral: mời bạn, redeem code, reward inviter khi invitee đạt mốc.
- ✅ `exam10.md` — rate limit: giới hạn N action / window bằng fixed-window CAS.
- ✅ `exam11.md` — season pass: tích XP theo mùa, milestone free/premium track.
- ✅ `exam12.md` — guild bank: kho currency chung group, deposit/withdraw + audit.
- ✅ `exam13.md` — inventory trade: escrow doc, confirm 2 phía, atomic item swap.
- ✅ `exam14.md` — audit log: ghi log nghiệp vụ bền vững vào log DB, admin query.
- ✅ `exam15.md` — push campaign: registry token, lọc segment, gửi bulk push.
- ✅ `exam16.md` — email verify: gửi mã 6 số, verify, gán tag MasterPlayer.
- ✅ `exam17.md` — presence: heartbeat + timeout, broadcast friend list.
- ✅ `exam18.md` — webhook callback: trusted relay → verify độc lập → idempotent grant.
- ✅ `exam20.md` — group chat: built-in groupRepository message vs custom collection.

## Convention naming

File scenario đánh số tuần tự: `exam1.md`, `exam2.md`, `exam3.md`, … (không đặt tên theo topic). Lý do: tránh bikeshedding tên file, AGENTS.md §4.1 là nơi duy nhất map số → mô tả scenario. Khi viết file mới: lấy số kế tiếp + thêm row vào AGENTS.md §4.1 + tick off ở backlog dưới đây.

## Ưu tiên cao (token saving lớn / scenario hay gặp)

| Tên file | Scenario | Helper chính | Token saving ước tính |
| --- | --- | --- | --- |
| ~~`exam2.md`~~ ✅ | ~~**kv-store**~~ | done | — |
| ~~`exam3.md`~~ ✅ | ~~**daily-reward**~~ | done | — |
| ~~`exam4.md`~~ ✅ | ~~**currency-cost-flow**~~ | done | — |
| ~~`exam5.md`~~ ✅ | ~~**leaderboard-custom**~~ | done | — |
| ~~`exam6.md`~~ ✅ | ~~**inbox**~~ | done | — |

## Ưu tiên trung (gameplay nâng cao)

| Tên file (gợi ý) | Scenario | Helper chính |
| --- | --- | --- |
| ~~`exam7.md`~~ ✅ | ~~**quest-progress**~~ | done |
| ~~`exam8.md`~~ ✅ | ~~**daily-login-streak**~~ | done |
| ~~`exam9.md`~~ ✅ | ~~**referral**~~ | done |
| ~~`exam10.md`~~ ✅ | ~~**rate-limit**~~ | done |
| ~~`exam11.md`~~ ✅ | ~~**season-pass**~~ | done |
| ~~`exam12.md`~~ ✅ | ~~**guild-bank**~~ | done |
| ~~`exam13.md`~~ ✅ | ~~**inventory-trade**~~ | done |

## Ưu tiên thấp (operational / admin)

| Tên file (gợi ý) | Scenario | Helper chính |
| --- | --- | --- |
| ~~`exam14.md`~~ ✅ | ~~**audit-log**~~ | done |
| ~~`exam15.md`~~ ✅ | ~~**push-campaign**~~ | done |
| ~~`exam16.md`~~ ✅ | ~~**email-verify**~~ | done |
| ~~`exam17.md`~~ ✅ | ~~**presence**~~ | done |
| ~~`exam18.md`~~ ✅ | ~~**webhook-callback**~~ | done |
| `exam19.md` | **server-validated-iap**: Validate receipt mua IAP từ store (Apple/Google), grant item, anti-replay | `admin.storeInventory.validateReceipt` + `database` (receipt log) |
| ~~`exam20.md`~~ ✅ | ~~**group-chat**~~ | done |

> Số `examN.md` ở các table chỉ là gợi ý theo thứ tự ưu tiên hiện tại. Khi viết thực, dùng số kế tiếp chưa được dùng trong `docs/examples/` (không cần khớp chính xác với số trong table này).

## Gợi ý thứ tự triển khai

1. `exam2.md` (kv-store) — đơn giản nhất, làm template chuẩn cho các file sau.
2. `exam3.md` (daily-reward) — pattern cooldown + atomic currency, reuse được cho nhiều scenario khác.
3. `exam4.md` (currency-cost-flow) — pattern get-then-change atomic, gặp ở mọi gameplay loop.
4. `exam5.md` (leaderboard-custom) — pattern index Mongo, gặp khi SDK statistics không đủ.
5. `exam6.md` (inbox) — pattern combine `database` + `socket`, làm sau khi đã quen kv-store.

Sau 5 file đầu, đánh giá lại tỉ lệ scenario thực tế bị match — quyết định viết tiếp ưu tiên trung/thấp hay dừng.
