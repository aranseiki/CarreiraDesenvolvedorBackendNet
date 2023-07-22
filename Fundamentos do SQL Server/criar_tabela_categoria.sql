USE [master];

CREATE TABLE [Categoria] (
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) Not NULL,
    [Categoria] INT NOT NULL,

    CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
)
GO
