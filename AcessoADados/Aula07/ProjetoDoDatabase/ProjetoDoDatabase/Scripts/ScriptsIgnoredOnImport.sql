﻿
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

BEGIN TRANSACTION;
GO

ALTER TABLE [Pizzas] ADD [CarrierModeloDoCarro] uniqueidentifier NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730110605_ServicoEntrega', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Pizzas] DROP CONSTRAINT [FK_Pizzas_Carriers_CarrierModeloDoCarro];
GO

ALTER TABLE [Carriers] DROP CONSTRAINT [PK_Carriers];
GO

EXEC sp_rename N'[Carriers]', N'Entregadores';
GO

EXEC sp_rename N'[Entregadores].[DiaDeFolga]', N'FolgaDoEntregador', N'COLUMN';
GO

EXEC sp_rename N'[Entregadores].[DataContratacao]', N'Data De Assinatura De Contrato', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730111246_ServicoEntregaCorrigido', N'6.0.7');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Entregadores].[Data De Assinatura De Contrato]', N'DataDeAssinaturaDeContrato', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730111515_ServicoEntregaCorrigidoNovamente', N'6.0.7');
GO

COMMIT;
GO
