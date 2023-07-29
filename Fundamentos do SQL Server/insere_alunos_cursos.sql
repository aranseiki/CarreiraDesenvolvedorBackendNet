SELECT * FROM [Course]
SELECT * FROM [Student]
SELECT * FROM [StudentCourse]

INSERT INTO
    [Student]
VALUES (
    '348bbf90-bf15-4cd6-9cb2-4830cca7be61',
    'André Baltieri',
    'hello@balta.io',
    '12345678901',
    '12345678',
    NULL,
    GETDATE()
)

INSERT INTO
    [StudentCourse]
VALUES (
    '5f5a33f8-4ff3-7e10-cc6e-3fa000000000',
    '348bbf90-bf15-4cd6-9cb2-4830cca7be61',
    50,
    0,
    '2020-01-13 12:35:54',
    GETDATE()
)

SELECT NEWID()