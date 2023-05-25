CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null, 
    [ManagerId] INT NULL FOREIGN KEY REFERENCES Employee(Id)
)
