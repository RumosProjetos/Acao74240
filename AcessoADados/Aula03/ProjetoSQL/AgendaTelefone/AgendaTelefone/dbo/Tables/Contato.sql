CREATE TABLE [dbo].[Contato] (
    [Id]                 UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [Tipo]               VARCHAR (20)     DEFAULT ('Telemóvel') NULL,
    [Telefone]           CHAR (9)         NOT NULL,
    [PessoaId]           UNIQUEIDENTIFIER NOT NULL,
    [EnderecoEletronico] VARCHAR (100)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([PessoaId]) REFERENCES [dbo].[Pessoa] ([Id])
);



