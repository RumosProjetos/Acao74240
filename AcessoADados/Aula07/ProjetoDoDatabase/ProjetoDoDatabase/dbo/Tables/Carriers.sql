CREATE TABLE [Carriers] (
    [ModeloDoCarro] uniqueidentifier NOT NULL,
    [NomeEntregador] nvarchar(150) NOT NULL,
    [DataContratacao] datetime2 NULL,
    [DiaDeFolga] int NOT NULL,
    CONSTRAINT [PK_Carriers] PRIMARY KEY ([ModeloDoCarro])
);