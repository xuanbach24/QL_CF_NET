drop database QL_QUANCAFE
go
--============================TẠO DATABASE=========================
CREATE DATABASE QL_QUANCAFE
GO
USE QL_QUANCAFE
GO

--============================TẠO BẢNG NHÂN VIÊN=======================
CREATE TABLE NHANVIEN
(
    MANV CHAR(10) NOT NULL PRIMARY KEY, -- Mã của nhân viên
    TENNV NVARCHAR(100) NOT NULL, -- Tên của nhân viên
    GIOITINH NVARCHAR(5) CHECK (GIOITINH IN (N'Nam', N'Nữ')), -- Giới tính của nhân viên
    CHUCVU NVARCHAR(30), -- Chức vụ của nhân viên
    NGAYVAOLAM DATE NOT NULL DEFAULT GETDATE(), -- Ngày vào làm của nhân viên, mặc định là ngày hiện tại
    DIACHI NVARCHAR(100), -- Địa chỉ của nhân viên
    SDT CHAR(15) UNIQUE, -- Số điện thoại của nhân viên, phải là duy nhất,
	MATKHAU CHAR(30)
);


--============================TẠO BẢNG NHÀ CUNG CẤP========================
CREATE TABLE NHACUNGCAP
(
    MANCC CHAR(10) PRIMARY KEY NOT NULL, -- Mã của nhà cung cấp
    TENNCC NVARCHAR(50) NOT NULL, -- Tên của nhà cung cấp
    DIACHI NVARCHAR(50), -- Địa chỉ của nhà cung cấp
    SDT CHAR(10) UNIQUE CHECK (LEN(SDT) = 10) -- Số điện thoại của nhà cung cấp, phải là duy nhất và có độ dài chính xác 10 ký tự
);

--==============================TẠO BẢNG HÓA ĐƠN NHẬP HÀNG=============================================
CREATE TABLE HOADONNHAPHANG (
    MAHDNH CHAR(10) PRIMARY KEY,          -- Mã hóa đơn nhập hàng (khóa chính, 10 ký tự)
    MANV CHAR(10) NOT NULL,               -- Mã nhân viên thực hiện nhập hàng (khóa ngoại đến bảng NHANVIEN)
    NGAYHBNH DATE DEFAULT GETDATE(),      -- Ngày hóa đơn nhập hàng (mặc định là ngày hiện tại)
    FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV) -- Liên kết khóa ngoại với bảng NHANVIEN, đảm bảo MANV có trong bảng NHANVIEN
);
--==============================TẠO BẢNG LOẠI HÀNG=====================================
CREATE TABLE LOAIHANG (
    MALH CHAR(10) PRIMARY KEY,       -- Mã loại hàng hóa (khóa chính, 10 ký tự)
    TENLH NVARCHAR(50) NOT NULL,     -- Tên loại hàng hóa (chuỗi Unicode, tối đa 50 ký tự, bắt buộc nhập)
    MOTA NVARCHAR(100)               -- Mô tả loại hàng hóa (chuỗi Unicode, tối đa 100 ký tự)
);
--============================TẠO BẢNG NGUYÊN LIỆU====================
CREATE TABLE NGUYENLIEU(
	MANL CHAR(10) NOT NULL PRIMARY KEY,       --mã nguyên liệu
	TENNL NVARCHAR(50),                       --tên nguyên liệu
	MANCC CHAR(10),     
    MALH CHAR(10), -- Mã loại hàng
	GIATIEN INT,                             ---gá tiền của nguyên liệu
	FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP(MANCC),-- Liên kết với bảng NHACUNGCAP
	FOREIGN KEY (MALH) REFERENCES LOAIHANG(MALH)
)

--============================TẠO BẢNG CHI TIẾT NHẬP HÀNG========================
CREATE TABLE CHITIETNHAPHANG(
    MANL CHAR(10) NOT NULL, -- Mã hàng hóa
    MAHDNH CHAR(10) NOT NULL, -- Mã hóa đơn nhập hàng
    SOLUONG INT CHECK (SOLUONG > 0), -- Số lượng hàng hóa phải lớn hơn 0
    THANHTIEN INT CHECK (THANHTIEN >= 0), -- Thành tiền không âm
    FOREIGN KEY (MANL) REFERENCES NGUYENLIEU(MANL), -- Liên kết với bảng NGUYENLIEU
    FOREIGN KEY (MAHDNH) REFERENCES HOADONNHAPHANG(MAHDNH) -- Liên kết với bảng HOADONNHANHANG
);

--============================TẠO BẢNG KHO========================
CREATE TABLE KHO
(
    MAHH CHAR(10) PRIMARY KEY NOT NULL, -- Mã hàng hóa
	MANL CHAR(10),
    TENHH NVARCHAR(50) NOT NULL, -- Tên hàng hóa
    GIASP INT CHECK (GIASP >= 0), -- Giá sản phẩm, không âm
	SOLUONGTON INT,
	FOREIGN KEY (MANL) REFERENCES NGUYENLIEU(MANL), -- Liên kết với bảng NGUYENLIEU
);

--===============================TẠO BẢNG BÀN=====================
CREATE TABLE BAN (
    MABAN CHAR(10) PRIMARY KEY,               -- Mã bàn (khóa chính)
    TENBAN NVARCHAR(100) NOT NULL,       -- Tên bàn
    THUOCTINH NVARCHAR(50) CHECK (THUOCTINH IN ('0','1'))    -- Thuộc tính chỉ nhận trong 2 giá trị 0 VÀ  1 VỚI 0 LÀ CHƯA CÓ KHÁCH, 1 LÀ ĐANG CÓ KHÁCH
  
);

--==============================TẠO BẢNG HÓA ĐƠN BÁN HÀNG==============================
CREATE TABLE HOADONBANHANG (
    MAHDBH CHAR(10) PRIMARY KEY,              -- Mã hóa đơn (khóa chính)
    MANV CHAR(10) NOT NULL,                            -- Mã nhân viên (liên kết với bảng NhanVien)
    MABAN CHAR(10),                           -- Mã bàn (liên kết với bảng Bàn)
	NGAYHD DATE DEFAULT GETDATE(),       -- Ngày lập hóa đơn (mặc định là ngày hiện tại)
    TONGTIEN INT CHECK (TONGTIEN >= 0),   -- Tổng tiền của hóa đơn
    GIAMGIA INT CHECK (GIAMGIA >= 0),              -- Số tiền giảm giá
    FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV), -- Liên kết khóa ngoại đến bảng NhanVien
    FOREIGN KEY (MABAN) REFERENCES BAN(MABAN)     -- Liên kết khóa ngoại đến bảng Ban
);

--==============================TẠO BẢNG CHI TIẾT BÁN HÀNG====================================
CREATE TABLE CHITIETBANHANG (
    MAHDBH CHAR(10) NOT NULL,         -- Mã hóa đơn bán hàng (khóa ngoại, 10 ký tự)
    MAHH CHAR(10) NOT NULL,           -- Mã hàng hóa (khóa ngoại, 10 ký tự)
    SOLUONG INT NOT NULL,             -- Số lượng hàng hóa được bán
    FOREIGN KEY (MAHDBH) REFERENCES HOADONBANHANG(MAHDBH), -- Liên kết khóa ngoại với bảng HOADONBANHANG
    FOREIGN KEY (MAHH) REFERENCES KHO(MAHH)            -- Liên kết khóa ngoại với bảng MENU
);

----====================TẠO BẢNG CA LÀM VIỆC========================
CREATE TABLE CALAMVIEC
(
    MACLV CHAR(50) NOT NULL PRIMARY KEY, -- Mã ca làm việc
    TENCLA NVARCHAR(100) NOT NULL, -- Tên ca làm việc
    GIOBD TIME NOT NULL, -- Giờ bắt đầu
    GIOKT TIME NOT NULL, -- Giờ kết thúc
    SOTIEN INT CHECK (SOTIEN >= 0) -- Số tiền, không âm
);
---===================TẠO BẢNG CHI TIẾT LƯƠNG NHÂN VIÊN======================
CREATE TABLE CHITIETLUONGNHANVIEN
(
    MACLV CHAR(50) NOT NULL, -- Mã chi tiết lương
    MANV CHAR(10) NOT NULL, -- Mã nhân viên
    TONGSOCALAMTRONGTHANG INT CHECK (TONGSOCALAMTRONGTHANG >= 0), -- Tổng số ca làm trong tháng
    LUONGTRONGTHANG INT,
    FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV), -- Liên kết với bảng NHANVIEN
	FOREIGN KEY (MACLV) REFERENCES CALAMVIEC(MACLV) -- Liên kết với bảng CALAMVIEC
);


--============================NHẬP DỮ LIỆU BẢNG NHÂN VIÊN========================
INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, CHUCVU, NGAYVAOLAM, DIACHI, SDT,MATKHAU)
VALUES
('NV001', N'Nguyễn Văn Anh', N'Nam', N'Nhân viên', '2024-01-15', N'123 Đường Nguyễn Trãi, Quận 1, TP.HCM', '0912345678','123'),
('NV002', N'Trần Thị Bé', N'Nữ', N'Nhân viên', '2023-02-20', N'456 Đường Tố Hữu, Quận 2, TP.HCM', '0923456789','123'),
('NV003', N'Lê Văn Cường', N'Nam', N'Nhân viên', '2024-12-01', N'789 Đường CMT8, Quận 3, TP.HCM', '0934567890','123'),
('NV004', N'Lê Trọng Văn', N'Nam', N'Nhân viên', '2023-07-30', N'07 Đường Độc Lập, Quận Tân Phú, TP.HCM', '0937894567','123'),
('NV005', N'Tô Anh', N'Nam', N'Nhân viên', '2023-03-10', N'89 Đường Hùng Vương, Quận 5, TP.HCM', '0364895135','123'),
('NV006', N'Đỗ Huỳnh Khánh Nhi', N'Nữ', N'Quản Lý', '2022-03-10', N'78 Đường Nguyễn Văn Trỗi, Quận Phú Nhuận, TP.HCM', '0347289584','123'),
('NV007', N'Trần Thanh Trúc', N'Nữ', N'Nhân viên', '2024-08-10', N'10 Đường Lê Duẩn, Quận 1, TP.HCM', '0978157863','123'),
('NV008', N'Phạm Bảo Trâm', N'Nữ', N'Nhân viên', '2023-09-15', N'05 Đường Nguyễn Du, Quận 1, TP.HCM', '0996541236','123'),
('NV009', N'Phạm Xuân Bách', N'Nam', N'Nhân viên', '2023-10-21', N'125 Đường Cộng Hòa, Quận Tân Bình, TP.HCM', '0354862514','123');
--==========================NHẬP DỮ LIỆU BẢNG CA LÀM VIỆC===================================
INSERT INTO CALAMVIEC (MACLV, TENCLA, GIOBD, GIOKT, SOTIEN)
VALUES
('CL001', N'Ca Sáng', '07:00:00', '15:00:00', 184000),
('CL002', N'Ca Chiều', '15:00:00', '23:00:00', 184000);
--=======================NHẬP DỮ LIỆU BẢNG CHI TIẾT LƯƠNG NHÂN VIÊN===================================================
INSERT INTO CHITIETLUONGNHANVIEN (MACLV, MANV, TONGSOCALAMTRONGTHANG)
VALUES
('CL001', 'NV001', 20),
('CL002', 'NV002', 22),
('CL001', 'NV003', 18),
('CL001', 'NV004', 19),
('CL002', 'NV005', 11),
('CL002', 'NV006', 26),
('CL001', 'NV007', 15),
('CL002', 'NV008', 18),
('CL001', 'NV009', 14);


--======================NHẬP DỮ LIỆU BẢNG NHÀ CUNG CẤP==========================================
INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI, SDT)
VALUES
('NCC001', N'Cao Nguyên', N'140 Lê Đại Hành,Quận 5', '0912345678'),
('NCC002', N'Bắc Đẩu', N'01 Trần Đại Nghiã,Quận 2', '0348654711');
---==============================NHẬP DỮ LIỆU HÓA ĐƠN NHẬP HÀNG===============================

INSERT INTO HOADONNHAPHANG (MAHDNH, MANV, NGAYHBNH)
VALUES
('HD001', 'NV001', '2024-09-15'),
('HD002', 'NV002', '2024-09-16'),
('HD003', 'NV003', DEFAULT),  -- Sử dụng giá trị mặc định của NGAYHBNH
('HD004', 'NV001', '2024-09-17'),
('HD005', 'NV004', DEFAULT);  -- Sử dụng giá trị mặc định của NGAYHBNH

--==========================NHẬP DỮ LIỆU LOẠI HÀNG================================
INSERT INTO LOAIHANG (MALH, TENLH, MOTA)
VALUES
('LH001', N'Nước uống', N'Các sản phẩm như cà phê,nước ép,....'),
('LH002', N'Bánh', N'Các sản phẩm như bánh ngọt,bánh mì......');

--============================NHẬP DỮ LIỆU BẢNG NGUYÊN LIỆU==============
INSERT INTO NGUYENLIEU (MANL,MALH, TENNL, MANCC,GIATIEN)
VALUES
('NL001','LH001',N'Sữa Vinamilk' , 'NCC001',30000),
('NL002','LH001',N'Trà cozy' , 'NCC002', 50000),
('NL003','LH001',N'Syrup' , 'NCC001', 70000),
('NL004','LH002',N'Bánh mì' , 'NCC001', 29000),
('NL005','LH002',N'Bánh ngọt' , 'NCC002',39000),
('NL006','LH001',N'Nước ép' , 'NCC001', 45000),
('NL007','LH001',N'Cà phê' , 'NCC001', 200000),
('NL008','LH001',N'Bò Húc' , 'NCC002', 150000);

---============================NHẬP DỮ LIỆU BẢNG CHI TIẾT NHẬP HÀNG======================================
INSERT INTO CHITIETNHAPHANG (MANL, MAHDNH, SOLUONG, THANHTIEN)
VALUES
('NL001', 'HD001', 20, 600000),
('NL002', 'HD005', 30, 1500000),
('NL003', 'HD001', 10, 700000),
('NL004', 'HD003', 15, 585000),
('NL005', 'HD002', 40, 1160000),
('NL006', 'HD004', 10, 450000),
('NL007', 'HD001', 70, 14000000),
('NL008', 'HD002', 25, 3750000);


--===============================NHẬP DỮ LIỆU BẢNG BÀN=====================================
INSERT INTO BAN (MABAN, TENBAN, THUOCTINH)
VALUES
('B001', N'Bàn 1', N'0'),
('B002', N'Bàn 2', N'0'),
('B003', N'Bàn 3', N'0'),
('B004', N'Bàn 4', '0'),
('B005', N'Bàn 5', '0'),
('B006', N'Bàn 6', '0'),
('B007', N'Bàn 7', '0'),
('B008', N'Bàn 8', '0'),
('B009', N'Bàn 9', '0'),
('B010', N'Bàn 10', '0'),
('B011', N'Bàn 11', '0'),
('B012', N'Bàn 12', '0');

---========================NHẬP DỮ LIỆU BẢNG MENU=====================================
INSERT INTO KHO(MAHH, MANL, TENHH, GIASP,SOLUONGTON)
VALUES
('HH001','NL001',N'Sữa Vinamilk',40000,20),
('HH002','NL002',N'Trà cozy' ,55000,30),
('HH003','NL003',N'Syrup' ,75000,10),
('HH004','NL004',N'Bánh mì' ,35000,15),
('HH005','NL005',N'Bánh ngọt' ,45000,40),
('HH006','NL006',N'Nước ép' ,50000,10),
('HH007','NL007',N'Cà phê' ,250000,75),
('HH008','NL008',N'Bò Húc' ,200000,25);


--==============================NHẬP DỮ LIỆU BẢNG HÓA ĐƠN BÁN HÀNG==============================
INSERT INTO HOADONBANHANG (MAHDBH, MANV, MABAN, NGAYHD, TONGTIEN, GIAMGIA)
VALUES 
('HDBH001', 'NV001', 'B001', '2024-08-14', 300000, 0),
('HDBH002', 'NV002', 'B002', '2024-09-15', 275000, 50000),

--==============================NHẬP DỮ LIỆU BẢNG CHI TIẾT BÁN HÀNG====================================
INSERT INTO CHITIETBANHANG (MAHDBH, MAHH, SOLUONG)
VALUES
('HDBH001', 'HH001', 10),  -- Mã hóa đơn là HDB001, mã hàng hóa là HH001, số lượng là 10
('HDBH002', 'HH002', 5),   -- Mã hóa đơn là HDB002, mã hàng hóa là HH002, số lượng là 5





---===================FUNCTION====================
--NHI
---1. VIẾT HÀM TRUYỀN VÀO MÃ NHÂN VIÊN VÀ TÍNH SÔ NGÀY LÀM VIỆC CỦA NHÂN VIÊN ĐÓ ĐẾN NAY
CREATE FUNCTION TinhSoNgayLamViec (@MANV NVARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @NGAYVAOLAM DATE;
    DECLARE @HOMNAY DATE = GETDATE();
    DECLARE @SODAYLAM INT;

    -- Lấy ngày vào làm của nhân viên
    SELECT @NGAYVAOLAM = NGAYVAOLAM
    FROM NHANVIEN
    WHERE MANV = @MANV;

    -- Tính số ngày làm việc từ ngày vào làm đến hôm nay
    SET @SODAYLAM = DATEDIFF(DAY, @NGAYVAOLAM, @HOMNAY);

    RETURN @SODAYLAM;
END;
--thực thi
DECLARE @SONGAYLAM INT
SET @SONGAYLAM=DBO.TinhSoNgayLamViec('NV001')
PRINT @SONGAYLAM

--2. Viết hàm truyền vào tham số mã nhà cung cấp,trả về bảng chứa danh sách các mặt hàng đã nhập của nhà cung cấp đó
--(MÃ NGUYÊN LIỆU,TÊN NGUYÊN LIỆU,TỔNG SỐ LƯỢNG)
CREATE FUNCTION DSMATHANG (@MANCC CHAR(10))
RETURNS TABLE
AS
	RETURN SELECT NGUYENLIEU.MANL,TENNL,SOLUONG
	FROM NGUYENLIEU,CHITIETNHAPHANG
	WHERE NGUYENLIEU.MANL=CHITIETNHAPHANG.MANL
	AND @MANCC=MANCC
	

	--THỰC THI
SELECT * FROM DBO.DSMATHANG ('NCC001')
--3.Viết hàm truyền vào tham số mã nhân viên, tính lương của nhân viên đó
CREATE FUNCTION TIENLUONG(@MANV CHAR(10))
RETURNS INT
AS
BEGIN
	DECLARE @TIENLUONG INT
	IF NOT EXISTS (SELECT * FROM NHANVIEN WHERE MANV = @MANV)
	RETURN -1

	SELECT @TIENLUONG = SUM(TONGSOCALAMTRONGTHANG * SOTIEN)
	FROM CHITIETLUONGNHANVIEN,CALAMVIEC
	WHERE CHITIETLUONGNHANVIEN.MACLV=CALAMVIEC.MACLV AND MANV = @MANV
	RETURN @TIENLUONG
END

	--THỰC THI
DECLARE @TL MONEY
SET @TL = DBO.TIENLUONG('NV001')
IF @TL = -1
	PRINT N'MA NHAN VIEN KHONG TON TAI'
ELSE
	PRINT N'TIEN LUONG LA: '+ CAST (@TL AS NVARCHAR(50)) + ' VND'
--
--BÁCH
---5.Tạo một Function để tính tổng số lượng hàng hóa đã bán ra trong tháng và tính doanh thu của từng mặt hàng.
CREATE FUNCTION DOANHTHUHH(@THANG INT,@NAM INT)
RETURNS TABLE 
AS
RETURN SELECT KHO.MAHH,TENHH,SUM(CHITIETBANHANG.SOLUONG) AS N'SỐ LƯỢNG BÁN',KHO.GIASP,GIAMGIA,SUM(CHITIETBANHANG.SOLUONG)*(KHO.GIASP)-SUM(HOADONBANHANG.GIAMGIA) AS N'DOANH THU'
		FROM KHO,CHITIETBANHANG, HOADONBANHANG
		WHERE KHO.MAHH= CHITIETBANHANG.MAHH AND HOADONBANHANG.MAHDBH=CHITIETBANHANG.MAHDBH AND MONTH(NGAYHD) = @THANG AND YEAR(NGAYHD)=@NAM
		GROUP BY KHO.MAHH,TENHH,SOLUONG,KHO.GIASP,GIAMGIA
-- THỰC THI
SELECT * FROM DBO.DOANHTHUHH(9,2024)

--6.--Tạo một Function để trả về nhân viên có danh thu cao nhất TRONG THÁNG, kèm theo tổng doanh thu của họ
CREATE FUNCTION DOANHTHUNVCAONHAT(@THANG INT,@NAM INT)
RETURNS TABLE
AS
RETURN SELECT NHANVIEN.MANV,TENNV,CHUCVU, SUM(TONGTIEN)-SUM(GIAMGIA) AS N'DOANH THU'
		FROM NHANVIEN,HOADONBANHANG 
		WHERE NHANVIEN.MANV=HOADONBANHANG.MANV AND MONTH(NGAYHD) = @THANG AND YEAR(NGAYHD)=@NAM
		GROUP BY NHANVIEN.MANV,TENNV,CHUCVU,GIAMGIA
		HAVING SUM(TONGTIEN)-SUM(GIAMGIA) >=ALL (SELECT SUM(TONGTIEN)-SUM(GIAMGIA)
												FROM HOADONBANHANG 
												WHERE MONTH(NGAYHD) = @THANG AND YEAR(NGAYHD)=@NAM
												GROUP BY MANV)
---THỰC THI
SELECT * FROM DBO.DOANHTHUNVCAONHAT(9,2024)
--VI
--8.Viết hàm tính tổng tiền hang của 1 khách 
CREATE FUNCTION TinhTongTienKhachHang (@MAKH CHAR(10))
RETURNS DECIMAL(18, 2)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18, 2);
    
    SELECT @TongTien = SUM(TONGTIEN)
    FROM HOADONBANHANG
    WHERE MAKH = @MAKH;
    
    RETURN ISNULL(@TongTien, 0);
END;
---------THỰC THI--------
SELECT dbo.TinhTongTienKhachHang('KH002') AS TongTienDaMua;

----9.so luong ban ra theo sp
CREATE FUNCTION TinhSoLuongBanRaTheoMatHang (@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN (
    SELECT
        KHO.MAHH,
        KHO.TENHH,
        SUM(ChiTietBanHang.SoLuong) AS TongSoLuongBan
    FROM ChiTietBanHang
    JOIN KHO ON ChiTietBanHang.MAHH = KHO.MAHH
    JOIN HOADONBANHANG ON ChiTietBanHang.MAHDBH = HOADONBANHANG.MAHDBH
    WHERE MONTH(HOADONBANHANG.NGAYHD) = @Thang AND YEAR(HOADONBANHANG.NGAYHD) = @Nam
    GROUP BY KHO.MAHH,KHO.TENHH
);
---thực thi
SELECT * 
FROM dbo.TinhSoLuongBanRaTheoMatHang( 8, 2024);
--ĐẠT
--10.------------mặt hàng chạy nhất
CREATE FUNCTION MatHangBanChayNhat (@Thang INT, @Nam INT)
RETURNS TABLE
AS
RETURN (
    SELECT
        KHO.MAHH,
        KHO.TENHH,
        SUM(ChiTietBanHang.SoLuong) AS TongSoLuongBan
    FROM ChiTietBanHang
    JOIN KHO ON ChiTietBanHang.MAHH = KHO.MAHH
    JOIN HOADONBANHANG ON ChiTietBanHang.MAHDBH = HOADONBANHANG.MAHDBH
    WHERE MONTH(HOADONBANHANG.NGAYHD) = @Thang AND YEAR(HOADONBANHANG.NGAYHD) = @Nam
    GROUP BY KHO.MAHH,KHO.TENHH
);
-----thực thi
SELECT * FROM MatHangBanChayNhat(10, 2024);
--VINH
--11. Tạo 1 function trả về tên khách hàng, địa chỉ, số điện thoại, loại khách hàng từ 1 hóa đơn bán hàng
create function THONGTINKHACHHANGTUHOADON (@MAHDBH CHAR(50))
RETURNS TABLE
AS
RETURN
(
	SELECT 
		KH.TENKH,
		KH.DIACHI,
		KH.SDT,
		LKH.TENLKH AS LOAIKHACHHANG
	FROM KHACHHANG KH, LOAIKHACHHANG LKH, HOADONBANHANG HDBH
	WHERE HDBH.MAKH = KH.MAKH AND LKH.MALKH = KH.MALKH AND HDBH.MAHDBH = @MAHDBH
)
-----thực thi
-- Ví dụ: Lấy thông tin khách hàng từ hóa đơn có mã 'HDBH001'
SELECT * FROM THONGTINKHACHHANGTUHOADON('HDBH001');



---===================================PRODECURE=======================
--NHI--
--1.Viết thủ tục thêm 1 nhân viên vào bảng Nhân Viên với tham số truyền vào là mã nhân viên,tên nhân viên,mã chức vụ
--giới tính,ngày vào làm,địa chỉ,số điện thoại
CREATE PROC THEM1NV @MANV CHAR(10),@TENNV NVARCHAR(100), @GIOITINH NVARCHAR(5),@CHUCVU NVARCHAR(30), 
                    @NGAYVAOLAM DATE,@DIACHI NVARCHAR(100),@SDT CHAR(15),@MATKHAU CHAR(30)
AS
BEGIN
	INSERT INTO NHANVIEN VALUES(@MANV ,@TENNV, @GIOITINH ,@CHUCVU, 
                    @NGAYVAOLAM,@DIACHI,@SDT,@MATKHAU)
END
--THỰC THI
EXEC THEM1NV 'NV010', N'Phan Quang Đạt', N'Nam', N'Nhân viên', '2024-10-21', N'12 Đường Cộng Hòa, Quận Tân Bình, TP.HCM', '0354862554','123'
--2.xem hóa đơn khách hàng khi truyền vào mã khách hàng
CREATE PROC XEMHDKH @MAKH CHAR(10)
AS
BEGIN
	SELECT * FROM HOADONBANHANG WHERE @MAKH=MAKH
END
--THỰC THI
EXEC XEMHDKH 'KH001'
--3.VIẾT THỦ TỤC TĂNG GIÁ CỦA 1 THỨC UỐNG BẤT KÌ VỚI THAM SỐ TRUYỀN VÀO LÀ TÊN THỨC UÔNG VÀ HỆ SỐ GIÁ
--ĐIỀU KIỆN TÊN THỨC UỐNG PHẢI TỒN TẠI VÀ HỆ SỐ TĂNG GIÁ PHẢI NHỎ HƠN 1 ĐỒNG THỜI KHÔNG NHỎ HƠN 0.5
CREATE PROC TANGGIANUOC @TENHH NVARCHAR(50),@TANG FLOAT
AS
BEGIN
	IF EXISTS (SELECT * FROM KHO WHERE TENHH=@TENHH)
		IF(@TANG <=1 AND @TANG>=-0.5)
		UPDATE KHO SET GIASP=GIASP+GIASP*@TANG
		FROM KHO WHERE TENHH=@TENHH
		ELSE
		PRINT N'Lỗi,hệ số tăng quá 1'
	else
	print N'lỗi,không tồn tại thức uống này'
			
END
--THỰC THI
exec TANGGIANUOC N'Đá xay',0.5
exec TANGGIANUOC N'Cà phê đá',0.5

--VINH
--5.Viết thủ tục cập nhật địa chỉ và số điện thoại cho 1 nhân viên
CREATE PROCEDURE CNTHONGTINNHANVIEN @MANV CHAR(10), @DIACHI NVARCHAR(100), @SDT NVARCHAR(15)    
AS
BEGIN
    IF EXISTS (SELECT 'NV003' FROM NHANVIEN WHERE MANV = @MANV)
    BEGIN
        UPDATE NHANVIEN
        SET DIACHI = @DIACHI, SDT = @SDT
        WHERE MANV = @MANV;
        
        
        PRINT N'Cập nhật thông tin nhân viên thành công';
    END
    ELSE
    BEGIN
        PRINT N'Nhân viên không tồn tại';
    END
END;

---------THỰC THI--------
EXEC CNTHONGTINNHANVIEN 'NV003',N'23 Nguyễn Hữu Tiến, Quận Tân Phú, TP.HCM', '0909397979'
--BÁCH--
--6.Viết Thủ Tục Thêm Vào Một Menu vào bảng Menu truyền vào là (Mã hàng hóa, loại hàng,Tên Hàng Hóa,giá sản phẩm)

CREATE PROC THEM1MENU @MAHH CHAR(10),@LH CHAR(10),@TENHH NVARCHAR(50),@GIASP FLOAT
AS
BEGIN
	INSERT INTO MENU VALUES(@MAHH,@LH,@TENHH,@GIASP)
END
-- THỰC THI
EXEC THEM1MENU 'HH010','LH002',N'BÁNH SPOIL',20000
SELECT * FROM MENU
--7.VIẾT THỦ TỤC CHỈNH SỬA SỐ LƯỢNG HÀNG TRONG CHI TIẾT BÁN HÀNG VÀ TỰ ĐỘNG CẬP NHẬT TỔNG TIỀN DỰA VÀO SỐ LƯỢNG ĐÃ THAY ĐỔI, LƯU Í SL>0
ALTER PROC THAYDOISL @MAHDBH CHAR(10),@MAHH CHAR(10), @SOLUONG INT
AS
BEGIN
		IF(@SOLUONG>0)
		BEGIN
					---CAP NHAT LAI KHO
			DECLARE @SOLUONGCU INT
			SET @SOLUONGCU=(SELECT SOLUONG FROM CHITIETBANHANG WHERE MAHDBH=@MAHDBH AND MAHH=@MAHH)
			UPDATE KHO
			SET SOLUONGTON=(SOLUONGTON + @SOLUONGCU) - @SOLUONG 
			WHERE MAHH=@MAHH

			UPDATE CHITIETBANHANG 
			SET SOLUONG=@SOLUONG 
			WHERE MAHDBH=@MAHDBH and MAHH=@MAHH
			-- TỰ ĐỘNG CẬP NHẬT TỔNG TIỀN KHI SỐ LƯỢNG THAY ĐỔI
			UPDATE HOADONBANHANG 
			SET TONGTIEN=(SELECT SUM(SOLUONG*GIASP)
												FROM CHITIETBANHANG,KHO
												WHERE CHITIETBANHANG.MAHH=KHO.MAHH AND MAHDBH=@MAHDBH)
			WHERE MAHDBH=@MAHDBH

		END
	ELSE
		PRINT N'SỐ LƯỢNG PHẢI LỚN HƠN 0'
END
--THỰC THI
EXEC THAYDOISL 'HDBH002','HH002',8
SELECT * FROM CHITIETBANHANG
SELECT * FROM HOADONBANHANG

--VI--
-----8.cập nhật giá sp
CREATE PROCEDURE CapNhatGiaSanPham
    @MaHangHoa char(10),
    @GiaMoi DECIMAL(18, 2)
AS
BEGIN
    UPDATE KHO
    SET GIASP = @GiaMoi
    WHERE MAHH = @MaHangHoa;
END;
--- thực thi
EXEC CapNhatGiaSanPham 
    @MaHangHoa = 'HH001', 
    @GiaMoi = 27000;
SELECT * FROM KHO





--===============================TRIGGER======================================================
--NHI
--1.Kiểm tra lương nhân viên
CREATE TRIGGER TRG_KIEMTRA_LUONG
ON CHITIETLUONGNHANVIEN
FOR INSERT, UPDATE
AS
BEGIN
    
    IF EXISTS (
        SELECT *
        FROM inserted i
        JOIN CALAMVIEC c ON i.MACLV = c.MACLV
        WHERE i.TONGSOCALAMTRONGTHANG * c.SOTIEN < 184000
    )
    BEGIN
        
        PRINT N'Lương nhân viên phải lớn hơn hoặc bằng 184000 đồng!'
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
        PRINT N'Dữ liệu lương nhân viên hợp lệ.'
    END
END;
GO
INSERT INTO CHITIETLUONGNHANVIEN (MACLV, MANV, TONGSOCALAMTRONGTHANG)
VALUES ('CL001', 'NV009', 10); 
select * from CHITIETLUONGNHANVIEN
INSERT INTO CHITIETLUONGNHANVIEN (MACLV, MANV, TONGSOCALAMTRONGTHANG)
VALUES ('CL001', 'NV001', 0);
--VINH
--2.Tạo trigger để kiểm tra số lượng nguyên liệu mỗi khi cập nhật chi tiết nhập hang. Nếu số lượng thấp hơn ngưỡng nhất định, có thể tạo cảnh báo.
CREATE TRIGGER KTNguyenLieuNhap
ON CHITIETNHAPHANG
AFTER INSERT
AS
BEGIN
    DECLARE @MANL CHAR(10);
    DECLARE @NEW_SOLUONG INT;
    
    SELECT @MANL = MANL, @NEW_SOLUONG = SOLUONG FROM INSERTED;

    IF @NEW_SOLUONG < 10
    BEGIN
        PRINT N'Nguyên liệu ' + @MANL + N' có số lượng thấp hơn ngưỡng an toàn!';
    END;
END;
---------THỰC THI--------

UPDATE CHITIETNHAPHANG
SET SOLUONG = 5 	-- hoặc một số nhỏ hơn ngưỡng an toàn
WHERE MANL = 'NL001'; -- Thay thế bằng mã nguyên liệu phù hợp
--BÁCH
--3.VIẾT TRIGGER KIỂM TRA GIÁ SẢN PHẨM KHI THÊM HOẶC SỬA KHÔNG ĐƯỢC <=0 HOẶC NULL
CREATE TRIGGER KTGIASP ON KHO
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @GIASP FLOAT
	SET @GIASP = (SELECT GIASP FROM inserted)
	IF(@GIASP<=0 OR @GIASP IS NULL)
	BEGIN
		PRINT N'lỖI GIÁ SẢN PHẨM'
		ROLLBACK TRAN

	END
	ELSE
	BEGIN
		PRINT N'THÊM THÀNH CÔNG'
		COMMIT TRAN
	END
END

update menu
set GIASP=0
where MAHH='HH0010'
---THỰC THI
INSERT INTO MENU (MAHH, MALH, TENHH, GIASP)
VALUES
('HH0010', 'LH001', N'SUỐI',10)
select* from menu
--VI--
--4.--Trigger: Tự động cập nhật loại khách hàng dựa trên tổng tiền đã mua
CREATE TRIGGER trg_CapNhatLoaiKhachHang
ON HOADONBANHANG
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE KHACHHANG
    SET MALKH = 
        CASE
            WHEN dbo.TinhTongTienKhachHang(MAKH) >= 5000000 THEN 'LKH02'  -- VIP
            WHEN dbo.TinhTongTienKhachHang(MAKH) >= 3000000 THEN 'LKH04'  -- Ưu đãi
            WHEN dbo.TinhTongTienKhachHang(MAKH) >= 2000000 THEN 'LKH03'  -- Thân thiết
            WHEN dbo.TinhTongTienKhachHang(MAKH) >= 1000000 THEN 'LKH01'  -- Bình dân
			ELSE NULL -- Hoặc một mã mặc định nào đó
        END
    WHERE MAKH IN (SELECT MAKH FROM inserted);
END;
GO
SELECT * FROM KHACHHANG WHERE MAKH = 'KH001';
--ĐẠT
--5.-- Trigger tự động cập nhật thành tiền trong ChiTietNhapHang khi số lượng thay đổi
CREATE TRIGGER trg_CapNhatThanhTienNhap
ON CHITIETNHAPHANG
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật thành tiền cho các bản ghi mới được thêm hoặc cập nhật
    UPDATE CHITIETNHAPHANG
    SET THANHTIEN = I.SOLUONG * NL.GIATIEN
    FROM inserted I  -- Sử dụng bảng ảo "inserted" để truy cập dữ liệu mới
    JOIN NGUYENLIEU NL ON I.MANL = NL.MANL
    WHERE CHITIETNHAPHANG.MANL = I.MANL AND CHITIETNHAPHANG.MAHDNH = I.MAHDNH;
END;
GO

-- Thử nghiệm
INSERT INTO CHITIETNHAPHANG (MANL, MAHDNH, SOLUONG)  -- Không cần nhập THANHTIEN, trigger sẽ tự tính
VALUES ('NL001', 'HD002', 50);

SELECT * FROM CHITIETNHAPHANG WHERE MAHDNH = 'HD002' AND MANL = 'NL001';
go



--==================================CURSOR===============================================
--VINH
--1. Viết một CURSOR để tính tổng lương cho từng nhân viên theo số ca làm việc
-- Tạo CURSOR để duyệt qua các nhân viên
CREATE PROC TINHTONGLUONGNVTHEOCA
AS
BEGIN
DECLARE LuongNV1T CURSOR
FOR SELECT NHANVIEN.MANV, TENNV FROM NHANVIEN;
DECLARE @MANV CHAR(10), @TENNV NVARCHAR(100), @SOTIEN INT, @SOCALAMVIEC INT, @LUONG DECIMAL(10,3), @MACLV CHAR(50), @LUONGTRONGTHANG INT
OPEN LuongNV1T;
FETCH NEXT FROM LuongNV1T INTO @MANV, @TENNV

-- Duyệt qua tất cả các nhân viên
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Tìm tổng số ca làm việc, số tiền mỗi ca của nhân viên
    SELECT @SOCALAMVIEC = TONGSOCALAMTRONGTHANG, @SOTIEN = SOTIEN FROM CHITIETLUONGNHANVIEN, CALAMVIEC WHERE MANV = @MANV 
    
    -- Nếu không có ca làm việc, gán số ca là 0
    IF @SOCALAMVIEC IS NULL
        SET @SOCALAMVIEC = 0;
    
    -- Nếu không có số tiền cho ca làm việc, gán số tiền là 0
    IF @SOTIEN IS NULL
        SET @SOTIEN = 0; 

    IF @LUONGTRONGTHANG IS NULL
		SET @LUONGTRONGTHANG = 0;

    -- Tính tổng lương (Số ca làm việc * Số tiền làm việc 1 ca)
    SET @LUONG = @SOCALAMVIEC * @SOTIEN
    -- Cập nhật thông tin lương vào cột thành tiền trong bảng chi tiết lương nhân viên
    UPDATE CHITIETLUONGNHANVIEN
    SET LUONGTRONGTHANG = @LUONG
    WHERE MANV = @MANV;
    FETCH NEXT FROM LuongNV1T INTO @MANV ,@TENNV
END

-- Đóng CURSOR
CLOSE LuongNV1T;
DEALLOCATE LuongNV1T;
END
EXEC TINHTONGLUONGNVTHEOCA
---------THỰC THI--------
SELECT * FROM CHITIETLUONGNHANVIEN;
--BÁCH
--2.VIẾT CURSOR XUẤT THÔNG TIN KHÁCH HÀNG SAU ĐÓ LỒNG VÀO THỦ TỤC ĐỂ DỄ DÀNG THỰC THI
CREATE PROC XUATTHONGTINKHCR
AS
BEGIN
    DECLARE XUATTHONGTINKH CURSOR
    FOR SELECT MAKH, MALKH, TENKH, SDT FROM KHACHHANG

    OPEN XUATTHONGTINKH
    DECLARE @MAKH CHAR(10), @MALKH CHAR(10), @TENKH NVARCHAR(50), @SDT CHAR(15)

    FETCH NEXT FROM XUATTHONGTINKH INTO @MAKH, @MALKH, @TENKH, @SDT
    WHILE (@@FETCH_STATUS = 0)
    BEGIN
        DECLARE @TENLKH NVARCHAR(50)
        SET @TENLKH = (SELECT TENLKH FROM LOAIKHACHHANG WHERE MALKH = @MALKH)

        -- Gửi thông báo qua RAISERROR
        RAISERROR(N'Thông Tin Khách Hàng', 0, 1) WITH NOWAIT
        RAISERROR(N'Tên Khách Hàng: %s', 0, 1, @TENKH) WITH NOWAIT
        RAISERROR(N'Kiểu Khách Hàng: %s', 0, 1, @TENLKH) WITH NOWAIT
        RAISERROR(N'Số Điện Thoại: %s', 0, 1, @SDT) WITH NOWAIT
        RAISERROR('----------------------------', 0, 1) WITH NOWAIT

        FETCH NEXT FROM XUATTHONGTINKH INTO @MAKH, @MALKH, @TENKH, @SDT
    END

    CLOSE XUATTHONGTINKH
    DEALLOCATE XUATTHONGTINKH
END
EXEC XUATTHONGTINKHCR
--NHI
--3.Viết CURSOR cập nhật thông tin lương cho từng nhân viên dựa trên số ca làm trong tháng
CREATE PROC CAPNHATTHONGTINLUONG
AS
BEGIN

    DECLARE @MANV CHAR(10), @TENNV NVARCHAR(100), @TONGSOCALAMTRONGTHANG INT, @MACLV CHAR(50), @SOTIEN INT, @TONGTIEN INT;
    DECLARE ThongTinLuongNV CURSOR FOR
    SELECT NV.MANV, NV.TENNV, CT.TONGSOCALAMTRONGTHANG, CT.MACLV
    FROM NHANVIEN NV
    JOIN CHITIETLUONGNHANVIEN CT ON NV.MANV = CT.MANV;

    OPEN ThongTinLuongNV;
    FETCH NEXT FROM ThongTinLuongNV INTO @MANV, @TENNV, @TONGSOCALAMTRONGTHANG, @MACLV;
    
    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @SOTIEN = SOTIEN
        FROM CALAMVIEC
        WHERE MACLV = @MACLV;

        -- Tính tổng tiền lương
        SET @TONGTIEN = @SOTIEN * @TONGSOCALAMTRONGTHANG;

		RAISERROR(N'Thông Tin Nhân Viên:', 0, 1) WITH NOWAIT;
		RAISERROR(N'Tên Nhân Viên: %s', 0, 1, @TENNV) WITH NOWAIT;
		RAISERROR(N'Mã Nhân Viên: %s', 0, 1, @MANV) WITH NOWAIT;
		RAISERROR(N'Tổng Số Ca Làm: %d', 0, 1, @TONGSOCALAMTRONGTHANG) WITH NOWAIT;
		RAISERROR(N'Mã Công Việc: %s', 0, 1, @MACLV) WITH NOWAIT;
		RAISERROR(N'Số Tiền / Ca: %d', 0, 1, @SOTIEN) WITH NOWAIT;
		RAISERROR(N'Tổng Tiền Lương: %d', 0, 1,@TONGTIEN) WITH NOWAIT;
		RAISERROR(N'-----------------------------', 0, 1) WITH NOWAIT;

        -- Lấy dòng tiếp theo
        FETCH NEXT FROM ThongTinLuongNV INTO @MANV, @TENNV, @TONGSOCALAMTRONGTHANG, @MACLV;
    END;

    CLOSE ThongTinLuongNV
    DEALLOCATE ThongTinLuongNV

END

EXEC CAPNHATTHONGTINLUONG
--VI
-------cussor số lượng bán trong tháng
CREATE PROC XUATSOLGBANRA @THANG INT, @NAM  INT
AS
BEGIN
DECLARE @MaHangHoa char(10), @TongSoLuong INT;
DECLARE HangHoaCursor CURSOR FOR
SELECT MAHH, SUM(SoLuong) AS TongSoLuong
FROM ChiTietBanHang
JOIN HOADONBANHANG ON ChiTietBanHang.MAHDBH =HOADONBANHANG.MAHDBH
WHERE MONTH(HOADONBANHANG.NGAYHD) = @THANG AND YEAR(HOADONBANHANG.NGAYHD) = @NAM
GROUP BY MAHH;

OPEN HangHoaCursor;
FETCH NEXT FROM HangHoaCursor INTO @MaHangHoa, @TongSoLuong;

WHILE @@FETCH_STATUS = 0
BEGIN

	RAISERROR(N'Thông Tin:', 0, 1) WITH NOWAIT;
	RAISERROR(N'Mã Hàng Hóa: %s', 0, 1,@MaHangHoa) WITH NOWAIT;
	RAISERROR(N'Tổng Số Lượng: %d', 0, 1, @TongSoLuong) WITH NOWAIT;
	RAISERROR(N'-----------------------------', 0, 1) WITH NOWAIT;
    FETCH NEXT FROM HangHoaCursor INTO @MaHangHoa, @TongSoLuong;
END;

CLOSE HangHoaCursor;
DEALLOCATE HangHoaCursor;
END
EXEC XUATSOLGBANRA 10,2024
--ĐẠT
-----Cursor duyệt qua tất cả các đơn hàng và tính tổng tiền từng đơn hang 
CREATE PROC TTDONHANG
AS
BEGIN
DECLARE @MaDonHang CHAR(10), @TongTien int

DECLARE DonHangCursor CURSOR FOR
SELECT CT.MAHDBH, SUM(CT.SOLUONG * M.GIASP) AS TongTien
FROM CHITIETBANHANG CT
JOIN KHO M ON CT.MAHH = M.MAHH
GROUP BY CT.MAHDBH

OPEN DonHangCursor
FETCH NEXT FROM DonHangCursor INTO @MaDonHang, @TongTien

WHILE @@FETCH_STATUS = 0
BEGIN
	RAISERROR(N'Thông Tin:', 0, 1) WITH NOWAIT;
	RAISERROR(N'Mã Đơn hàng: %s', 0, 1,@MaDonHang) WITH NOWAIT;
	RAISERROR(N'Tổng Tiền: %d', 0, 1, @TongTien) WITH NOWAIT;
	RAISERROR(N'-----------------------------', 0, 1) WITH NOWAIT;    
    FETCH NEXT FROM DonHangCursor INTO @MaDonHang, @TongTien
END

CLOSE DonHangCursor
DEALLOCATE DonHangCursor
END
EXEC TTDONHANG

--=========================View thống kê theo tháng====================================

--1.THỐNG KÊ THEO THÁNG NĂM
CREATE VIEW Thongke AS
SELECT 
	YEAR(HOADONBANHANG.NGAYHD) AS YEAR,
	MONTH(HOADONBANHANG.NGAYHD) AS MONTH,
	SUM(HOADONBANHANG.TONGTIEN) AS TONGDOANHTHU
FROM HOADONBANHANG
GROUP BY YEAR(HOADONBANHANG.NGAYHD),MONTH(HOADONBANHANG.NGAYHD)

--2.THỐNG KÊ THEO NĂM
CREATE VIEW ThongkeNam AS
SELECT
	YEAR(NGAYHD) AS Nam,
	SUM(TONGTIEN) AS TONGDOANHTHU
FROM HOADONBANHANG
GROUP BY YEAR(NGAYHD)

--3. THỐNG KÊ DOANH THU THEO SẢN PHẨM
CREATE VIEW ThongKeDoanhThu AS
SELECT
    MENU.MAHH,                     
    MENU.TENHH,                   
    SUM(SOLUONG * MENU.GIASP) AS DOANHTHU  
FROM
    MENU,CHITIETBANHANG,HOADONBANHANG
WHERE 
	MENU.MAHH=CHITIETBANHANG.MAHH
	AND CHITIETBANHANG.MAHDBH=HOADONBANHANG.MAHDBH
GROUP BY
    MENU.MAHH, MENU.TENHH  
--4.Thống kê doanh thu theo khách hàng
CREATE VIEW ThongKeTheoKH AS
SELECT
	KHACHHANG.MAKH,TENKH,
	SUM(HOADONBANHANG.TONGTIEN) AS TongDoanhThu
FROM HOADONBANHANG,KHACHHANG
WHERE HOADONBANHANG.MAKH=KHACHHANG.MAKH
GROUP BY KHACHHANG.MAKH,TENKH



--======================================Thêm các Proc thêm, xóa, sửa=======================================
-- Stored procedure thêm hóa đơn bán hàng
ALTER PROCEDURE ThemHoaDonBanHang
    @MAHDBH CHAR(10),
    @MANV CHAR(10),
    @MABAN CHAR(10)
AS
BEGIN
    INSERT INTO HOADONBANHANG (MAHDBH, MANV, MABAN)
    VALUES (@MAHDBH, @MANV, @MABAN)
END;
GO
-- Stored procedure xóa hóa đơn bán hàng
CREATE PROCEDURE XoaHoaDonBanHang @MAHDBH CHAR(10)
AS
BEGIN
    DELETE FROM HOADONBANHANG WHERE MAHDBH = @MAHDBH
END;
GO

-- Stored procedure sửa hóa đơn bán hàng
CREATE PROCEDURE SuaHoaDonBanHang
    @MAHDBH CHAR(10),
    @MANV CHAR(10),
    @MABAN CHAR(10),
    @MAKH CHAR(10),
    @NGAYHD DATE,
    @TONGTIEN INT,
    @GIAMGIA INT
AS
BEGIN
    UPDATE HOADONBANHANG
    SET MANV = @MANV,
        MABAN = @MABAN,
        MAKH = @MAKH,
        NGAYHD = @NGAYHD,
        TONGTIEN = @TONGTIEN,
        GIAMGIA = @GIAMGIA
    WHERE MAHDBH = @MAHDBH
END;
GO


-- Stored procedure thêm chi tiết nhập hàng
CREATE PROCEDURE ThemChiTietNhapHang
    @MANL CHAR(10),
    @MAHDNH CHAR(10),
    @SOLUONG INT
AS
BEGIN
    INSERT INTO CHITIETNHAPHANG (MANL, MAHDNH, SOLUONG)
    VALUES (@MANL, @MAHDNH, @SOLUONG)
END;
GO

-- Stored procedure xóa chi tiết nhập hàng
CREATE PROCEDURE XoaChiTietNhapHang
    @MANL CHAR(10),
    @MAHDNH CHAR(10)
AS
BEGIN
    DELETE FROM CHITIETNHAPHANG WHERE MANL = @MANL AND MAHDNH = @MAHDNH
END;
GO

-- Stored procedure sửa chi tiết nhập hàng
CREATE PROCEDURE SuaChiTietNhapHang
    @MANL CHAR(10),
    @MAHDNH CHAR(10),
    @SOLUONG INT,
    @THANHTIEN INT
AS
BEGIN
    UPDATE CHITIETNHAPHANG
    SET SOLUONG = @SOLUONG,
        THANHTIEN = @THANHTIEN
    WHERE MANL = @MANL AND MAHDNH = @MAHDNH
END;
GO




--ĐẠT
-- Stored procedure thêm hóa đơn nhập hàng
CREATE PROCEDURE ThemHoaDonNhapHang
    @MAHDNH CHAR(10),
    @MANV CHAR(10),
    @NGAYHBNH DATE
AS
BEGIN
    INSERT INTO HOADONNHAPHANG (MAHDNH, MANV, NGAYHBNH)
    VALUES (@MAHDNH, @MANV, @NGAYHBNH)
END;
GO

-- Stored procedure xóa hóa đơn nhập hàng
CREATE PROCEDURE XoaHoaDonNhapHang @MAHDNH CHAR(10)
AS
BEGIN
    DELETE FROM HOADONNHAPHANG WHERE MAHDNH = @MAHDNH
END;
GO

-- Stored procedure sửa hóa đơn nhập hàng
CREATE PROCEDURE SuaHoaDonNhapHang
    @MAHDNH CHAR(10),
    @MANV CHAR(10),
    @NGAYHBNH DATE
AS
BEGIN
    UPDATE HOADONNHAPHANG
    SET MANV = @MANV, NGAYHBNH = @NGAYHBNH
    WHERE MAHDNH = @MAHDNH;
END;
GO


-- Stored procedure thêm chi tiết bán hàng
CREATE PROCEDURE ThemChiTietBanHang
    @MAHDBH CHAR(10),
    @MAHH CHAR(10),
    @SOLUONG INT
AS
BEGIN
        INSERT INTO CHITIETBANHANG (MAHDBH, MAHH, SOLUONG)
    VALUES (@MAHDBH, @MAHH, @SOLUONG);
	UPDATE HOADONBANHANG 
	SET TONGTIEN=(SELECT SUM(SOLUONG*GIASP)
	FROM CHITIETBANHANG,KHO
	WHERE CHITIETBANHANG.MAHH=KHO.MAHH AND MAHDBH=@MAHDBH)
	WHERE MAHDBH=@MAHDBH
	UPDATE KHO
	SET SOLUONGTON = SOLUONGTON - @SOLUONG
	WHERE MAHH=@MAHH
END;
GO

-- Stored procedure xóa chi tiết bán hàng
CREATE PROCEDURE XoaChiTietBanHang
    @MAHDBH CHAR(10),
    @MAHH CHAR(10)
AS
BEGIN
    DELETE FROM CHITIETBANHANG WHERE MAHDBH = @MAHDBH AND MAHH = @MAHH;
END;
GO
-- Stored procedure sửa chi tiết bán hàng
CREATE PROCEDURE SuaChiTietBanHang
    @MAHDBH CHAR(10),
    @MAHH CHAR(10),
    @SOLUONG INT
AS
BEGIN
    UPDATE CHITIETBANHANG
    SET SOLUONG = @SOLUONG
    WHERE MAHDBH = @MAHDBH AND MAHH = @MAHH;
END;
GO

--Thủ tục thêm nhân viên
CREATE PROCEDURE THEMNHANVIEN
    @MANV CHAR(10),
    @TENNV NVARCHAR(100),
    @GIOITINH NVARCHAR(5),
    @CHUCVU NVARCHAR(30),
    @NGAYVAOLAM DATE,
    @DIACHI NVARCHAR(100),
    @SDT CHAR(15)
AS
BEGIN

	--Kiểm tra SDT nhập có tồn tại
	IF EXISTS (SELECT SDT FROM NHANVIEN WHERE SDT = @SDT)
	BEGIN
		PRINT N'Số điện thoại đã tồn tại!';
		RETURN;
    END

	--Kiểm tran MANV nhập có tồn tại
    IF NOT EXISTS (SELECT MANV FROM NHANVIEN WHERE MANV = @MANV)
	BEGIN
		INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, CHUCVU, NGAYVAOLAM, DIACHI, SDT)
		VALUES (@MANV, @TENNV, @GIOITINH, @CHUCVU, @NGAYVAOLAM, @DIACHI, @SDT);
		PRINT 'Thêm nhân viên thành công!'
	END
    ELSE
    BEGIN
		PRINT N'Nhân viên đã tồn tại';
    END
END
---------THỰC THI----------
EXEC THEMNHANVIEN 'NV012', N'Nguyễn Văn Khoa', N'Nam', N'Nhân viên', '2024-12-01', N'123 Đường ABC', '0911111111';

------------------------------------

--Thủ tục xóa nhân viên
CREATE PROCEDURE XOANHANVIEN
	@MANV CHAR(10)
AS
BEGIN 
	DELETE FROM NHANVIEN
	WHERE MANV = @MANV;
    IF @@ROWCOUNT = 0
	PRINT N'Không tìm thấy nhân viên với mã này!';
    ELSE
	PRINT N'Xóa nhân viên thành công!';
END
---------THỰC THI----------
EXEC XOANHANVIEN 'NV010';

------------------------------------

--Thủ tục sửa thông tin nhân viên
CREATE PROCEDURE SUANHANVIEN
    @MANV CHAR(10),
    @TENNV NVARCHAR(100) = NULL,
    @GIOITINH NVARCHAR(5) = NULL,
    @CHUCVU NVARCHAR(30) = NULL,
    @NGAYVAOLAM DATE = NULL,
    @DIACHI NVARCHAR(100) = NULL,
    @SDT CHAR(15) = NULL
AS
BEGIN
	--Kiểm tra SDT nhập có tồn tại
	IF EXISTS (SELECT SDT FROM NHANVIEN WHERE SDT = @SDT)
	BEGIN
		PRINT N'Số điện thoại đã tồn tại!';
		RETURN;
	END
	UPDATE NHANVIEN
	SET 
		TENNV = ISNULL(@TENNV, TENNV),
		GIOITINH = ISNULL(@GIOITINH, GIOITINH),
		CHUCVU = ISNULL(@CHUCVU, CHUCVU),
		NGAYVAOLAM = ISNULL(@NGAYVAOLAM, NGAYVAOLAM),
		DIACHI = ISNULL(@DIACHI, DIACHI),
		SDT = ISNULL(@SDT, SDT)
	WHERE MANV = @MANV;

	IF @@ROWCOUNT = 0
		PRINT N'Không tìm thấy nhân viên với mã này!';
	ELSE
		PRINT N'Cập nhật thông tin nhân viên thành công!';
END;
---------THỰC THI----------
EXEC SUANHANVIEN 'NV002',  @DIACHI = N'123 Đường XYZ', @SDT = '0999999999';

---------------------------------------

--Thủ tục thêm khách hàng
CREATE PROCEDURE THEMKHACHHANG

    @MAKH CHAR(10),
    @MALKH CHAR(10),
    @TENKH NVARCHAR(100),
    @DIACHI NVARCHAR(100),
    @SDT CHAR(15)
AS
BEGIN
	--Kiểm tra MALKH nhập có tồn tại 
        IF NOT EXISTS (SELECT MALKH FROM LOAIKHACHHANG WHERE MALKH = @MALKH)
        BEGIN
            PRINT N'Loại khách hàng không tồn tại!';
            RETURN;
        END
	--Kiểm tra SDT nhập có tồn tại
	IF EXISTS (SELECT 1 FROM KHACHHANG WHERE SDT = @SDT)
        BEGIN
            PRINT N'Số điện thoại đã tồn tại!';
            RETURN;
        END
	--Kiểm tra MAKH nhập có tồn tại
	IF NOT EXISTS (SELECT MAKH FROM KHACHHANG WHERE MAKH = @MAKH)
	BEGIN
		INSERT INTO KHACHHANG (MAKH, MALKH, TENKH, DIACHI, SDT)
		VALUES (@MAKH,@MALKH,@TENKH,@DIACHI,@SDT)
		PRINT 'Thêm khách hàng thành công!'
	END
	ELSE
	BEGIN
		PRINT N'Khách hàng đã tồn tại';
	END
END---------THỰC THI----------
EXEC THEMKHACHHANG 'KH013',  'LKH02',  N'Trần Văn D',  N'Hải Phòng',  '0912345688';

---------------------------------------
--Thủ tục xóa khách hàng
CREATE PROCEDURE XOAKHACHHANG
	@MAKH CHAR(10)
AS
BEGIN 
-- Xóa các hóa đơn bán hàng liên quan đến khách hàng trước
	DELETE FROM CHITIETBANHANG
	WHERE MAHDBH IN (SELECT MAHDBH FROM HOADONBANHANG WHERE MAKH = @MAKH);

	DELETE FROM HOADONBANHANG
	WHERE MAKH = @MAKH;

	DELETE FROM KHACHHANG
	WHERE MAKH = @MAKH;
    IF @@ROWCOUNT = 0
	    PRINT N'Không tìm thấy khách hàng với mã này!';
    ELSE
		PRINT N'Xóa khách hàng thành công!';
END
---------THỰC THI----------
EXEC XOAKHACHHANG 'KH010';

-------------------------------------------

--Thủ tục sửa thông tin khách hàng
CREATE PROCEDURE SUAKHACHHANG
    @MAKH CHAR(10),
    @MALKH CHAR(10) = NULL,
    @TENKH NVARCHAR(100)= NULL,
    @DIACHI NVARCHAR(100) = NULL,
    @SDT CHAR(15) = NULL
AS
BEGIN
	--Kiểm tra SDT nhập có tồn tại
	IF EXISTS (SELECT 1 FROM KHACHHANG WHERE SDT = @SDT)
    BEGIN
		PRINT N'Số điện thoại đã tồn tại!';
		RETURN;
    END
    BEGIN
	UPDATE KHACHHANG
    SET 
		MALKH = ISNULL(@MALKH, MALKH),
		TENKH = ISNULL(@TENKH, TENKH),
        DIACHI = ISNULL(@DIACHI, DIACHI),
        SDT = ISNULL(@SDT, SDT)
    WHERE MAKH = @MAKH;

	IF @@ROWCOUNT = 0
		PRINT N'Không tìm thấy khách hàng với mã này!';
    ELSE
		PRINT N'Cập nhật thông tin khách hàng thành công!';
    END
END;
---------THỰC THI----------
EXEC SUAKHACHHANG 'KH002',  @DIACHI = N'123 Đường XYZ', @SDT = '0999999999';


---xoa 1 menu
CREATE PROC XOAMENU @MAHH CHAR(10)
AS
DELETE FROM MENU
WHERE MAHH=@MAHH


EXEC XoaChiTietBanHang 'HDBH009','HH007'
SELECT* FROM CHITIETBANHANG

--THEM CHI TIET LUONG
CREATE PROC THEMCHITIETLUONG @MACLV CHAR(10),@MANV CHAR(10),@SOCA INT
AS
INSERT INTO CHITIETLUONGNHANVIEN(MACLV,MANV,TONGSOCALAMTRONGTHANG)
VALUES (@MACLV,@MANV,@SOCA)
----XOA CHI TIET LUONG
CREATE PROC XOACHITIETLUONG @MACLV CHAR(10),@MANV CHAR(10)
AS
DELETE FROM CHITIETLUONGNHANVIEN
WHERE MACLV=@MACLV AND MANV=@MANV

--======================================QUẢN TRỊ NGƯỜI DÙNG=======================================
--======================================PHÂN QUYỀN=============================================
---TẠO VAI TRÒ NHÂN VIÊN
CREATE ROLE NHANVIEN;
--QUYỀN CỦA NHÂN VIÊN TRÊN BẢNG HOADONBANHANG
GRANT SELECT,INSERT ON HOADONBANHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG NGUYENLIEU
GRANT SELECT,INSERT
ON NGUYENLIEU
TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG CALAMVIEC
GRANT SELECT ON CALAMVIEC TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG BAN
GRANT SELECT,INSERT ON BAN TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG HOADONNHAPHANG
GRANT SELECT,INSERT ON HOADONNHAPHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG CHITIETNHAPHANG
GRANT SELECT,INSERT ON CHITIETNHAPHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG NHACUNGCAP
GRANT SELECT,INSERT ON NHACUNGCAP TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG KHACHHANG
GRANT SELECT,INSERT ON KHACHHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG LOAIKHACHHANG
GRANT SELECT,INSERT ON LOAIKHACHHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG CHITIETBANHANG
GRANT SELECT,INSERT ON CHITIETBANHANG TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG MENU
GRANT SELECT,INSERT ON MENU TO NHANVIEN
--GẮN QUYỀN CHO NHÂN VIÊN TRÊN BẢNG LOAIHANG
GRANT SELECT,INSERT ON LOAIHANG TO NHANVIEN
--QUYỀN CỦA NHÂN VIÊN TRÊN NHANVIEN
GRANT SELECT ON NHANVIEN TO NHANVIEN

--TẠO TÀI KHOẢN ĐĂNG NHẬP
SP_ADDLOGIN 'KhanhNhi','123'

--TẠO TÀI KHOẢN NGƯỜI DÙNG
SP_ADDUSER 'KhanhNhi','KhanhNhi'
--gắn người dùng vô nhóm quyền
SP_ADDROLEMEMBER 'db_owner','KhanhNhi'

--tạo tài khoản đăng nhập
SP_ADDLOGIN 'xuanbach','123'
--tạo tài khoản người dùng
SP_ADDUSER 'xuanbach','xuanbach'
--GẮN QUYỀN NGƯỜI DÙNG VÔ NHÓM QUYỀN
SP_ADDROLEMEMBER 'db_owner','xuanbach'

---TẠO TÀI KHOẢN ĐĂNG NHẬP
SP_ADDLOGIN 'VINH','123','QL_QUANCAFE'
SP_ADDLOGIN 'DAT','456','QL_QUANCAFE'
---TẠO TÀI KHOẢN NGƯỜI DÙNG
SP_ADDUSER 'VINH','VINH'
SP_ADDUSER 'DAT','DAT'
---THUỘC NHÓM PHÂN QUYỀN
SP_ADDROLEMEMBER 'NHANVIEN','VINH'
SP_ADDROLEMEMBER 'NHANVIEN','DAT'

GRANT SELECT,INSERT
ON KHACHHANG
TO DAT
--HỦY QUYỀN INSERT TRÊN BÀNG KHACHHANG ĐỐI VỚI DAT
REVOKE INSERT
ON KHACHHANG
FROM DAT


--=================LẬP LỊCH TRÌNH SAO LƯU ĐỊNH KỲ=========================
--=================THIẾT LẬP SAO LƯU TỰ ĐỘNG===============================

--================VIẾT THÊM===================
--CẬP  NHẬT KHO KHI THÊM HÀNG HÓA
CREATE TRIGGER CAPNHATKHO ON CHITIETNHAPHANG
FOR INSERT ,UPDATE
AS
BEGIN
	DECLARE  @MANL CHAR(10);
	SET @MANL=(SELECT MANL FROM inserted)
	DECLARE  @SOLUONG INT;
	SET @SOLUONG=(SELECT SOLUONG FROM inserted)
	UPDATE KHO
	SET SOLUONGTON=SOLUONGTON+@SOLUONG
	WHERE MANL=@MANL
END

INSERT INTO CHITIETNHAPHANG (MANL, MAHDNH, SOLUONG, THANHTIEN)
VALUES
('NL001', 'HD001', 2, 100000)
SELECT * FROM KHO
--==============================CẬP NHẬT SL KHO=====================

INSERT INTO CHITIETBANHANG (MAHDBH, MAHH, SOLUONG)
VALUES
('HDBH001', 'HH001', 10)
SELECT * FROM KHO
SELECT* FROM CHITIETBANHANG




ALTER TRIGGER KTRASLBAN ON CHITIETBANHANG
FOR INSERT,UPDATE
AS
BEGIN
	DECLARE @MAHH CHAR(10);
	SET @MAHH=(SELECT MAHH FROM inserted)
	DECLARE @SLBAN INT
	SET @SLBAN=(SELECT SOLUONG FROM inserted)
	DECLARE @SLKHO INT
	SET @SLKHO=(SELECT SOLUONGTON FROM KHO WHERE MAHH=@MAHH)
	IF (@SLBAN>@SLKHO)
	BEGIN
		PRINT N'KHÔNG ĐỦ HÀNG TRONG KHO'
	END
	ELSE
	BEGIN
		UPDATE KHO
		SET SOLUONGTON=SOLUONGTON-@SLBAN
		WHERE MAHH=@MAHH
	END
END

SELECT TOP 1 MAHDBH FROM HOADONBANHANG WHERE MAHDBH LIKE 'HD%' ORDER BY MAHDBH DESC


--============xoa do an trong ban==========
CREATE PROC XOAHH @MAHDBH CHAR(10),@MAHH CHAR(10)
AS
BEGIN
		--- cập nhật lại sl hàng trong kho
	DECLARE @SOLUONGCU INT
	SET @SOLUONGCU=(SELECT SOLUONG FROM CHITIETBANHANG WHERE MAHH=@MAHH AND MAHDBH=@MAHDBH)
	UPDATE KHO
	SET SOLUONGTON=SOLUONGTON+@SOLUONGCU
	WHERE MAHH=@MAHH
	DELETE FROM CHITIETBANHANG WHERE MAHDBH=@MAHDBH AND MAHH=@MAHH
	-- TỰ ĐỘNG CẬP NHẬT TỔNG TIỀN 
	UPDATE HOADONBANHANG 
	SET TONGTIEN=(SELECT SUM(SOLUONG*GIASP)
	FROM CHITIETBANHANG,KHO
	WHERE CHITIETBANHANG.MAHH=KHO.MAHH AND MAHDBH=@MAHDBH)
END
SELECT* FROM CHITIETBANHANG
EXEC XOAHH 'HDBH001','HH001'


--================Doi Ban=============
CREATE PROC DOIBAN  @MAHDBH CHAR(10),@MABANCU CHAR(10),@MABANMOI CHAR(10)
AS
BEGIN
	UPDATE HOADONBANHANG
	SET MABAN=@MABANMOI
	WHERE MAHDBH=@MAHDBH
	UPDATE BAN
	SET THUOCTINH='0'
	WHERE MABAN=@MABANCU
	UPDATE BAN
	SET THUOCTINH='1'
	WHERE MABAN=@MABANMOI

END


--==========Thêm Bàn========
CREATE PROC THEMBAN @MABAN CHAR(10),@TENBAN NVARCHAR(30)
AS
BEGIN
	INSERT INTO BAN
	VALUES (@MABAN,@TENBAN,'0')
END

--=========XOAS BANF==============
CREATE PROC  XOABAN @MABAN CHAR(10)
AS
BEGIN
	DELETE FROM BAN
	WHERE MABAN=@MABAN
END

select* from hoadonbanhang

CREATE PROC CAPNHATBAN @MABAN CHAR(10)
AS
BEGIN
	UPDATE BAN
	SET THUOCTINH='1'
	WHERE MABAN=@MABAN
END


---========thêm hàng hóa mới======
CREATE PROC THEMHH @MAHH CHAR(10),@MANL CHAR(10),@TENNL NVARCHAR(30),@MANCC CHAR(10),@MALOAI CHAR(10),@GIANHAP INT,@GIABAN INT
AS
BEGIN
	INSERT INTO NGUYENLIEU
	VALUES(@MANL,@TENNL,@MANCC,@MALOAI,@GIANHAP)
	INSERT INTO KHO
	VALUES(@MAHH,@MANL,@TENNL,@GIABAN,0)
END




------tạo bảng ảo inhoadon-----
CREATE VIEW INHOADON
AS
	SELECT HDBH.MAHDBH,NGAYHD,TENBAN,TENHH,SOLUONG,(SOLUONG*GIASP) AS N'THANHTIEN',TONGTIEN
	FROM HOADONBANHANG HDBH,CHITIETBANHANG  CTBH,BAN,KHO
	WHERE HDBH.MAHDBH=CTBH.MAHDBH AND HDBH.MABAN=BAN.MABAN AND CTBH.MAHH=KHO.MAHH

SELECT* FROM HOADONBANHANG
SELECT* 
FROM INHOADON
WHERE MAHDBH='HDBH003'