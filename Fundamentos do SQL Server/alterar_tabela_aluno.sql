USE [Curso]

ALTER TABLE [Aluno]
    ADD [Document] NVARCHAR(11)

ALTER TABLE [Aluno]
    DROP COLUMN [Document]

ALTER TABLE [Aluno]
    ALTER COLUMN [Document] CHAR(11)

ALTER TABLE [ALuno]
    ALTER COLUMN [Active] BIT NOT NULL

ALTER TABLE [Aluno]
    ADD PRIMARY KEY([Id])

ALTER TABLE [Aluno]
    DROP CONSTRAINT [PK_Aluno]