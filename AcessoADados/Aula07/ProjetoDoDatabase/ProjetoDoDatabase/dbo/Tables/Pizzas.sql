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