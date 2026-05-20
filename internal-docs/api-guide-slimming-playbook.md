# Playbook Rút Gọn Guide và API Reference

> Internal maintenance doc. Không dùng file này để sinh code tích hợp package; ưu tiên `docs/START_HERE.md`, `docs/AI_CHEATSHEET.md`, `docs/RULES.md`, và `docs/guides/*`.

Mục tiêu: biến `docs/guides/<ENTITY>.md` thành landing page để AI chọn đúng namespace/method/flow, còn `docs/reference/API_<ENTITY>.md` chỉ giữ contract table. Pattern này đã áp dụng cho `ContentApi` và có thể dùng lại cho các entity khác.

## 1. Vai trò mới của từng file

`docs/guides/<ENTITY>.md`:

- Là file AI đọc đầu tiên sau `AI_CHEATSHEET.md` và `RULES.md`.
- Giải thích scope, route/namespace, hard rules, flow nghiệp vụ, anti-patterns.
- Có bảng chọn method theo nhu cầu.
- Có link line-range thẳng đến từng row trong `API_<ENTITY>.md`.
- Có minimal pattern để copy-paste đúng response checking.
- Có ví dụ end-to-end ngắn cho các flow quan trọng.

`docs/reference/API_<ENTITY>.md`:

- Chỉ giữ contract theo role/namespace.
- Không giữ lại phần convention, flow, ví dụ tối thiểu nếu guide đã có.
- Mỗi row giữ DTO link, response data DTO link, permission rule, ErrorCode.
- Là nơi tra contract chi tiết sau khi guide đã chọn đúng method.

## 2. Cấu trúc guide đề xuất

Dùng cấu trúc này làm khung mặc định:

```markdown
# <Entity>Api

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.<entity>*`.

## 1. Scope

## 2. Hard Rules

## 3. Chọn Namespace

## 4. Chọn Method

## 5. Method Signature

## 6. Request Field Rules

## 7. <Flow nghiệp vụ chính>

## 8. Minimal Pattern

## 9. Ví dụ Khuyến Nghị

## 10. Anti-Patterns

## 11. AI Checklist
```

Không bắt buộc entity nào cũng có section flow riêng giống nhau. Với entity không có upload/download, thay `## 7` bằng flow quan trọng nhất của domain, ví dụ friend/group/store/matchmaking/cloudscript.

## 3. Cấu trúc API reference đề xuất

Rút `docs/reference/API_<ENTITY>.md` về dạng:

```markdown
# API Reference: <Entity>Api

Bảng contract cho `<Entity>Api`. Bắt đầu từ [guides/<ENTITY>.md](/docs/guides/<ENTITY>.md) để chọn namespace, method, và flow trước khi đọc các row này.

- Domain guide: [guides/<ENTITY>.md](/docs/guides/<ENTITY>.md)
- DTO shapes: [dto/<ENTITY>.md](/docs/reference/dto/<ENTITY>.md)
- Error handling: [ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md)
- Permission rules: [PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md)

## Client methods (`GNNetwork.<entity>.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |

## Server methods (`GNNetwork.<entity>.server.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |

## Admin methods (`GNNetwork.<entity>.admin.*`)

<!-- prettier-ignore -->
| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |
| --- | --- | --- | --- | --- |
```

Nếu entity không có đủ 3 role thật, chỉ giữ các section role public contract thật sự có.

## 4. Những phần nên di dời từ API sang guide

Di dời hoặc hợp nhất vào guide:

- `## Namespaces`
- `## Convention`
- Method signature chung
- Param chung: `overrideAuthToken`, `overrideSecretKey`, `customTags`, `timeout`
- Response fields chung
- Ví dụ tối thiểu
- Flow nghiệp vụ như upload/download, socket, matchmaking, store receipt, cloudscript publish/execute

Không di dời khỏi API:

- Method contract rows.
- DTO link.
- Response data DTO link.
- Permission rule.
- ErrorCode theo method.

## 5. Bảng chọn method trong guide

Guide nên có một bảng `Chọn Method` để AI chọn method mà không mở full API:

```markdown
<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `someMethodAsync` | Mô tả use case | `fieldA`, `fieldB?` | `responseData.someField` | [client:15-15](/docs/reference/API_ENTITY.md#client-methods-gnnetworkentity) / [server:28-28](/docs/reference/API_ENTITY.md#server-methods-gnnetworkentityserver) / [admin:41-41](/docs/reference/API_ENTITY.md#admin-methods-gnnetworkentityadmin) |
```

Rule:

- Method trong guide dùng dạng async (`someMethodAsync`) vì AI sinh code thường dùng `await`.
- Row trong API dùng base method (`someMethod`) vì API reference đang liệt kê method contract.
- Cột `API contract rows` phải link line-range đúng row cần đọc trong API.
- Sau khi sửa API reference, phải tính lại line-range rồi mới cập nhật guide.

## 6. Response checking chuẩn

Guide nên dùng pattern canonical từ `RULES.md`:

```csharp
if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

Nếu entity guide cũ dùng `hasReturnCodeError()`, có thể giữ như note phụ, nhưng default snippet cho AI nên dùng public fields/enum để nhất quán:

```markdown
Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.
```

## 7. Quy trình thực hiện cho một entity

1. Đọc `docs/guides/<ENTITY>.md` và `docs/reference/API_<ENTITY>.md` hiện tại với số dòng.
2. Xác định phần nào trong API đang là guide/convention/example để di dời.
3. Rút `API_<ENTITY>.md` về contract-only.
4. Ghi lại line number thật của từng method row trong API sau khi rút gọn.
5. Cập nhật `guides/<ENTITY>.md`:
   - thêm hoặc chỉnh `Chọn Method`,
   - thêm cột `API contract rows`,
   - thêm `Method Signature`,
   - thêm hoặc cập nhật `Minimal Pattern`,
   - rút gọn flow/request/anti-pattern để tránh trùng API reference.
6. Tính lại line-range trong guide trỏ sang API.
7. Kiểm tra markdown table không lệch cột.
8. Grep để chắc API không còn các section đã di dời.

## 8. Lệnh kiểm tra hữu ích

In file kèm số dòng:

```powershell
$i=1; Get-Content -Path docs/reference/API_CONTENT.md | ForEach-Object { '{0,4}: {1}' -f $i, $_; $i++ }
```

In riêng các row method trong API:

```powershell
$i=1; Get-Content -Path docs/reference/API_CONTENT.md | ForEach-Object { if ($_ -match '^\| `') { '{0}:{1}' -f $i, $_ }; $i++ }
```

Kiểm tra table có lệch số cột không:

```powershell
$files = @('docs/reference/API_CONTENT.md','docs/guides/CONTENT.md')
foreach ($file in $files) {
  $bad = @()
  Get-Content $file | ForEach-Object -Begin {$i=0; $expected=$null} -Process {
    $i++
    if ($_ -like '|*|') {
      $count = ([regex]::Matches($_, '\|')).Count
      if ($_ -match '^\| ---') { $expected = $count }
      elseif ($expected -ne $null -and $count -ne $expected) {
        $bad += "${file}:${i}: pipes=${count}, expected=${expected}: $_"
      }
    } else {
      $expected=$null
    }
  }
  if ($bad.Count) { $bad } else { "${file}: markdown table pipe counts OK" }
}
```

Kiểm tra API không còn section guide/convention cũ:

```powershell
rg "## Namespaces|## Convention|Ví dụ tối thiểu|Vi du toi thieu" docs/reference/API_CONTENT.md docs/guides/CONTENT.md
```

## 9. Checklist review

- Đọc guide là chọn được namespace đúng.
- Đọc guide là chọn được method đúng.
- Mỗi method trong guide có link row client/server/admin tương ứng trong API.
- API reference không còn convention/flow/example lặp với guide.
- API reference vẫn giữ đủ DTO link, response DTO link, permission rule, ErrorCode.
- Response pattern trong guide không trái `RULES.md`.
- Không tự ý đổi tiếng Việt có dấu thành tiếng Việt không dấu.
- Nếu sửa API làm lệch dòng, đã cập nhật lại toàn bộ line-range trong guide.
- Markdown table pipe counts OK.

## 10. Ghi chú từ lần triển khai ContentApi

Những việc đã làm cho Content:

- `API_CONTENT.md` được rút còn intro ngắn và 3 bảng contract:
  - `Client methods`
  - `Server methods`
  - `Admin methods`
- `CONTENT.md` được biến thành landing page/router:
  - bảng chọn namespace,
  - bảng chọn method có link line-range sang API,
  - method signature chung,
  - request field rules,
  - upload/download sequence,
  - minimal pattern,
  - ví dụ khuyến nghị,
  - anti-patterns,
  - AI checklist.
- Sample response checking được đổi về `returnCode` trước `errorCode`.
- Ví dụ `configs` dùng `List<ContentModels.ContentDataParam>` vì DTO field là `List<ContentDataParam>`.
- Đã giữ line-range trong guide khớp với row thật của API sau rewrite.
- Đã sửa lại tiếng Việt có dấu sau khi phát hiện nội dung bị chuyển thành không dấu.
