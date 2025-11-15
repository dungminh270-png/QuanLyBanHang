USE QLBanHang;
GO

-- Chỉ thêm cột MaDN nếu chưa tồn tại
IF NOT EXISTS (
    SELECT 1 
    FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'KhachHang' AND COLUMN_NAME = 'MaDN'
)
BEGIN
    ALTER TABLE KhachHang
    ADD MaDN NVARCHAR(50) NOT NULL DEFAULT('');
    PRINT 'Đã thêm cột MaDN thành công!';
END
ELSE
    PRINT 'Cột MaDN đã tồn tại. Bỏ qua.';

-- Chỉ thêm cột MatKhau nếu chưa tồn tại
IF NOT EXISTS (
    SELECT 1 
    FROM INFORMATION_SCHEMA.COLUMNS 
    WHERE TABLE_NAME = 'KhachHang' AND COLUMN_NAME = 'MatKhau'
)
BEGIN
    ALTER TABLE KhachHang
    ADD MatKhau NVARCHAR(50) NOT NULL DEFAULT('');
    PRINT 'Đã thêm cột MatKhau thành công!';
END
ELSE
    PRINT 'Cột MatKhau đã tồn tại. Bỏ qua.';