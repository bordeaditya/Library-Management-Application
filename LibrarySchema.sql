USE [master]
GO
/****** Object:  Database [Library]    Script Date: 11/03/2014 02:04:36 ******/
CREATE DATABASE [Library] ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Library] SET ARITHABORT OFF
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Library] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Library] SET  READ_WRITE
GO
ALTER DATABASE [Library] SET RECOVERY FULL
GO
ALTER DATABASE [Library] SET  MULTI_USER
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Library', N'ON'
GO
USE [Library]
GO
/****** Object:  Table [dbo].[tblBOOK]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBOOK](
	[Book_id] [varchar](10) NOT NULL,
	[Title] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Book_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBORROWER]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBORROWER](
	[Card_no] [int] IDENTITY(1000,1) NOT NULL,
	[Fname] [varchar](20) NOT NULL,
	[Lname] [varchar](30) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Phone] [varchar](14) NULL,
	[City] [varchar](30) NULL,
	[State] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Card_no] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsers](
	[User_id] [varchar](20) NOT NULL,
	[Password] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLIBRARY_BRANCH]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLIBRARY_BRANCH](
	[Branch_id] [int] NOT NULL,
	[Branch_name] [varchar](40) NULL,
	[Address] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Branch_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBOOK_COPIES]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBOOK_COPIES](
	[Book_id] [varchar](10) NOT NULL,
	[Branch_id] [int] NOT NULL,
	[No_of_copies] [int] NULL,
	[No_of_copies_issued] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Book_id] ASC,
	[Branch_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBOOK_AUTHORS]    Script Date: 11/03/2014 02:04:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBOOK_AUTHORS](
	[Book_id] [varchar](10) NOT NULL,
	[Author_name] [varchar](40) NOT NULL,
	[Type] [int] NULL,
	[Role] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Book_id] ASC,
	[Author_name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspGetCardNoInfo]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To Check entered Card number is present in the system.
EXEC uspGetCardNoInfo 
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspGetCardNoInfo](
	@Card_no int
)
AS
BEGIN
	SELECT Fname,Lname FROM tblBORROWER WHERE Card_no = @Card_no
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetAvailableBookCountAtBranch]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To Check no of book copies available at particular branch.
EXEC uspGetAvailableBookCountAtBranch '1234567890',13 
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspGetAvailableBookCountAtBranch](
	@Book_id varchar(10),
	@Branch_id int
)
AS
BEGIN
	SELECT Title,(No_of_copies - No_of_copies_issued) AS AvailableCopies FROM tblBOOK_COPIES BC,tblBOOK BK where BC.Branch_id = @Branch_id AND BC.Book_id = @Book_id 
	AND BK.Book_id = @Book_id 
END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateIssuedCopiesCount]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To update the copies issued count after check in.
EXEC uspUpdateIssuedCopiesCount '1234567890',13 
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspUpdateIssuedCopiesCount](
	@Book_id varchar(10),
	@Branch_id int
)
AS
BEGIN
	UPDATE tblBOOK_COPIES SET No_of_copies_issued = (No_of_copies_issued - 1) 
	WHERE Branch_id = @Branch_id AND Book_id = @Book_id
END
GO
/****** Object:  Table [dbo].[tblBOOK_LOANS]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBOOK_LOANS](
	[Loan_id] [int] IDENTITY(1,1) NOT NULL,
	[Book_id] [varchar](10) NULL,
	[Branch_id] [int] NULL,
	[Card_no] [int] NULL,
	[Date_out] [datetime] NULL,
	[Due_date] [datetime] NULL,
	[Date_in] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Loan_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspGetBookInfo]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetBookInfo](
 @Book_id varchar(10),
 @Title varchar(100),
 @Author varchar(40),
 @Role varchar(30)
)
AS
BEGIN /*****SP BEGIN******/
		SELECT BK.Book_id,BK.Title,BA.Author_name,BA.Role,BC.Branch_id,LB.Branch_name,BC.No_of_copies,
		(BC.No_of_copies-BC.No_of_copies_issued) AS No_of_Available_copies 
		FROM tblBOOK BK
		INNER JOIN tblBOOK_AUTHORS BA ON BK.Book_id = BA.Book_id
		INNER JOIN tblBOOK_COPIES BC ON BA.Book_id = BC.Book_id
		INNER JOIN tblLIBRARY_BRANCH LB ON BC.Branch_id = LB.Branch_id
		WHERE BK.Book_id LIKE '%'+ @Book_id +'%' 
		AND BK.Title LIKE '%' + @Title + '%' AND BA.Author_name LIKE '%' + @Author + '%'
		AND BA.Role LIKE '%' + @Role + '%';
END/******SP END*****/
GO
/****** Object:  StoredProcedure [dbo].[uspGetCardNoBookIssuedCount]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To Check entered Card number(Borrwoer) issued no of books.
EXEC uspGetCardNoBookIssuedCount 
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspGetCardNoBookIssuedCount](
	@Card_no int
)
AS
BEGIN
	SELECT COUNT(*) from tblBOOK_LOANS where Card_no = @Card_no
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetBookCheckOutInfo]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To get the book check out information.
EXEC uspGetBookCheckOutInfo '',0,'AD' 
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspGetBookCheckOutInfo](
	@Book_id varchar(10),
	@Card_no int,
	@Borrower_name varchar(50)
)
AS
BEGIN
	IF (@Card_no = 0) /*IF Card Number IS NOT PROVIDED*/
		BEGIN
			SELECT BL.Book_id,BL.Branch_id,BR.Fname,BR.Lname,BR.Card_no,BL.Date_in
			FROM tblBOOK_LOANS BL
			INNER JOIN tblBORROWER BR ON BL.Card_no = BR.Card_no
			WHERE BL.Book_id LIKE '%' + @Book_id + '%'
			AND (BR.Fname + BR.Lname LIKE '%' + @Borrower_name + '%')
			AND BL.Date_in IS NULL;
		END
	ELSE /*Card Number IS PROVIDED*/
		BEGIN
			SELECT BL.Book_id,BL.Branch_id,BR.Fname,BR.Lname,BR.Card_no,BL.Date_in
			FROM tblBOOK_LOANS BL
			INNER JOIN tblBORROWER BR ON BL.Card_no = BR.Card_no
			WHERE BL.Book_id LIKE '%' + @Book_id + '%'
			AND BR.Card_no IN (@Card_no)
			AND (BR.Fname + BR.Lname LIKE '%' + @Borrower_name + '%')
			AND BL.Date_in IS NULL;
		END
END
GO
/****** Object:  Table [dbo].[tblFINES]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFINES](
	[Loan_id] [int] NOT NULL,
	[Book_id] [varchar](10) NULL,
	[Branch_id] [int] NULL,
	[Fine_amount] [decimal](8, 2) NULL,
	[paid] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Loan_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspGetFinesById]    Script Date: 11/03/2014 02:04:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------------******************************
Author : Aditya Borde
SP : To get FINES information.
EXEC uspGetFinesById 1000,'ABo'
----------------------*******************************/
CREATE PROCEDURE [dbo].[uspGetFinesById](
	@Card_no int,
	@Borrower_name varchar(50),
	@IsReturned bit
)
AS
BEGIN
	IF(@IsReturned = 1)/*Book is Already Returned*/
	BEGIN
		IF(@Card_no = 0) /*if Card Number is Not entered*/
			BEGIN
				SELECT BR.Card_no,BL.Loan_id,(BR.Fname +' '+ BR.Lname) AS Name,BK.Title,BK.Book_id,BL.Branch_id,FN.Fine_amount FROM tblBORROWER BR
				INNER JOIN tblBOOK_LOANS BL ON BR.Card_no = BL.Card_no
				INNER JOIN tblBOOK BK ON BK.Book_id = BL.Book_id
				INNER JOIN tblFINES FN ON BL.Loan_id = FN.Loan_id
				WHERE BL.Date_in IS NOT NULL AND FN.paid = 0 AND (BR.Fname + BR.Lname) LIKE '%'+@Borrower_name+'%';
			END
		ELSE /*Card Number is Mentioned*/
			BEGIN
				SELECT BR.Card_no,BL.Loan_id,(BR.Fname +' '+ BR.Lname) AS Name,BK.Title,BK.Book_id,BL.Branch_id,FN.Fine_amount FROM tblBORROWER BR
				INNER JOIN tblBOOK_LOANS BL ON BR.Card_no = BL.Card_no
				INNER JOIN tblBOOK BK ON BK.Book_id = BL.Book_id
				INNER JOIN tblFINES FN ON BL.Loan_id = FN.Loan_id
				WHERE BL.Date_in IS NOT NULL AND FN.paid = 0 AND BL.Card_no = @Card_no;
			END
	END
	ELSE /*BOOK IS NOT RETURNED*/
	BEGIN
		IF(@Card_no = 0) /*if Card Number is Not entered*/
			BEGIN
				SELECT BR.Card_no,BL.Loan_id,(BR.Fname +' '+ BR.Lname) AS Name,BK.Title,BK.Book_id,BL.Branch_id,FN.Fine_amount FROM tblBORROWER BR
				INNER JOIN tblBOOK_LOANS BL ON BR.Card_no = BL.Card_no
				INNER JOIN tblBOOK BK ON BK.Book_id = BL.Book_id
				INNER JOIN tblFINES FN ON BL.Loan_id = FN.Loan_id
				WHERE BL.Date_in IS NULL AND FN.paid = 0 AND (BR.Fname + BR.Lname) LIKE '%'+@Borrower_name+'%';
			END
		ELSE /*Card Number is Mentioned*/
			BEGIN
				SELECT BR.Card_no,BL.Loan_id,(BR.Fname +' '+ BR.Lname) AS Name,BK.Title,BK.Book_id,BL.Branch_id,FN.Fine_amount FROM tblBORROWER BR
				INNER JOIN tblBOOK_LOANS BL ON BR.Card_no = BL.Card_no
				INNER JOIN tblBOOK BK ON BK.Book_id = BL.Book_id
				INNER JOIN tblFINES FN ON BL.Loan_id = FN.Loan_id
				WHERE BL.Date_in IS NULL AND FN.paid = 0 AND BL.Card_no = @Card_no;
			END
	END
	
END
GO
/****** Object:  Default [DF__tblBOOK_C__No_of__5DCAEF64]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_COPIES] ADD  DEFAULT ((0)) FOR [No_of_copies_issued]
GO
/****** Object:  Default [DF__tblBOOK_AU__Type__73BA3083]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_AUTHORS] ADD  DEFAULT ((1)) FOR [Type]
GO
/****** Object:  Default [DF__tblBOOK_AU__Role__07C12930]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_AUTHORS] ADD  DEFAULT ('Author') FOR [Role]
GO
/****** Object:  Default [DF__tblFINES__Fine_a__03F0984C]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblFINES] ADD  DEFAULT ((0)) FOR [Fine_amount]
GO
/****** Object:  Default [DF__tblFINES__paid__04E4BC85]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblFINES] ADD  DEFAULT ((1)) FOR [paid]
GO
/****** Object:  ForeignKey [FK__tblBOOK_C__Book___5BE2A6F2]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_COPIES]  WITH NOCHECK ADD FOREIGN KEY([Book_id])
REFERENCES [dbo].[tblBOOK] ([Book_id])
GO
/****** Object:  ForeignKey [FK__tblBOOK_C__Branc__5CD6CB2B]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_COPIES]  WITH NOCHECK ADD FOREIGN KEY([Branch_id])
REFERENCES [dbo].[tblLIBRARY_BRANCH] ([Branch_id])
GO
/****** Object:  ForeignKey [FK__tblBOOK_A__Book___21B6055D]    Script Date: 11/03/2014 02:04:36 ******/
ALTER TABLE [dbo].[tblBOOK_AUTHORS]  WITH CHECK ADD FOREIGN KEY([Book_id])
REFERENCES [dbo].[tblBOOK] ([Book_id])
GO
/****** Object:  ForeignKey [FK__tblBOOK_L__Book___3E52440B]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblBOOK_LOANS]  WITH CHECK ADD FOREIGN KEY([Book_id])
REFERENCES [dbo].[tblBOOK] ([Book_id])
GO
/****** Object:  ForeignKey [FK__tblBOOK_L__Branc__3F466844]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblBOOK_LOANS]  WITH CHECK ADD FOREIGN KEY([Branch_id])
REFERENCES [dbo].[tblLIBRARY_BRANCH] ([Branch_id])
GO
/****** Object:  ForeignKey [FK__tblBOOK_L__Card___403A8C7D]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblBOOK_LOANS]  WITH CHECK ADD FOREIGN KEY([Card_no])
REFERENCES [dbo].[tblBORROWER] ([Card_no])
GO
/****** Object:  ForeignKey [FK__tblFINES__Book_i__02084FDA]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblFINES]  WITH CHECK ADD FOREIGN KEY([Book_id])
REFERENCES [dbo].[tblBOOK] ([Book_id])
GO
/****** Object:  ForeignKey [FK__tblFINES__Branch__02FC7413]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblFINES]  WITH CHECK ADD FOREIGN KEY([Branch_id])
REFERENCES [dbo].[tblLIBRARY_BRANCH] ([Branch_id])
GO
/****** Object:  ForeignKey [FK__tblFINES__Loan_i__01142BA1]    Script Date: 11/03/2014 02:04:37 ******/
ALTER TABLE [dbo].[tblFINES]  WITH CHECK ADD FOREIGN KEY([Loan_id])
REFERENCES [dbo].[tblBOOK_LOANS] ([Loan_id])
GO
