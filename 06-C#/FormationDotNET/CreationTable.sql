-- Requêtes Ajouts et réinitialisation

--DROP TABLE [Table]

CREATE TABLE [dbo].[TableEx1]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Titre] VARCHAR(50) NOT NULL,
    [Nom] VARCHAR(50) NOT NULL, 
    [Prenom] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Telephone] VARCHAR(17) NOT NULL
)


