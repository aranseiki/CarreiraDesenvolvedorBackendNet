DECLARE @StudentId UNIQUEIDENTIFIER = '348bbf90-bf15-4cd6-9cb2-4830cca7be61'

SELECT
    [Student].[Name] AS Student,
    [Course].[Title] AS Course,
    [StudentCourse].[Progress],
    [StudentCourse].[LastUpdateDate] AS LastUpdateDate
FROM
    [StudentCourse]
    INNER JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
    INNER JOIN [Course] ON [StudentCourse].[CourseId] = [Course].[Id]
WHERE
    [StudentCourse].[StudentId] = @StudentId
    AND [StudentCourse].[Progress] < 100
    AND [StudentCourse].[Progress] > 0
ORDER BY
    [StudentCourse].[LastUpdateDate] DESC


SELECT
    [Course].[Title] AS Course,
    [Student].[Name] AS Student,
    [StudentCourse].[Progress],
    [StudentCourse].[LastUpdateDate]
FROM
    [Course]
    LEFT JOIN [StudentCourse] ON [StudentCourse].[CourseId] = [Course].[Id]
    LEFT JOIN [Student] ON [StudentCourse].[StudentId] = [Student].[Id]
