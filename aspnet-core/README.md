# Quy Định và Hướng Dẫn Phát Triển Dự Án

## Quy Định Chung

### 1. Nguyên Tắc Bảo Toàn Code
- ⚠️ **KHÔNG** được phép xóa code hiện có trong dự án
- Chỉ được phép phát triển và mở rộng thêm tính năng mới
- Nếu cần sửa đổi logic, phải giữ nguyên code cũ và tạo phiên bản mới

### 2. Quy Định Về Comment
- Mọi chức năng mới thêm vào **BẮT BUỘC** phải có comment giải thích
- Format comment chuẩn:

/**
 * @description Mô tả chức năng của đoạn code
 * @param {type} paramName - Mô tả tham số
 * @return {type} - Mô tả giá trị trả về
 * @author - Tên người phát triển
 * @date - Ngày phát triển
 */

### 3. Quy Trình Phát Triển
1. Tạo nhánh mới cho tính năng cần phát triển
2. Viết code và comment đầy đủ
3. Tạo Pull Request
4. Chờ review và approval

### 4. Cấu Trúc Comment Cho Tính Năng Mới

// ===== PHẦN MỚI PHÁT TRIỂN =====
// Người phát triển: [Tên]
// Ngày: [DD/MM/YYYY]
// Mô tả: [Chi tiết chức năng]
// ==============================

## Hướng Dẫn Cho Người Mới

### 1. Quy Trình Làm Việc
1. Đọc kỹ documentation hiện có
2. Tìm hiểu cấu trúc code
3. Tuân thủ quy định về comment và phát triển
4. Tạo PR cho mỗi tính năng mới

### 2. Tips Quan Trọng
- Luôn giữ nguyên code cũ
- Comment rõ ràng, chi tiết
- Code phải follow coding convention của dự án


