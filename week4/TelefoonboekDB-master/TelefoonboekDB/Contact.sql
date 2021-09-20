CREATE TABLE [dbo].[Contact]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Voornaam] NVARCHAR(50) NOT NULL, 
    [Achternaam] NVARCHAR(50) NOT NULL, 
    [Telefoonnummer] NVARCHAR(20) NULL, 
    [Geboortedatum] DATETIME2 NULL
)
