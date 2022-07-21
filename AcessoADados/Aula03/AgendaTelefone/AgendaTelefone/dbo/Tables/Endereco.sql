CREATE TABLE [dbo].[Endereco] (
    [Id]                      UNIQUEIDENTIFIER CONSTRAINT [DF_Endereco_Id] DEFAULT (newid()) NOT NULL,
    [Distrito]                VARCHAR (50)     NULL,
    [Rua]                     VARCHAR (100)    NULL,
    [CodigoPostal]            CHAR (4)         NULL,
    [CodigoPostalComplemento] CHAR (3)         NULL,
    [NumeroPorta]             VARCHAR (5)      NULL,
    [PessoaId]                UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Endereco_Pessoa] FOREIGN KEY ([PessoaId]) REFERENCES [dbo].[Pessoa] ([Id])
);

