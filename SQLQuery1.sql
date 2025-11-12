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
    [Description] NVARCHAR(200)
);

INSERT INTO Role (RoleName, [Description])
VALUES
(N'Admin', N'Quản trị hệ thống, toàn quyền thao tác.'),
(N'Cashier', N'Thu ngân, thực hiện thanh toán và in hóa đơn.'),
(N'Sales', N'Nhân viên bán hàng, quản lý sản phẩm và khách hàng.'),
(N'Manager', N'Quản lý cửa hàng, theo dõi nhân sự và doanh thu.');
GO

-- ===========================
-- 2. Bảng Account
-- ===========================
CREATE TABLE Account (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    [Password] NVARCHAR(100) NOT NULL,
    [Role] NVARCHAR(50) NOT NULL,
    Active BIT NOT NULL DEFAULT 1
);

INSERT INTO Account (Username, [Password], [Role], Active)
VALUES
('admin', '123456', 'Admin', 1),
('cashier', '123456', 'Cashier', 1),
('sales', '123456', 'Sales', 1),
('manager', '123456', 'Manager', 1),
('banned', '123456', 'Sales', 0);
GO

-- ===========================
-- 3. Bảng Employee
-- ===========================
CREATE TABLE Employee (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100),
    Gender NVARCHAR(10),
    BirthDate DATE,
    [Address] NVARCHAR(200),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    RoleID INT,
    AccountID INT,
    CONSTRAINT FK_Employee_Role FOREIGN KEY (RoleID) REFERENCES Role(ID),
    CONSTRAINT FK_Employee_Account FOREIGN KEY (AccountID) REFERENCES Account(ID)
);

INSERT INTO Employee (FullName, Gender, BirthDate, [Address], Phone, Email, RoleID, AccountID)
VALUES
(N'Nguyễn Văn A', N'Nam', '1990-05-01', N'Hà Nội', '0901111111', 'a@shoeshop.com', 1, 1),
(N'Lê Thị B', N'Nữ', '1993-08-15', N'Hồ Chí Minh', '0902222222', 'b@shoeshop.com', 2, 2),
(N'Phạm Văn C', N'Nam', '1996-01-22', N'Đà Nẵng', '0903333333', 'c@shoeshop.com', 3, 3),
(N'Hoàng Thị D', N'Nữ', '1998-07-10', N'Hải Phòng', '0904444444', 'd@shoeshop.com', 4, 4),
(N'Trần Văn E', N'Nam', '1999-03-18', N'Cần Thơ', '0905555555', 'e@shoeshop.com', 3, 5);
GO

-- ===========================
-- 4. Bảng Brand (Nhà cung cấp)
-- ===========================
CREATE TABLE Brand (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(15),
    Email NVARCHAR(100)
);

INSERT INTO Brand ([Name], Phone, Email)
VALUES
(N'Nike', '0909009009', 'support@nike.com'),
(N'Adidas', '0908111222', 'contact@adidas.com'),
(N'Puma', '0907333444', 'info@puma.com'),
(N'Converse', '0909555666', 'hello@converse.com');
GO

-- ===========================
-- 5. Bảng Item (Sản phẩm)
-- ===========================
CREATE TABLE Item (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(100) NOT NULL,
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

INSERT INTO Item ([Name], Gender, Age, Size, [TypeID], Price, Stock, BrandID, Actived)
VALUES
(N'Nike Air Zoom', 2, '18', 20, 4, 2500000, 10, 1,1),
(N'Adidas UltraBoost', 2, '18',30, 4, 2800000, 12, 2,1),
(N'Puma Runner', 0, 'u18',35, 1, 1500000, 8, 3,1),
(N'Converse High', 0, 'u18',27, 1, 1300000, 15, 4,1);
GO

-- ===========================
-- 6. Bảng Bill (Hóa đơn)
-- ===========================
CREATE TABLE Bill (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID INT NOT NULL,
    [Date] DATETIME DEFAULT GETDATE(),
    Total DECIMAL(18,2) DEFAULT 0,
    BillType BIT DEFAULT 0, -- 0 = import, 1 = export
    BrandID INT NULL, -- Nếu là hóa đơn nhập
    Note NVARCHAR(200) NULL,
    CONSTRAINT FK_Bill_Account FOREIGN KEY (AccountID) REFERENCES Account(ID),
    CONSTRAINT FK_Bill_Brand FOREIGN KEY (BrandID) REFERENCES Brand(ID)
);
GO

-- ===========================
-- 7. Bảng BillDetail
-- ===========================
CREATE TABLE BillDetail (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    BillID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT CHECK (Quantity > 0),
    Price INT CHECK (Price >= 0),
    [Source] NVARCHAR(50) NULL,
    CONSTRAINT FK_BillDetail_Bill FOREIGN KEY (BillID) REFERENCES Bill(ID) ON DELETE CASCADE,
    CONSTRAINT FK_BillDetail_Item FOREIGN KEY (ItemID) REFERENCES Item(ID) ON DELETE CASCADE
);
GO

-- ===========================
-- 8. Trigger cập nhật tổng hóa đơn
-- ===========================
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

-- ===========================
-- 9. Dữ liệu mẫu
-- ===========================
-- Hóa đơn xuất hàng (bán hàng)
INSERT INTO Bill (AccountID, [Date], Total, BillType)
VALUES 
(1, '2025-11-01', 6300000, 1),
(2, '2025-11-02', 2800000, 1),
(3, '2025-11-03', 1300000, 1);

-- Hóa đơn nhập hàng từ Nike
INSERT INTO Bill (AccountID, [Date], Total, BillType, BrandID, Note)
VALUES
(4, GETDATE(), 4500000, 0, 1, N'Nhập hàng Nike tháng 11');
GO

-- ===========================
-- 10. Dữ liệu chi tiết hóa đơn
-- ===========================
INSERT INTO BillDetail (BillID, ItemID, Quantity, Price)
VALUES
(1, 1, 1, 2500000),
(1, 2, 1, 2800000),
(1, 3, 2, 1500000),
(2, 2, 1, 2800000),
(3, 4, 1, 1300000);
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

