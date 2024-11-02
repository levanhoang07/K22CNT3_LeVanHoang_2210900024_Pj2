CREATE DATABASE K22CNT3_LEVANHOANG_PROJECT2;
GO
USE K22CNT3_LEVANHOANG_PROJECT2;
GO

CREATE TABLE QuanTriPj2 (
    Taikhoan VARCHAR(50) NOT NULL PRIMARY KEY, 
    Matkhau VARCHAR(32) NOT NULL,             
    Trangthai TINYINT DEFAULT 1              
);

CREATE TABLE KhachHangPj2 (
    MaKH INT NOT NULL IDENTITY(1,1) PRIMARY KEY,     
    HoTen VARCHAR(100) NULL,                        
    TaiKhoan VARCHAR(50) NOT NULL UNIQUE,            
    MatKhau VARCHAR(32) NULL,                        
    DiaChi VARCHAR(200) NULL,                       
    DienThoai VARCHAR(30) NULL,                     
    Email VARCHAR(50) NOT NULL,                     
    NgaySinh DATETIME NULL,                          
    NgayCapNhat DATETIME DEFAULT GETDATE(),         
    GioiTinh TINYINT NULL,                          
    TrangThai TINYINT DEFAULT 1  
	
);

CREATE TABLE SanPhamPj2 (
    MaSP INT NOT NULL IDENTITY(1,1) PRIMARY KEY,       
    TenSP VARCHAR(100) NOT NULL,                       
    MoTa VARCHAR(500) NULL,                            
    Gia DECIMAL(18, 2) NOT NULL,                       
    SoLuong INT DEFAULT 0,                             
    NgayNhap DATETIME DEFAULT GETDATE(),               
    TrangThai TINYINT DEFAULT 1                        
);

CREATE TABLE ChiTietDonHangPj2 (
    MaChiTiet INT NOT NULL IDENTITY(1,1) PRIMARY KEY,  
    MaKH INT NOT NULL,                                 
    MaSP INT NOT NULL,                                 
    SoLuong INT NOT NULL,                              
    DonGia DECIMAL(18, 2) NOT NULL,                    
    NgayDatHang DATETIME DEFAULT GETDATE(),            

    FOREIGN KEY (MaKH) REFERENCES KhachHangPj2(MaKH),
    FOREIGN KEY (MaSP) REFERENCES SanPhamPj2(MaSP)
);
CREATE TABLE GioHangPj2 (
    MaGioHang INT NOT NULL IDENTITY(1,1) PRIMARY KEY,  
    MaKH INT NOT NULL,                                
    MaSP INT NOT NULL,                                
    SoLuong INT NOT NULL DEFAULT 1,                   
    NgayThem DATETIME DEFAULT GETDATE(),              
    TrangThai TINYINT DEFAULT 1,                     

    FOREIGN KEY (MaKH) REFERENCES KhachHangPj2(MaKH),
    FOREIGN KEY (MaSP) REFERENCES SanPhamPj2(MaSP)
	ALTER TABLE GioHangPj2
DROP CONSTRAINT FK__GioHangPj2__MaKH__3E52440B;

ALTER TABLE GioHangPj2
ADD CONSTRAINT FK__GioHangPj2__MaKH__3E52440B
FOREIGN KEY (MaKH) REFERENCES KhachHangPj2(MaKH)
ON DELETE CASCADE;

);

CREATE TABLE DonHangPj2 (
    MaDonHang INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    MaKH INT NOT NULL,                                 
    NgayDatHang DATETIME DEFAULT GETDATE(),            
    TongTien DECIMAL(18, 2) NOT NULL,                 
    TrangThai TINYINT DEFAULT 1,                     

    FOREIGN KEY (MaKH) REFERENCES KhachHangPj2(MaKH)
);


INSERT INTO QuanTriPj2 (Taikhoan, Matkhau)
VALUES 
('admin1', 'password123'),
('admin2', 'password123'),
('admin3', 'password123'),
('admin4', 'password123'),
('admin5', 'password123');

INSERT INTO KhachHangPj2 (HoTen, TaiKhoan, MatKhau, DiaChi, DienThoai, Email, NgaySinh, GioiTinh)
VALUES 
('Le Van Hoang', 'levanhoang', 'hoang123', 'Vinh Phuc', '0982121680', 'levanhoang742004@gmail.com', '2004-04-07', 1),
('Jane Smith', 'janesmith', 'password123', '456 Oak St', '0987654321', 'janesmith@example.com', '1992-05-15', 0),
('Michael Johnson', 'mjohnson', 'password123', '789 Pine St', '1122334455', 'mjohnson@example.com', '1988-07-22', 1),
('Emily Brown', 'ebrown', 'password123', '101 Maple St', '5566778899', 'ebrown@example.com', '1995-10-10', 0),
('David Davis', 'ddavis', 'password123', '202 Birch St', '6677889900', 'ddavis@example.com', '1993-12-25', 1);

INSERT INTO SanPhamPj2 (TenSP, MoTa, Gia, SoLuong)
VALUES 
('Product A', 'Description of Product A', 100.00, 50),
('Product B', 'Description of Product B', 200.00, 30),
('Product C', 'Description of Product C', 150.00, 20),
('Product D', 'Description of Product D', 300.00, 10),
('Product E', 'Description of Product E', 250.00, 15);

INSERT INTO ChiTietDonHangPj2 (MaKH, MaSP, SoLuong, DonGia)
VALUES 
(1, 1, 2, 100.00),
(2, 2, 1, 200.00),
(3, 3, 3, 150.00),
(4, 4, 1, 300.00),
(5, 5, 2, 250.00);

INSERT INTO GioHangPj2 (MaKH, MaSP, SoLuong)
VALUES 
(1, 1, 1),
(2, 2, 2),
(3, 3, 1),
(4, 4, 3),
(5, 5, 2);

INSERT INTO DonHangPj2 (MaKH, TongTien)
VALUES 
(1, 200.00),
(2, 400.00),
(3, 450.00),
(4, 300.00),
(5, 500.00);
