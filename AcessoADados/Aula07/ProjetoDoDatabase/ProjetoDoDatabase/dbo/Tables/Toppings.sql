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
CREATE INDEX [IX_Toppings_PizzaId] ON [Toppings] ([PizzaId]);