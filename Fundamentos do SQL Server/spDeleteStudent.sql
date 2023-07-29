CREATE OR ALTER PROCEDURE spDeleteStudent(
    @StudentId UNIQUEIDENTIFIER
)
AS
    BEGIN TRANSACTION
        DELETE FROM
            [StudentCourse]
        WHERE
            [StudentId] = @StudentId

        DELETE FROM
            [Student]
        WHERE
            [Id] = @StudentId
    COMMIT

EXEC spDeleteStudent '348bbf90-bf15-4cd6-9cb2-4830cca7be61'
