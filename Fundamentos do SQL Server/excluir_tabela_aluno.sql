USE [Curso]

CREATE TABLE [Aluno](
    [Id] INT NOT NULL,
    [Nome] NVARCHAR(80) NOT NULL,
    [Nascimento] DATETIME NOT NULL,
    [Active] BIT,
)
GO