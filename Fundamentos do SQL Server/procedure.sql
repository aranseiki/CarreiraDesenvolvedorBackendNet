CREATE OR ALTER PROCEDURE [spListCourses]
    @Category NVARCHAR(60),
    @Param2 NVARCHAR(60)
AS
    DECLARE @CategoryId INT
    SET @CategoryId = (
        SELECT TOP 1
            [Id]
        FROM
            [Categoria]
        WHERE
            [Nome] = @Category
    )

    SELECT
        *
    FROM
        [Curso]
    WHERE
        [CategoriaId] = @CategoryId

EXEC spListCourses 'Backend', 'Parametro 2'

DROP PROCEDURE spListCourses

