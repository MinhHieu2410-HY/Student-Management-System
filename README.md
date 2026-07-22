# Student-Management-System

# Hệ Thống Quản Lý Trường Học

## Giới thiệu đề tài

* **Bài toán:** Xây dựng hệ thống quản lý trường học trên nền tảng Windows Forms nhằm hỗ trợ quản lý học sinh, giáo viên, môn học, lớp học và tài khoản người dùng.
* **Mục tiêu:** Phát triển một ứng dụng desktop giúp đơn giản hóa công tác quản lý dữ liệu trong nhà trường, giảm thao tác thủ công và tăng hiệu quả quản lý.
* **Ý nghĩa thực tiễn:** Hỗ trợ cán bộ quản lý và giáo viên theo dõi thông tin học sinh, giáo viên và các lớp học thông qua giao diện trực quan, dễ sử dụng.

---

## Chức năng chính

* Đăng nhập và phân quyền người dùng (Admin, Teacher).
* Quản lý học sinh.
* Quản lý giáo viên.
* Quản lý môn học.
* Quản lý lớp học.
* Quản lý tài khoản người dùng.
* Tìm kiếm và lọc dữ liệu.
* Thêm, sửa, xóa dữ liệu.
* Kiểm tra tính hợp lệ của dữ liệu (Email, Số điện thoại, Ngày sinh,...).
* Xuất dữ liệu ra CSV, Excel, Word và PDF.
* Menu chuột phải hỗ trợ thao tác nhanh trên bảng dữ liệu.

---

## Công nghệ sử dụng

* **Ngôn ngữ:** C#
* **Framework:** .NET 8 - Windows Forms (WinForms)
* **Cơ sở dữ liệu:** Microsoft SQL Server
* **Kết nối CSDL:** ADO.NET (`Microsoft.Data.SqlClient`)
* **IDE:** Visual Studio 2022

---

## Kiến trúc hệ thống

Hệ thống được chia thành các module riêng biệt:

* **Login:** Xác thực người dùng và phân quyền.
* **Students:** Quản lý thông tin học sinh.
* **Teachers:** Quản lý thông tin giáo viên.
* **Subjects:** Quản lý môn học.
* **Classes:** Quản lý lớp học.
* **Users:** Quản lý tài khoản.
* **Open.cs:** Xử lý kết nối cơ sở dữ liệu, truy vấn và xuất dữ liệu.
* **ComboCus:** Điều khiển ComboBox tùy chỉnh phục vụ giao diện.

---

## Cơ sở dữ liệu

* **Hệ quản trị:** Microsoft SQL Server.
* **Các bảng chính:**

  * Students
  * Teachers
  * Subjects
  * Classes
  * Users
* **Stored Procedures:**

  * GetStudents
  * GetTeacher
  * GetClass
  * GetSubject
  * GetAccount

---

## Hướng dẫn cài đặt

### Yêu cầu

* Visual Studio 2022 hoặc mới hơn.
* .NET 8 SDK.
* Microsoft SQL Server.

### Cài đặt

1. Clone repository:

```bash
git clone https://github.com/MinhHieu2410-HY/Student-Management-System.git
```

2. Mở Solution bằng Visual Studio.

3. Restore các NuGet Packages.

4. Cập nhật **Connection String** trong `Open.cs` và `DataShow.cs` theo máy của bạn.

5. Khởi tạo cơ sở dữ liệu **DataWDFEND** cùng các Stored Procedure cần thiết.

---

## Hướng dẫn chạy

* Build Solution.
* Nhấn **Start** hoặc **F5** để chạy chương trình.
* Đăng nhập bằng tài khoản hợp lệ.
* Hệ thống sẽ hiển thị giao diện tương ứng với quyền của người dùng.

---

## Cấu trúc thư mục

```text
Student-Management-System/
│
├── DataShow.cs
├── Login.cs
├── Open.cs
├── ComboCus.cs
│
├── Subject/
│
├── Register/
│
├── Properties/
│
├── Resources/
│
├── README.md
└── .gitignore
```

---

## Hạn chế

* Chưa hỗ trợ Web hoặc Mobile.
* Connection String được khai báo trực tiếp trong mã nguồn.
* Chưa có chức năng kiểm thử tự động.
* Chưa triển khai CI/CD.
* Chưa hỗ trợ Migration hoặc Seed dữ liệu.

---

## Hướng phát triển

* Đưa Connection String vào file cấu hình.
* Mã hóa mật khẩu người dùng.
* Bổ sung chức năng báo cáo thống kê.
* Áp dụng Repository Pattern để dễ bảo trì.
* Thêm Logging và xử lý lỗi chi tiết.
* Xây dựng bộ kiểm thử tự động.

---

## Tác giả

* **Họ tên:** Nguyễn Minh Hiếu
* **Mã SV:** 12423049
