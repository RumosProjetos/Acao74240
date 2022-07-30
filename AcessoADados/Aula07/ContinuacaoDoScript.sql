BEGIN TRANSACTION;
GO

ALTER TABLE [Pizzas] ADD [CarrierModeloDoCarro] uniqueidentifier NULL;
GO

CREATE TABLE [Carriers] (
    [ModeloDoCarro] uniqueidentifier NOT NULL,
    [NomeEntregador] nvarchar(150) NOT NULL,
    [DataContratacao] datetime2 NULL,
    [DiaDeFolga] int NOT NULL,
    CONSTRAINT [PK_Carriers] PRIMARY KEY ([ModeloDoCarro])
);
GO

CREATE INDEX [IX_Pizzas_CarrierModeloDoCarro] ON [Pizzas] ([CarrierModeloDoCarro]);
GO

ALTER TABLE [Pizzas] ADD CONSTRAINT [FK_Pizzas_Carriers_CarrierModeloDoCarro] FOREIGN KEY ([CarrierModeloDoCarro]) REFERENCES [Carriers] ([ModeloDoCarro]);
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

ALTER TABLE [Entregadores] ADD CONSTRAINT [PK_Entregadores] PRIMARY KEY ([ModeloDoCarro]);
GO

ALTER TABLE [Pizzas] ADD CONSTRAINT [FK_Pizzas_Entregadores_CarrierModeloDoCarro] FOREIGN KEY ([CarrierModeloDoCarro]) REFERENCES [Entregadores] ([ModeloDoCarro]);
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

