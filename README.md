# btvn1_web
TẠO SOLUTION GỒM CÁC PROJECT SAU:

1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).  
2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE  
3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE.  
4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.  
# BÀI LÀM
1) DLL — QuadraticSolverLib (Class Library .NET 2.0)  
DLL (Dynamic Link Library): thư viện chứa logic xử lý, không tự chạy mà được ứng dụng khác gọi.  
Thiết kế độc lập, chỉ nhận input qua thuộc tính và trả output qua thuộc tính hoặc hàm.  
Bài toán lựa chọn: tạo ma trận Magic Square (ma phương).
 <img width="1916" height="1070" alt="image" src=/github.com/user-attachments/assets/44a2d11a-9750-442e-aa49-5e5acc87ea56" />
#2. Console Application  "https:/
Ứng dụng dòng lệnh (đen sì).  
Người dùng nhập N, chương trình gọi DLL để tính và in kết quả ra màn hình.  
Ưu điểm: đơn giản, dễ kiểm thử, chạy nhanh.  
<img width="1911" height="1063" alt="image" src="https://github.com/user-attachments/assets/8c6ed7de-edb2-4499-8c9e-e0a8589ded87" />

#3. Windows Forms Application  
Ứng dụng desktop có giao diện cửa sổ.  
Dùng các control (TextBox, Button) để nhập N, gọi DLL, hiển thị kết quả.  
Thân thiện với người dùng, dễ sử dụng.  
<img width="1911" height="972" alt="image" src="https://github.com/user-attachments/assets/d19921e2-1f9e-4783-9fe2-127e646f9de5" />  

#4. Web Application (ASP.NET WebForms)  
Ứng dụng web chạy trên IIS.  
index.html + JS: nhập dữ liệu, gửi request AJAX.  
api.aspx.cs: nhận request, gọi DLL, trả kết quả JSON.  
JS client: nhận JSON và cập nhật giao diện.  
Có thể tạo domain giả bằng file hosts để chạy trên máy cục bộ.  
<img width="1919" height="1063" alt="image" src="https://github.com/user-attachments/assets/3813483f-b874-4700-926a-c9bf345ea9ea" />   

#kết quả  
<img width="865" height="643" alt="image" src="https://github.com/user-attachments/assets/59041958-bc34-4da7-874b-d19983fbc926" />  

#Kiểm tra nhanh (test cases)
<img width="848" height="676" alt="image" src="https://github.com/user-attachments/assets/4d61b060-4a60-438b-aeab-b5a45420058f" />  
<img width="1900" height="988" alt="image" src="https://github.com/user-attachments/assets/93564511-7ecc-48aa-a0c2-2175a2f36cbc" />  
<img width="860" height="675" alt="image" src="https://github.com/user-attachments/assets/f4a62df3-76f6-4d28-b9e9-1700d387de75" />  


