# SWP391-BOOK-WEBSITE
SWP391 assignment, a book website

## Members

* Lê Đình Đăng Khoa
* Võ Đại lâm
* Trịnh Hoàng Minh
* Trương Tuấn Thành
* Lê Trung Nghĩa

## Project's Description


# Mô tả chức năng chính của Admin
* /admin/users-management : Hiển thị toàn bộ tài khoản của Reader
* /comics : Hiển thị toàn bộ Comic
* /admin/user-chapter-reviews/{userId:guid?}/details/ : Quản lý review chapter(chương truyện) của 1 Reader cụ thể
* /admin/user-comic-reviews/{userId:guid?}/details/ : Quản lý review comic (truyện) của 1 Reader cụ thể
* /admin/user-comic-like/{userId:guid?}/details/ : Xem Reader đã like truyện nào
* /admin/transaction-history/{userId:guid?}/details/ : Quản lý toàn bộ lịch sử giao dịch của 1 Reader cụ thể
* /admin/chapter-reviews/ : Hiển thị toàn bộ review chapter(chương truyện) của tất cả Reader
* /admin/user-comic-like/ : Hiển thị toàn bộ các Reader đã like truyện nào
* /admin/user-comic-reviews/ : Hiển thị toàn bộ các Reader đã review truyện nào
* /admin/user-create : Chức năng tạo Reader của Admin
* /admin/users-management/{userId:guid?}/ : Quản lý Reader và có chức năng CRUD
* /admin/transaciton-history : Hiển thị toàn bộ lịch sử giao dịch của mọi Reader
* /admin/users-management/update/{userId:guid?}/ : Cập nhật thông tin Reader
* /hang-muc : Xem Category của mọi Comic

# Mô tả chức năng chính của Reader
* /auth/signup : Đăng ký trở thành Reader
* /truyen-tranh/{ComicIdentifier:guid} : Xem chi tiết của 1 Comic
* /user/logout : Đăng xuất khỏi tài khoản
* /auth/login : Đăng Nhập vào tài khoản
  
  

# References

Tham khảo các nguồn ngoài


