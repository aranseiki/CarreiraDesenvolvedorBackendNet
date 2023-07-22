SELECT TOP 100
    [id], [Nome], [CategoriaId]
FROM
    [Curso]
-- WHERE
--     [CategoriaId] = 1
ORDER BY
    [Nome], [Id], [CategoriaId] DESC


SELECT TOP 100
    COUNT([id])
FROM
    [Curso]


SELECT TOP 100
    AVG([id])
FROM
    [Curso]


SELECT TOP 100
    SUM([id])
FROM
    [Curso]


SELECT TOP 100
    *
FROM
    [Curso]
WHERE
    [Nome] LIKE '%Fundamentos%'


SELECT TOP 100
    *
FROM
    [Curso]
WHERE
    [Id] IN (1, 3)


SELECT TOP 100
    *
FROM
    [Curso]
WHERE
    [Id] BETWEEN 1 AND 3


SELECT TOP 100
    [Id] as [Codigo],
    [Nome]
FROM
    [Curso]


SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [CategoriaId],
    [Categoria].[Nome] AS [CategoriaNome]
FROM
    [Curso]
INNER JOIN
    [Categoria] ON [Curso].[CategoriaId] = [Categoria].[Id]


SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [CategoriaId],
    [Categoria].[Nome] AS [CategoriaNome]
FROM
    [Curso]
LEFT JOIN
    [Categoria] ON [Curso].[CategoriaId] = [Categoria].[Id]


SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [CategoriaId],
    [Categoria].[Nome] AS [CategoriaNome]
FROM
    [Curso]
RIGHT JOIN
    [Categoria] ON [Curso].[CategoriaId] = [Categoria].[Id]


SELECT TOP 100
    [Curso].[Id],
    [Curso].[Nome],
    [Categoria].[Id] AS [CategoriaId],
    [Categoria].[Nome] AS [CategoriaNome]
FROM
    [Curso]
FULL JOIN
    [Categoria] ON [Curso].[CategoriaId] = [Categoria].[Id]


SELECT TOP 100
    [Id], [Nome]
FROM
    [Curso]

UNION ALL

SELECT TOP 100
    [Id], [Nome]
FROM
    [Categoria]


SELECT TOP 100
    [Categoria].[Id],
    [Categoria].[Nome],
    COUNT([Curso].[CategoriaId]) AS [CURSOS]
FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]


SELECT TOP 100
    [Categoria].[Id],
    [Categoria].[Nome],
    COUNT([Curso].[CategoriaId]) AS [CURSOS]
FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]
HAVING
    [Categoria].[Id] > 1


CREATE OR ALTER VIEW vwContagemCursosPorCategoria AS
    SELECT TOP 100
        [Categoria].[Id],
        [Categoria].[Nome],
        COUNT([Curso].[CategoriaId]) AS [CURSOS]
    FROM
        [Categoria]
        INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
    GROUP BY
        [Categoria].[Id],
        [Categoria].[Nome],
        [Curso].[CategoriaId]
    HAVING
        [Categoria].[Id] > 1

SELECT
    *
FROM
    vwContagemCursosPorCategoria
WHERE
    [Nome] = 'Frontend'
