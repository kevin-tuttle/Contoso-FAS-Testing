CREATE TABLE [dbo].[TestRequest]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[TestFunctionId] INT NOT NULL,
    [Url] NVARCHAR(MAX) NOT NULL, 
    [Referer] NVARCHAR(MAX) NOT NULL, 
    [BodyText] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_TestRequest_ToTable] FOREIGN KEY ([TestFunctionId]) REFERENCES [TestFunction]([Id])
)
