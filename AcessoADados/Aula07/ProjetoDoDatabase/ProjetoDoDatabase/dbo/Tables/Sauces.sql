CREATE TABLE [Sauces] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [IsVegan] bit NOT NULL,
    CONSTRAINT [PK_Sauces] PRIMARY KEY ([Id])
);