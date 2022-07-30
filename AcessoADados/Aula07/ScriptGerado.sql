IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Sauces] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [IsVegan] bit NOT NULL,
    CONSTRAINT [PK_Sauces] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pizzas] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Price] decimal(18,2) NULL,
    [SauceId] int NULL,
    CONSTRAINT [PK_Pizzas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pizzas_Sauces_SauceId] FOREIGN KEY ([SauceId]) REFERENCES [Sauces] ([Id])
);
GO

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

CREATE TABLE [Toppings] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(100) NOT NULL,
    [Calories] int NOT NULL,
    [IsVegan] bit NOT NULL,
    [PizzaId] int NULL,
    CONSTRAINT [PK_Toppings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Toppings_Pizzas_PizzaId] FOREIGN KEY ([PizzaId]) REFERENCES [Pizzas] ([Id])
);
GO

CREATE INDEX [IX_Customers_FavoritePizzaId] ON [Customers] ([FavoritePizzaId]);
GO

CREATE INDEX [IX_Pizzas_SauceId] ON [Pizzas] ([SauceId]);
GO

CREATE INDEX [IX_Toppings_PizzaId] ON [Toppings] ([PizzaId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220730091915_DatabaseInicial', N'6.0.7');
GO

COMMIT;
GO

