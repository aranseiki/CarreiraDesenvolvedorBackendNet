CREATE TABLE [ProgressoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT [PK_Progresso_Curso] PRIMARY KEY([AlunoId], [CursoId])
)
GO