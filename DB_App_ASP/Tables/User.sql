CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NCHAR(50) NOT NULL, 
    [Prenom] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [Pwd] NCHAR(200) NOT NULL, 
    [Confirmation] NCHAR(200) NOT NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]) 
)
