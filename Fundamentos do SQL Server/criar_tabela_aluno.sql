USE [Curso]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL UNIQUE,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Active] BIT NOT NULL DEFAULT(0),

    CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email]),
)
GO