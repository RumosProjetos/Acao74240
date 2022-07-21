CREATE TABLE [dbo].[Pessoa] (
    [Nome]           VARCHAR (150)    NOT NULL,
    [DataNascimento] DATETIME         NULL,
    [Id]             UNIQUEIDENTIFIER CONSTRAINT [DF_Pessoa_Id] DEFAULT (newid()) NOT NULL,
    [PosicaoAgenda]  INT              IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED ([Id] ASC)
);

