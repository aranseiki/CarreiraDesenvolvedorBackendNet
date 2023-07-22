USE [master];

DROP TABLE [Curso]

CREATE TABLE [Curso] (
    [Id] UNIQUEIDENTIFIER NOT NULL,
    [Nome] NVARCHAR(80) Not NULL,
    [Categoria] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([Categoria])
        REFERENCES [Categoria](Id)
)
GO

/* OU */

CREATE TABLE [Curso] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Nome] NVARCHAR(80) Not NULL,
    [Categoria] INT NOT NULL,

    CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
    CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([Categoria])
        REFERENCES [Categoria](Id)
)
GO