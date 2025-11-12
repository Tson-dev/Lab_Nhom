USE master;
GO
IF DB_ID('ShoeShop') IS NOT NULL
    DROP DATABASE ShoeShop;
GO

CREATE DATABASE ShoeShop;
GO
USE ShoeShop;
GO

create table [Type]
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL
);
set IDENTITY_INSERT [dbo].[Type] on
INSERT INTO [Type] (ID, [Name])
VALUES
(1, N'Sandal'),
(2, N'Shoes'),
(3, N'Boot'),
(4, N'Sport');
go
set IDENTITY_INSERT [dbo].[Type] off

-- ===========================
-- 1. Bảng Role
-- ===========================
CREATE TABLE [Role]
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    RoleName NVARCHAR(50) NOT NULL UNIQUE,
    Description NVARCHAR(200)
);

INSERT INTO Role (RoleName, Description)
VALUES
(N'Admin', N'Quản trị hệ thống'),
(N'Cashier', N'Thu ngân'),
(N'Sales', N'Nhân viên bán hàng'),
(N'Manager', N'Quản lý');
GO

----------------------------------------------------
-- 2️⃣ Bảng Account
----------------------------------------------------
CREATE TABLE Account (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT 1
);

INSERT INTO Account (Username, Password, Role, Active)
VALUES
('admin', '123456', 'Admin', 1),
('cashier', '123456', 'Cashier', 1),
('sales', '123456', 'Sales', 1),
('manager', '123456', 'Manager', 1),
('inactive', '123456', 'Sales', 0);
GO

----------------------------------------------------
-- 3️⃣ Bảng Employee
----------------------------------------------------
CREATE TABLE Employee (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100),
    Gender NVARCHAR(10),
    BirthDate DATE,
    Address NVARCHAR(200),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    RoleID INT,
    AccountID INT,
    CONSTRAINT FK_Employee_Role FOREIGN KEY (RoleID) REFERENCES Role(ID),
    CONSTRAINT FK_Employee_Account FOREIGN KEY (AccountID) REFERENCES Account(ID)
);

INSERT INTO Employee (FullName, Gender, BirthDate, Address, Phone, Email, RoleID, AccountID)
VALUES
(N'Nguyễn Văn A', N'Nam', '1990-05-01', N'Hà Nội', '0901111111', 'a@shoeshop.com', 1, 1),
(N'Lê Thị B', N'Nữ', '1993-08-15', N'Hồ Chí Minh', '0902222222', 'b@shoeshop.com', 2, 2),
(N'Phạm Văn C', N'Nam', '1996-01-22', N'Đà Nẵng', '0903333333', 'c@shoeshop.com', 3, 3),
(N'Hoàng Thị D', N'Nữ', '1998-07-10', N'Hải Phòng', '0904444444', 'd@shoeshop.com', 4, 4),
(N'Trần Văn E', N'Nam', '1999-03-18', N'Cần Thơ', '0905555555', 'e@shoeshop.com', 3, 5);
GO

----------------------------------------------------
-- 4️⃣ Bảng Brand
----------------------------------------------------
CREATE TABLE Brand (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(15),
    Email NVARCHAR(100)
);

INSERT INTO Brand (Name, Phone, Email)
VALUES
(N'Nike', '0909009009', 'support@nike.com'),
(N'Adidas', '0908111222', 'contact@adidas.com'),
(N'Puma', '0907333444', 'info@puma.com'),
(N'Converse', '0909555666', 'hello@converse.com'),
(N'Vans', '0908666888', 'contact@vans.com'),
(N'Reebok', '0908999777', 'info@reebok.com'),
(N'New Balance', '0908777555', 'support@newbalance.com'),
(N'Skechers', '0908666444', 'help@skechers.com'),
(N'Under Armour', '0908111999', 'service@underarmour.com');
GO

----------------------------------------------------
-- 5️⃣ Bảng Item
----------------------------------------------------
CREATE TABLE Item (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Gender INT CHECK (Gender IN (0,1,2)), -- 0=Unisex,1=Nữ,2=Nam
    Age NVARCHAR(3) CHECK (Age IN ('u5','u11','u18','18')),
	Size int NULL,
	TypeID INT NOT NUll,
    Price INT CHECK (Price >= 0),
    Stock INT CHECK (Stock >= 0),
    BrandID INT NULL,
	Actived BIT Default 1
    CONSTRAINT FK_Item_Brand FOREIGN KEY (BrandID) REFERENCES Brand(ID),
    CONSTRAINT FK_Item_Type FOREIGN KEY (TypeID) REFERENCES [Type](ID)
);

INSERT INTO Item (Name, Gender, Age, Type, Price, Stock, BrandID)
VALUES
(N'Nike Air Zoom', 2, '18', N'Sport', 2500000, 15, 1),
(N'Nike Pegasus 40', 2, '18', N'Sport', 2900000, 20, 1),
(N'Adidas UltraBoost', 2, '18', N'Sport', 2800000, 18, 2),
(N'Adidas Stan Smith', 1, '18', N'Shoes', 2200000, 20, 2),
(N'Puma Runner', 0, 'u18', N'Shoes', 1500000, 25, 3),
(N'Puma Smash V2', 1, 'u11', N'Shoes', 1200000, 30, 3),
(N'Converse High', 0, 'u18', N'Shoes', 1300000, 40, 4),
(N'Vans Old Skool', 0, 'u18', N'Shoes', 1600000, 35, 5),
(N'Reebok Nano X', 2, '18', N'Sport', 2500000, 20, 6),
(N'New Balance 574', 0, '18', N'Shoes', 2300000, 18, 7),
(N'Skechers Go Walk', 1, '18', N'Shoes', 2000000, 25, 8),
(N'Under Armour HOVR', 2, '18', N'Sport', 2700000, 12, 9),
(N'Adidas High Heel', 1, '18', N'Heels', 1800000, 15, 2),
(N'Puma Elegant Step', 1, '18', N'Heels', 2200000, 10, 3),
(N'Nike Air Sandal', 0, '18', N'Sandal', 1100000, 30, 1),
(N'Adidas Comfort Sandal', 0, 'u11', N'Sandal', 900000, 25, 2),
(N'Converse Winter Boot', 0, 'u18', N'Boot', 2000000, 20, 4),
(N'Nike Trail Boot', 2, '18', N'Boot', 3100000, 15, 1),
(N'Reebok Classic Leather', 2, '18', N'Shoes', 2300000, 22, 6),
(N'Vans Authentic Low', 0, 'u18', N'Shoes', 1550000, 28, 5);
GO

----------------------------------------------------
-- 6️⃣ Bảng Bill
----------------------------------------------------
CREATE TABLE Bill (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL,
    Date DATETIME NOT NULL DEFAULT GETDATE(),
    Total DECIMAL(18,2) DEFAULT 0,
    BillType NVARCHAR(10) CHECK (BillType IN ('Import', 'Export')),
    BrandID INT NULL,
    Note NVARCHAR(200),
    CONSTRAINT FK_Bill_Account FOREIGN KEY (AccountID) REFERENCES Account(ID),
    CONSTRAINT FK_Bill_Brand FOREIGN KEY (BrandID) REFERENCES Brand(ID)
);
GO

----------------------------------------------------
-- 7️⃣ Bảng BillDetail
----------------------------------------------------
CREATE TABLE BillDetail (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    BillID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT CHECK (Quantity > 0),
    Price INT CHECK (Price >= 0),
    Source NVARCHAR(50) NULL,
    CONSTRAINT FK_BillDetail_Bill FOREIGN KEY (BillID) REFERENCES Bill(ID) ON DELETE CASCADE,
    CONSTRAINT FK_BillDetail_Item FOREIGN KEY (ItemID) REFERENCES Item(ID) ON DELETE CASCADE
);
GO

----------------------------------------------------
-- 8️⃣ Trigger cập nhật tổng tiền Bill
----------------------------------------------------
CREATE TRIGGER trg_UpdateBillTotal
ON BillDetail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE Bill
    SET Total = (
        SELECT ISNULL(SUM(Quantity * Price), 0)
        FROM BillDetail
        WHERE BillDetail.BillID = Bill.ID
    )
    WHERE Bill.ID IN (
        SELECT DISTINCT BillID FROM inserted
        UNION
        SELECT DISTINCT BillID FROM deleted
    );
END;
GO

----------------------------------------------------
-- 9️⃣ Dữ liệu hóa đơn (50 dòng: 25 Export + 25 Import)
----------------------------------------------------
-- EXPORT
INSERT INTO Bill (AccountID, Date, BillType, Note)
VALUES
(1, '2025-01-10', 'Export', N'Khách Nguyễn An'),
(2, '2025-02-12', 'Export', N'Khách Lê Bình'),
(3, '2025-03-05', 'Export', N'Khách Trần Cường'),
(4, '2025-04-18', 'Export', N'Khách Mai Dung'),
(1, '2025-05-09', 'Export', N'Khách Bùi Anh'),
(2, '2025-06-11', 'Export', N'Khách Lý Thu'),
(3, '2025-07-20', 'Export', N'Khách Nguyễn Vũ'),
(4, '2025-08-15', 'Export', N'Khách Phạm Phương'),
(1, '2025-09-25', 'Export', N'Khách Hoàng Hải'),
(2, '2025-10-19', 'Export', N'Khách Trần Long'),
(3, '2025-11-23', 'Export', N'Khách Nguyễn Thủy'),
(4, '2025-12-14', 'Export', N'Khách cuối năm'),
(1, '2025-03-10', 'Export', N'Khách Nguyễn Hoa'),
(2, '2025-04-22', 'Export', N'Khách Phạm Dũng'),
(3, '2025-05-30', 'Export', N'Khách Bùi Lan'),
(4, '2025-06-18', 'Export', N'Khách Đỗ Quang'),
(1, '2025-07-26', 'Export', N'Khách Nguyễn Văn T'),
(2, '2025-08-09', 'Export', N'Khách Lê Tấn'),
(3, '2025-09-15', 'Export', N'Khách Trần Hạnh'),
(4, '2025-10-28', 'Export', N'Khách Bùi Lộc'),
(1, '2025-11-12', 'Export', N'Khách Đặng Tài'),
(2, '2025-12-05', 'Export', N'Khách Lý Nam'),
(3, '2025-02-08', 'Export', N'Khách Lê Châu'),
(4, '2025-01-25', 'Export', N'Khách Đỗ Hiếu'),
(1, '2025-06-05', 'Export', N'Khách Mai Trang');
GO

-- IMPORT
INSERT INTO Bill (AccountID, Date, BillType, BrandID, Note)
VALUES
(4, '2025-01-05', 'Import', 1, N'Nhập hàng Nike tháng 1'),
(4, '2025-02-10', 'Import', 2, N'Nhập hàng Adidas tháng 2'),
(4, '2025-03-15', 'Import', 3, N'Nhập hàng Puma tháng 3'),
(4, '2025-04-20', 'Import', 4, N'Nhập hàng Converse tháng 4'),
(4, '2025-05-10', 'Import', 5, N'Nhập hàng Vans tháng 5'),
(4, '2025-06-25', 'Import', 6, N'Nhập hàng Reebok tháng 6'),
(4, '2025-07-07', 'Import', 7, N'Nhập hàng New Balance tháng 7'),
(4, '2025-08-12', 'Import', 8, N'Nhập hàng Skechers tháng 8'),
(4, '2025-09-17', 'Import', 9, N'Nhập hàng Under Armour tháng 9'),
(4, '2025-10-21', 'Import', 2, N'Nhập hàng Adidas tháng 10'),
(4, '2025-11-08', 'Import', 3, N'Nhập hàng Puma tháng 11'),
(4, '2025-12-05', 'Import', 4, N'Nhập hàng Converse tháng 12'),
(4, '2025-02-24', 'Import', 1, N'Nhập lô Nike Air Max'),
(4, '2025-03-30', 'Import', 5, N'Nhập lô Vans Authentic'),
(4, '2025-04-11', 'Import', 6, N'Nhập lô Reebok Classic'),
(4, '2025-05-16', 'Import', 7, N'Nhập lô New Balance 574'),
(4, '2025-06-28', 'Import', 8, N'Nhập lô Skechers Go Walk'),
(4, '2025-07-22', 'Import', 9, N'Nhập lô Under Armour HOVR'),
(4, '2025-08-08', 'Import', 1, N'Nhập lô Nike Pegasus 40'),
(4, '2025-09-25', 'Import', 2, N'Nhập lô Adidas Stan Smith'),
(4, '2025-10-15', 'Import', 3, N'Nhập lô Puma Smash'),
(4, '2025-11-20', 'Import', 4, N'Nhập lô Converse Winter'),
(4, '2025-12-29', 'Import', 5, N'Nhập lô Vans cuối năm'),
(4, '2025-01-18', 'Import', 6, N'Nhập lô Reebok đầu năm'),
(4, '2025-03-12', 'Import', 7, N'Nhập lô New Balance bổ sung');
GO

----------------------------------------------------
-- 🔟 Dữ liệu BillDetail (≥70 dòng)
----------------------------------------------------
INSERT INTO BillDetail (BillID, ItemID, Quantity, Price)
VALUES
(1,1,1,2500000),(1,3,2,2800000),
(2,4,1,2200000),(2,5,3,1500000),
(3,2,1,2900000),(3,6,2,1200000),
(4,7,2,1300000),(4,9,1,2500000),
(5,10,2,2300000),(5,12,1,2700000),
(6,8,1,1600000),(6,11,2,2000000),
(7,13,2,1800000),(8,14,1,2200000),
(9,15,3,1100000),(10,16,2,900000),
(11,17,1,2000000),(12,18,2,3100000),
(13,19,1,2300000),(14,20,1,1550000),
(15,1,2,2500000),(16,2,3,2800000),
(17,3,1,2200000),(18,4,1,2200000),
(19,5,3,1500000),(20,6,2,1200000),
(21,7,2,1300000),(22,8,1,1600000),
(23,9,1,2500000),(24,10,2,2300000),
(25,11,2,2000000),(26,12,2,2700000),
(27,13,1,1800000),(28,14,1,2200000),
(29,15,3,1100000),(30,16,1,900000),
(31,17,1,2000000),(32,18,2,3100000),
(33,19,1,2300000),(34,20,1,1550000),
(35,1,2,2500000),(36,2,2,2800000),
(37,3,1,2200000),(38,4,1,2200000),
(39,5,3,1500000),(40,6,2,1200000),
(41,7,2,1300000),(42,8,1,1600000),
(43,9,1,2500000),(44,10,2,2300000),
(45,11,2,2000000),(46,12,2,2700000),
(47,13,1,1800000),(48,14,1,2200000),
(49,15,3,1100000),(50,16,1,900000);
GO

go
Create proc [dbo].[GetBillByDate]
	@day int = null,
	@month int = null,
	@year int = null
as
begin
/*
    Proc Name : GetBillByDate
    Purpose   : Lấy Bill trong thời gian cụ thể, có thể lọc theo ngày/tháng/năm nếu được cung cấp.
                Quy tắc lọc:
                - Nếu có đủ @day, @month, @year => lọc theo ngày/tháng/năm
                - Nếu có @month, @year nhưng @day null => lọc theo tháng/năm
                - Nếu chỉ có @year => lọc theo năm
                - Nếu tất cả null => không lọc theo thời gian (đương tương với GetAll)
*/
declare 
        @isDayNull bit = case when @day is null then 1 else 0 end,
        @isMonthNull bit = case when @month is null then 1 else 0 end,
        @isYearNull bit = case when @year is null then 1 else 0 end;

select *
from Bill b
where (
		(
		@isDayNull = 0 and @isMonthNull = 0 and @isYearNull = 0
		and day(b.[Date]) = @day and month(b.[Date]) = @month and year(b.[Date]) = @year
		)
		or
		(
		@isDayNull = 1 and @isMonthNull = 0 and @isYearNull = 0
		and  month(b.[Date]) = @month and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 0
		and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 1
		)
		)
end;
go
Create proc [dbo].[GetTotal]
	@BillID int,
	@ItemID int,
	@day int = null,
	@month int = null,
	@year int = null
as
begin
/*
    Proc Name : GetBillTotal
    Purpose   : Tính total theo chi tiết hóa đơn (Quantity * Price) có thể lọc theo ngày/tháng/năm nếu được cung cấp.
                Quy tắc lọc:
                - Nếu có đủ @day, @month, @year => lọc theo ngày/tháng/năm
                - Nếu có @month, @year nhưng @day null => lọc theo tháng/năm
                - Nếu chỉ có @year => lọc theo năm
                - Nếu tất cả null => không lọc theo thời gian
*/
declare 
        @isDayNull bit = case when @day is null then 1 else 0 end,
        @isMonthNull bit = case when @month is null then 1 else 0 end,
        @isYearNull bit = case when @year is null then 1 else 0 end;

select (bd.Quantity * bd.Price) as Total, b.[Date]
from BillDetail bd
join Bill b on b.ID = bd.BillID
where b.ID = @BillID
	and bd.ItemID = @ItemID
	and(
		(
		@isDayNull = 0 and @isMonthNull = 0 and @isYearNull = 0
		and day(b.[Date]) = @day and month(b.[Date]) = @month and year(b.[Date]) = @year
		)
		or
		(
		@isDayNull = 1 and @isMonthNull = 0 and @isYearNull = 0
		and  month(b.[Date]) = @month and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 0
		and year(b.[Date]) = @year
		)
        or
		(
		@isDayNull = 1 and @isMonthNull = 1 and @isYearNull = 1
		)
		)
end;

