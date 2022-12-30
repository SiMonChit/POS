USE [master]
GO
/****** Object:  Database [POS]    Script Date: 12/30/2022 4:27:19 PM ******/
CREATE DATABASE [POS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\POS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\POS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [POS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POS] SET ARITHABORT OFF 
GO
ALTER DATABASE [POS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POS] SET  MULTI_USER 
GO
ALTER DATABASE [POS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [POS] SET QUERY_STORE = OFF
GO
USE [POS]
GO
/****** Object:  Table [dbo].[AutoGenerate]    Script Date: 12/30/2022 4:27:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutoGenerate](
	[GenerateID] [int] IDENTITY(1,1) NOT NULL,
	[GenerateDate] [datetime] NULL,
	[Synbol] [varchar](5) NULL,
	[LastValue] [int] NULL,
	[GenerateType] [varchar](10) NULL,
 CONSTRAINT [PK_AutoGenerate] PRIMARY KEY CLUSTERED 
(
	[GenerateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CashBook]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashBook](
	[CashBookID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_CashBook] PRIMARY KEY CLUSTERED 
(
	[CashBookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[ExpenseID] [char](36) NOT NULL,
	[CashBookID] [int] NOT NULL,
	[Description] [ntext] NULL,
	[Amount] [decimal](18, 0) NULL,
	[AproveBy] [nvarchar](50) NULL,
	[ExpDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemsID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[ItemsImage] [image] NULL,
	[ItemCode] [nvarchar](50) NULL,
	[ItemName] [nvarchar](100) NULL,
	[SellPrice] [money] NULL,
	[BuyPrice] [money] NULL,
	[Qty] [decimal](18, 2) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[ItemsID] [int] NOT NULL,
	[BuyPrice] [decimal](18, 0) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](18, 0) NULL,
	[PurchaseDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleHeader]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleHeader](
	[HeaderId] [char](36) NOT NULL,
	[VoucherNo] [varchar](50) NOT NULL,
	[VoucherDate] [datetime] NOT NULL,
	[SubTotal] [decimal](18, 0) NULL,
	[Tax] [decimal](18, 0) NULL,
	[GrandTotal] [decimal](18, 0) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_SaleHeader] PRIMARY KEY CLUSTERED 
(
	[HeaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleItem]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleItem](
	[SaleItemID] [int] IDENTITY(1,1) NOT NULL,
	[HeaderID] [int] NULL,
	[ItemsID] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](18, 0) NULL,
	[IsActiv] [bit] NULL,
 CONSTRAINT [PK_SaleItem] PRIMARY KEY CLUSTERED 
(
	[SaleItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD  CONSTRAINT [FK_Expense_CashBook] FOREIGN KEY([CashBookID])
REFERENCES [dbo].[CashBook] ([CashBookID])
GO
ALTER TABLE [dbo].[Expense] CHECK CONSTRAINT [FK_Expense_CashBook]
GO
/****** Object:  StoredProcedure [dbo].[AutoCodeGenerator]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AutoCodeGenerator]

--@LastNo int
@GenerateType nvarchar(10)
--@ReturnAutogenerateCode varchar(30) output
AS


BEGIN

declare @LastNo int
declare @ReturnAutogenerateCode varchar(30) 
declare @String varchar(10)
declare @month varchar(10)
declare @year varchar(10)
declare @zero varchar(10)

Select @LastNo=LastValue From AutoGenerate Where GenerateType=@GenerateType

--set @LastNo=3
set @zero=(

SELECT
Case  (SELECT LEN(@LastNo))

WHEN 1 THEN '000000'
WHEN 2 THEN '00000'
WHEN 3 THEN '0000'
WHEN 4 THEN '000'
WHEN 5 THEN '00'
WHEN 6 THEN '0'
ELSE ''
END)


set @String=(SELECT CONVERT(varchar(10), @LastNo))
set @month=(SELECT CONVERT(varchar,month(getdate())))
--set @year =(select convert(varchar,Right(Year(getDate()),2)))


If @GenerateType='V'
BEGIN
Set @ReturnAutogenerateCode=('V'+@zero+@String);

Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='1'
End
ELSE IF @GenerateType='Payment'
BEGIN
Set @ReturnAutogenerateCode=('P'+@month+@zero+@String);
Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='3'

End
ELSE IF @GenerateType='ROLL'
BEGIN
Set @ReturnAutogenerateCode=('S'+@zero+@String);
Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='2'

End
ELSE IF @GenerateType='JOB'
BEGIN
Set @ReturnAutogenerateCode=('J'+@zero+@String);
Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='4'

End


ELSE IF @GenerateType='Folio'
BEGIN
Set @ReturnAutogenerateCode=('F'+@month+@zero+@String);
Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='5'

End

ELSE IF @GenerateType='StReturn'
BEGIN
Set @ReturnAutogenerateCode=('STR'+@month+''+@zero+@String);
Update AutoGenerate SET LastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateID='6'

End

Select @ReturnAutogenerateCode As AutogenerateCode
END










GO
/****** Object:  StoredProcedure [dbo].[AutoGenerate_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AutoGenerate_Insert]
	@LastValue	INT,
	@GenerateType VARCHAR(10),
	@Synbol VARCHAR(5)
AS
BEGIN
	INSERT AutoGenerate VALUES(GETDATE(), @Synbol, @LastValue, @GenerateType)
END
GO
/****** Object:  StoredProcedure [dbo].[AutoGenerate_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AutoGenerate_Select]
AS
BEGIN
	SELECT * FROM AutoGenerate
END
GO
/****** Object:  StoredProcedure [dbo].[AutoGenerate_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AutoGenerate_Update]
	@GenerateID INT,
	@LastValue	INT,
	@GenerateType VARCHAR(10),
	@Synbol VARCHAR(5)
AS
BEGIN
	UPDATE AutoGenerate SET Synbol = @Synbol, LastValue = @LastValue, GenerateType =  @GenerateType
	WHERE GenerateID = @GenerateID
END
GO
/****** Object:  StoredProcedure [dbo].[CashBook_Delete]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CashBook_Delete]
	@CashBookID	CHAR(36)
AS
BEGIN

	UPDATE CashBook SET Active=0
	WHERE CashBookID=@CashBookID
END
GO
/****** Object:  StoredProcedure [dbo].[CashBook_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CashBook_Insert]
	@Code		NVARCHAR(50),
	@Name		NVARCHAR(100)
AS
BEGIN
	IF NOT EXISTS(SELECT Code, [Name] FROM CashBook WHERE Code=@Code AND [Name]=@Name AND Active=1)

	INSERT CashBook VALUES(@Code, @Name, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[CashBook_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CashBook_Select]
AS
BEGIN
SELECT * FROM
CashBook
WHERE Active=1
END
GO
/****** Object:  StoredProcedure [dbo].[CashBook_SelectForDropDownList]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CashBook_SelectForDropDownList]

AS
BEGIN
SELECT CashBookID, Code+' '+ [Name] AS Code FROM
CashBook
WHERE Active=1
ORDER BY Code, [Name]
END
GO
/****** Object:  StoredProcedure [dbo].[CashBook_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CashBook_Update]
	@CashBookID	CHAR(36),
	@Code		NVARCHAR(50),
	@Name		NVARCHAR(100)
AS
BEGIN
	IF NOT EXISTS(SELECT Code, [Name] FROM CashBook WHERE Code=@Code AND [Name]=@Name AND Active=1)

	UPDATE CashBook SET Code = @Code, [Name] = @Name
	WHERE CashBookID=@CashBookID
END
GO
/****** Object:  StoredProcedure [dbo].[Category_Delete]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Category_Delete]
	@CategoryID int
AS
BEGIN
	UPDATE Category SET
	IsActive = 0
	WHERE CategoryID = @CategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Category_Insert]
	@Code	NVARCHAR(50),
	@CategoryName NVARCHAR(100)
AS
BEGIN
	INSERT Category VALUES
	(
		@Code, @CategoryName, 1
	)
END
GO
/****** Object:  StoredProcedure [dbo].[Category_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Category_Select]
AS
BEGIN
	SELECT * FROM Category
	WHERE Category.IsActive = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Category_Update]
	@CategoryID int,
	@Code	NVARCHAR(50),
	@CategoryName NVARCHAR(100)
AS
BEGIN
	UPDATE Category SET
	Code = @Code, CategoryName = @CategoryName
	
	WHERE CategoryID = @CategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_Delete]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_Delete]
	@ExpenseID CHAR(36)
AS
BEGIN
	UPDATE DailyExpense SET
	Active=0
	WHERE ExpenseID=@ExpenseID
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_Insert]
	@CashBookID	CHAR(36),
	@Description ntext,
	@Amount		decimal(18,0),
	@ApproveBy	nvarchar(50),
	@ExpDate	DATETIME
AS
BEGIN
	INSERT Expense VALUES(NEWID(),@CashBookID, @Description, @Amount, @ApproveBy, @ExpDate, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_Select]
AS
BEGIN
	SELECT Expense.*, Code+' '+[Name] AS Code FROM Expense 
	INNER JOIN CashBook ON CashBook.CashBookID=Expense.CashBookID
	WHERE Expense.IsActive=1
	ORDER BY ExpDate DESC
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_SelectByCashBookID]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_SelectByCashBookID]
	@CashBookID	CHAR(36)
AS
BEGIN
	SELECT Expense.*, Code+' '+[Name] AS Name FROM Expense 
	INNER JOIN CashBook ON CashBook.CashBookID=Expense.CashBookID
	WHERE Expense.IsActive=1
	AND Expense.CashBookID=@CashBookID
	ORDER BY ExpDate DESC
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_SelectByDate]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_SelectByDate]
	@FromDate datetime,
	@ToDate datetime
AS
BEGIN
	SELECT Expense.*, Code+' '+[Name] AS [Name] FROM Expense 
	INNER JOIN CashBook ON CashBook.CashBookID=Expense.CashBookID
	WHERE
	(DAY(ExpDate)=DAY(@FromDate) ANd DAY(ExpDate)=DAY(@ToDate))
	AND (MONTH(ExpDate)=MONTH(@FromDate) AND MONTH(ExpDate)= MONTH(@ToDate))
	AND (YEAR(ExpDate)=YEAR(@FromDate) AND YEAR(ExpDate)= YEAR(@ToDate))
	--ExpDate BETWEEN @FromDate AND @ToDate
	AND Expense.IsActive=1
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_SelectByID]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_SelectByID]
	@ExpenseID CHAR(36)
AS
BEGIN
	SELECT Expense.*, Code+' '+[Name] AS Code FROM Expense 
	INNER JOIN CashBook ON CashBook.CashBookID=Expense.CashBookID
	WHERE Expense.IsActive=1 AND
	ExpenseID=@ExpenseID
END
GO
/****** Object:  StoredProcedure [dbo].[Expense_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Expense_Update]
	@ExpenseID CHAR(36),
	@CashBookID	CHAR(36),
	@Description ntext,
	@Amount		decimal(18,0),
	@ApproveBy	nvarchar(50),
	@ExpDate	DATETIME
AS
BEGIN
	UPDATE Expense SET
	CashBookID = @CashBookID,
	Description = @Description,
	Amount = @Amount,
	AproveBy = @ApproveBy,
	ExpDate= @ExpDate
	WHERE ExpenseID=@ExpenseID
END
GO
/****** Object:  StoredProcedure [dbo].[FakeAutoCodeGenerator]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FakeAutoCodeGenerator]

@GenerateType nvarchar(10)

AS

BEGIN

declare @LastNo int
declare @ReturnAutogenerateCode varchar(30) 
declare @String varchar(10)
declare @month varchar(10)
declare @year varchar(10)
declare @zero varchar(10)

Select @LastNo=LastValue From AutoGenerate Where GenerateType=@GenerateType

--set @LastNo=3
set @zero=(

SELECT
Case  (SELECT LEN(@LastNo))

WHEN 1 THEN '000000'
WHEN 2 THEN '00000'
WHEN 3 THEN '0000'
WHEN 4 THEN '000'
WHEN 5 THEN '00'
WHEN 6 THEN '0'
ELSE ''
END)


set @String=(SELECT CONVERT(varchar(10), @LastNo))
set @month=(SELECT CONVERT(varchar,month(getdate())))
--set @year =(select convert(varchar,Right(Year(getDate()),2)))


If @GenerateType='V'
BEGIN
Set @ReturnAutogenerateCode=('V'+@zero+@String);

--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='1'
End
ELSE IF @GenerateType='PAY'
BEGIN
Set @ReturnAutogenerateCode='P'+(@zero+@String);
--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='2'

End
ELSE IF @GenerateType='SALARY'
BEGIN
Set @ReturnAutogenerateCode=('S'+@zero+@String);
--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='2'

End
ELSE IF @GenerateType='Store'
BEGIN
Set @ReturnAutogenerateCode=('S'+@zero+@String);
--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='4'

End

ELSE IF @GenerateType='MStore'
BEGIN
Set @ReturnAutogenerateCode=('MS'+@zero+@String);
--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='5'

End

ELSE IF @GenerateType='StReturn'
BEGIN
Set @ReturnAutogenerateCode=('STR'+@zero+@String);
--Update AutoGenerate SET GenerateLastValue=(@LastNo+1) ,GenerateDate=getdate() Where GenerateId='5'

End

Select @ReturnAutogenerateCode As AutogenerateCode
END




GO
/****** Object:  StoredProcedure [dbo].[Items_Delete]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_Delete]
	@ItemsID	int
AS
BEGIN
	UPDATE Items SET IsActive = 0 WHERE ItemsID = @ItemsID
END
GO
/****** Object:  StoredProcedure [dbo].[Items_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_Insert]
	@CategoryID int,
	@ItemsImage	image,
	@ItemCode NVARCHAR(50),
	@ItemName nvarchar(50),
	@SellPrice decimal(18,0),
	@BuyPrice decimal(15,0),
	@Qty	int
AS
BEGIN
	insert into Items VALUES
	(
		@CategoryID, @ItemsImage, @ItemCode, @ItemName, @SellPrice, @BuyPrice, @Qty, 1
	)
END
GO
/****** Object:  StoredProcedure [dbo].[Items_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_Select]
as
begin
	SELECT * FROM ItemS
	INNER JOIN Category ON Category.CategoryID = ItemS.CategoryID
	WHERE ItemS.IsActive = 1
end
GO
/****** Object:  StoredProcedure [dbo].[Items_SelectByCode]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_SelectByCode]
	@ItemCode	VARCHAR(10)
AS
BEGIN

	SELECT * FROM Items
	INNER JOIN Category ON Items.CategoryID = Category.CategoryID
	WHERE Items.IsActive = 1 AND ItemCode = @ItemCode

END
GO
/****** Object:  StoredProcedure [dbo].[Items_SelectByID]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_SelectByID]
	@ItemsID	INT
AS
BEGIN

	SELECT * FROM Items
	INNER JOIN Category ON Items.CategoryID = Category.CategoryID
	WHERE Items.IsActive = 1 AND ItemsID = @ItemsID

END
GO
/****** Object:  StoredProcedure [dbo].[Items_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Items_Update]
	@ItemID	int,
	@CategoryID int,
	@ItemsImage	image,
	@ItemCode NVARCHAR(50),
	@ItemName nvarchar(50),
	@SellPrice decimal(18,0),
	@BuyPrice decimal(15,0),
	@ItemQty	int
AS
BEGIN
	UPDATE Items SET
	CategoryID = @CategoryID,
	ItemCode = @ItemCode,
	ItemName= @ItemName,
	SellPrice = @SellPrice,
	BuyPrice = @BuyPrice,
	Qty = @ItemQty
	WHERE ItemsID = @ItemID
END
GO
/****** Object:  StoredProcedure [dbo].[Purchase_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Purchase_Insert]
	@ItemsID	INT,
	@Qty			INT,
	@BuyPrice		MONEY,
	@Amount			DECIMAL(18,0),
	@PurchaseDate		DATETIME
AS
BEGIN
	INSERT Purchase VALUES(@ItemsID, @BuyPrice, @Qty, @Amount,
	@PurchaseDate , 1)

	UPDATE Items SET Qty = Qty+@Qty WHERE ItemsID = @ItemsID
	
END
GO
/****** Object:  StoredProcedure [dbo].[Purchase_Select]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Purchase_Select]
AS
BEGIN
SELECT TOP(100) dbo.Purchase.*, Items.ItemCode, Items.ItemCode + ' - ' +Items.ItemName AS ItemName
FROM            dbo.Purchase 
INNER JOIN Items ON dbo.Purchase.ItemsID = dbo.Items.ItemsID
END
GO
/****** Object:  StoredProcedure [dbo].[Purchase_Update]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Purchase_Update]
	@PurchaseID	CHAR(36),
	@ItemsID	INT,
	@ConvensionId	CHAR(36),
	@Qty			INT,
	@BuyPrice		MONEY,
	@PurchaseDate		DATETIME
AS
BEGIN
	
	DECLARE @OldQty DECIMAL(18,0)
	SET @OldQty=(SELECT Qty FROM Items WHERE ItemsID=@ItemsID)

	UPDATE Purchase SET ItemsID = @ItemsID, Qty = @Qty,
	BuyPrice = @BuyPrice,
	PurchaseDate = @PurchaseDate WHERE PurchaseID = @PurchaseID

	UPDATE Items SET
	Qty=Qty-@OldQty
	WHERE ItemsID = @ItemsID


	--UPDATE StockBalance SET
	--Qty=@Qty, ExpDate = @Exp_Date
	--WHERE StockId=@StockID AND ConversionId=@ConvensionId AND MONTH(ExpDate)=MONTH(@Exp_Date)
	--AND YEAR(ExpDate)=YEAR(@Exp_Date)
	--INSERT StockBalance VALUES(NEWID(), @StockID, @ConvensionId, @Qty, @Pur_Price, @Exp_Date)
END
GO
/****** Object:  StoredProcedure [dbo].[SaleHeader_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SaleHeader_Insert]
	@VoucherNo VARCHAR(50),
	@VoucherDate	DATETIME,
	@SubTotal	DECIMAL(18,0),
	@Tax	DECIMAL(18,0),
	@GrandTotal DECIMAL(18,0)

AS
BEGIN

	INSERT SaleHeader VALUES(NEWID(), @VoucherNo, @VoucherDate, @SubTotal, @Tax, @GrandTotal,1)
END
GO
/****** Object:  StoredProcedure [dbo].[SaleItem_Insert]    Script Date: 12/30/2022 4:27:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SaleItem_Insert]
	@HeaderID	CHAR(36),
	@ItemsID	int,
	@Price	DECIMAL(18,0),
	@Qty	INT,
	@Amount	DECIMAL(18,0)

AS
BEGIN
	INSERT SaleItem VALUES(@HeaderID, @ItemsID, @Price, @Qty, @Amount,1)
END
GO
USE [master]
GO
ALTER DATABASE [POS] SET  READ_WRITE 
GO
