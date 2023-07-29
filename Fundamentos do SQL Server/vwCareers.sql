/*
SELECT
    [Id],
    [Title],
    [Url],
    (SELECT COUNT([CareerId]) FROM [CareerItem] WHERE [CareerId] = [Id]) as [Courses]
FROM
    [Career]
*/

CREATE OR ALTER VIEW vwCareers AS
    SELECT
        [Career].[Id],
        [Career].[Title],
        [Career].[Url],
        COUNT([Id]) AS Courses
    FROM
        [Career]
        INNER JOIN [CareerItem] ON [CareerItem].[CareerId] = [Career].[Id]
    GROUP BY
        [Career].[Id],
        [Career].[Title],
        [Career].[Url]
