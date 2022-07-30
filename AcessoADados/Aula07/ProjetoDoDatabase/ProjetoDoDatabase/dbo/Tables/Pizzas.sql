CREATE TABLE [Pizzas] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Price] decimal(18,2) NULL,
    [SauceId] int NULL,
    CONSTRAINT [PK_Pizzas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pizzas_Sauces_SauceId] FOREIGN KEY ([SauceId]) REFERENCES [Sauces] ([Id])
);
GO
CREATE INDEX [IX_Pizzas_SauceId] ON [Pizzas] ([SauceId]);
GO
ALTER TABLE [Pizzas] ADD CONSTRAINT [FK_Pizzas_Carriers_CarrierModeloDoCarro] FOREIGN KEY ([CarrierModeloDoCarro]) REFERENCES [Carriers] ([ModeloDoCarro]);
GO
ALTER TABLE [Pizzas] ADD CONSTRAINT [FK_Pizzas_Entregadores_CarrierModeloDoCarro] FOREIGN KEY ([CarrierModeloDoCarro]) REFERENCES [Entregadores] ([ModeloDoCarro]);
GO
CREATE INDEX [IX_Pizzas_CarrierModeloDoCarro] ON [Pizzas] ([CarrierModeloDoCarro]);