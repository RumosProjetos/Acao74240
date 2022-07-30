CREATE TABLE [Customers] (
    [CustomerId] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    [CreditCard] nvarchar(max) NULL,
    [FavoritePizzaId] int NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId]),
    CONSTRAINT [FK_Customers_Pizzas_FavoritePizzaId] FOREIGN KEY ([FavoritePizzaId]) REFERENCES [Pizzas] ([Id])
);
GO
CREATE INDEX [IX_Customers_FavoritePizzaId] ON [Customers] ([FavoritePizzaId]);