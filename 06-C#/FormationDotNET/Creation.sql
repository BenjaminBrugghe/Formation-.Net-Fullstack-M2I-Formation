CREATE TABLE [dbo].[Livre]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Titre] VARCHAR(150) NOT NULL,
    [Auteur] VARCHAR(50) NOT NULL, 
    [Editeur] VARCHAR(50) NOT NULL, 
    [Date_publication] DATE NOT NULL, 
    [isbn_10] VARCHAR(10) NOT NULL,
    [isbn_13] VARCHAR(15) NOT NULL
)