DROP TABLE [utilisateur]



CREATE TABLE [dbo].[utilisateur]
(
	[Id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Prenom] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Telephone] VARCHAR(17) NOT NULL
)

-- Insertions de values

INSERT INTO [dbo].[utilisateur] ([Nom], [Prenom], [Email], [Telephone]) 
VALUES (N'Mister', N'Bean', N'Bean@gmail.com', N'+33 6 07 08 09 10'),
		(N'Brugghe', N'Benjamin', N'Test@gmail.com', N'+33 6 07 08 08 08')
