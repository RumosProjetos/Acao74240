
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    --The following statement was imported into the database project as a schema object and named dbo.__EFMigrationsHistory.
--CREATE TABLE [__EFMigrationsHistory] (
--        [MigrationId] nvarchar(150) NOT NULL,
--        [ProductVersion] nvarchar(32) NOT NULL,
--        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
--    );

END;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730091915_DatabaseInicial', N'6.0.7');
GO

COMMIT;
GO
