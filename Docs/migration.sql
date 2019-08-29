CREATE TABLE [dbo].[ConnectionTest](
	[Id]		[int] IDENTITY(1,1) NOT NULL,
	[Name]		[nvarchar](255) NULL,
	[Category]	[nvarchar](255) NULL,
	CONSTRAINT PK_CT_Id PRIMARY KEY (Id)
)

INSERT INTO [ConnectionTest] ([Name], [Category]) VALUES (N'Teve', N'Állat');
INSERT INTO [ConnectionTest] ([Name], [Category]) VALUES (N'Pupu', N'Akármi');