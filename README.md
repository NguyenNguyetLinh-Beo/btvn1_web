# btvn1_web
# Multi-project Solution (.NET Framework 2.0)

Tên bộ bài:PaPa'Magic Transform - MultiProject (.NET 2.0)

Mô tả ngắn:
Bộ giải gồm 4 project sử dụng **.NET Framework 2.0**:

1. *MagicLib** — Class Library (.NET Framework 2.0) -> biên dịch ra `MagicLib.dll`.

   * Độc lập: không nhập/ xuất file; nhận dữ liệu thông qua thuộc tính `Input`, xử lý trong `Process()` và trả kết quả qua thuộc tính `Result`.
   * Giải một bài toán "độc-lạ": **"PaPa cipher"** — biến đổi văn bản kết hợp đảo chuỗi, hoán vị ký tự theo seed lấy từ tên tác giả "PaPa", kèm checksum MD5 rút gọn. Đây là dấu ấn cá nhân.

2. **MagicConsole** — Console App (.NET Framework 2.0) -> EXE.

   * Nhập input từ console, gọi `MagicLib`, hiển thị kết quả với chữ ký ASCII nghệ thuật "PaPa".

3. **MagicWinForm** — Windows Forms (.NET Framework 2.0) -> EXE.

   * Giao diện kéo-thả (TextBox, Button, Label). Gọi DLL để xử lý, hiển thị kết quả, có nút copy và lưu tạm.

4. **MagicWeb** — ASP.NET Web Application (.NET Framework 2.0).

   * `index.html` (client) dùng HTML/CSS/JS để thu input, tiền xử lý, gửi `POST` AJAX tới `api.aspx`.
   * `api.aspx.cs` nhận `Request.Form["input"]`, gọi `MagicLib`, trả về JSON đơn giản.
   * Hướng dẫn cấu hình **IIS + hosts** để chạy `http://papamagic.local`.

