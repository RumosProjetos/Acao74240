CREATE TABLE [Categorias] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Lojas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Endereco] nvarchar(max) NULL,
    [Ativa] bit NULL,
    [DataModificacao] datetime2 NULL,
    [DataCriacao] datetime2 NULL,
    CONSTRAINT [PK_Lojas] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Pessoas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(60) NOT NULL,
    [DataCriacao] datetime2 NULL,
    [Morada] nvarchar(120) NULL,
    [Cidade] nvarchar(50) NULL,
    [EnderecoEletronico] nvarchar(150) NULL,
    [NumeroIdentificacaoFiscal] nvarchar(9) NOT NULL,
    [Discriminator] nvarchar(max) NOT NULL,
    [ClienteId] uniqueidentifier NULL,
    [UtilizadorId] uniqueidentifier NULL,
    [Login] nvarchar(max) NULL,
    [Senha] nvarchar(max) NULL,
    [Telefone] nvarchar(9) NULL,
    CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [TiposDePagamentos] (
    [Id] uniqueidentifier NOT NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_TiposDePagamentos] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Produtos] (
    [Id] uniqueidentifier NOT NULL,
    [CodigoBarras] nvarchar(max) NULL,
    [Nome] nvarchar(max) NULL,
    [UnidadeMedida] nvarchar(max) NULL,
    [Marca] nvarchar(max) NULL,
    [QuantidadePorUnidade] decimal(18,2) NOT NULL,
    [PrecoUnitario] decimal(18,2) NOT NULL,
    [Descontinuado] bit NULL,
    [DataCriacao] datetime2 NULL,
    [DataModificacao] datetime2 NULL,
    [CategoriaId] uniqueidentifier NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Produtos_Categorias_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categorias] ([Id])
);
GO


CREATE TABLE [PontosDeVendas] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Localizacao] nvarchar(max) NULL,
    [LojaId] uniqueidentifier NULL,
    CONSTRAINT [PK_PontosDeVendas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PontosDeVendas_Lojas_LojaId] FOREIGN KEY ([LojaId]) REFERENCES [Lojas] ([Id])
);
GO


CREATE TABLE [Pagamentos] (
    [Id] uniqueidentifier NOT NULL,
    [NumeroSequencialNota] nvarchar(max) NULL,
    [ValorTotalPago] decimal(18,2) NOT NULL,
    [DataCriacao] datetime2 NULL,
    [LojaId] uniqueidentifier NULL,
    [TipoPagamentoId] uniqueidentifier NULL,
    CONSTRAINT [PK_Pagamentos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pagamentos_Lojas_LojaId] FOREIGN KEY ([LojaId]) REFERENCES [Lojas] ([Id]),
    CONSTRAINT [FK_Pagamentos_TiposDePagamentos_TipoPagamentoId] FOREIGN KEY ([TipoPagamentoId]) REFERENCES [TiposDePagamentos] ([Id])
);
GO


CREATE TABLE [Estoques] (
    [Id] uniqueidentifier NOT NULL,
    [Quantidade] int NOT NULL,
    [QuantidadeMinima] int NOT NULL,
    [DataModificacao] datetime2 NULL,
    [DataCriacao] datetime2 NULL,
    [ProdutoId] uniqueidentifier NULL,
    [LojaId] uniqueidentifier NULL,
    CONSTRAINT [PK_Estoques] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Estoques_Lojas_LojaId] FOREIGN KEY ([LojaId]) REFERENCES [Lojas] ([Id]),
    CONSTRAINT [FK_Estoques_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([Id])
);
GO


CREATE TABLE [Vendas] (
    [Id] uniqueidentifier NOT NULL,
    [DataModificacao] datetime2 NULL,
    [DataCriacao] datetime2 NULL,
    [Pago] bit NULL,
    [LojaId] uniqueidentifier NULL,
    [PagamentoId] uniqueidentifier NULL,
    [PontoDeVendaId] uniqueidentifier NULL,
    [UtilizadorId] uniqueidentifier NULL,
    [ClienteId] uniqueidentifier NULL,
    CONSTRAINT [PK_Vendas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Vendas_Lojas_LojaId] FOREIGN KEY ([LojaId]) REFERENCES [Lojas] ([Id]),
    CONSTRAINT [FK_Vendas_Pagamentos_PagamentoId] FOREIGN KEY ([PagamentoId]) REFERENCES [Pagamentos] ([Id]),
    CONSTRAINT [FK_Vendas_Pessoas_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Pessoas] ([Id]),
    CONSTRAINT [FK_Vendas_Pessoas_UtilizadorId] FOREIGN KEY ([UtilizadorId]) REFERENCES [Pessoas] ([Id]),
    CONSTRAINT [FK_Vendas_PontosDeVendas_PontoDeVendaId] FOREIGN KEY ([PontoDeVendaId]) REFERENCES [PontosDeVendas] ([Id])
);
GO


CREATE TABLE [DetalhesDasVendas] (
    [Id] uniqueidentifier NOT NULL,
    [Sequencial] int NOT NULL,
    [ProdutoId] uniqueidentifier NULL,
    [Quantidade] int NOT NULL,
    [PrecoUnitario] int NOT NULL,
    [TotalPorItem] decimal(18,2) NOT NULL,
    [DataCriacao] datetime2 NULL,
    [VendaId] uniqueidentifier NULL,
    CONSTRAINT [PK_DetalhesDasVendas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DetalhesDasVendas_Produtos_ProdutoId] FOREIGN KEY ([ProdutoId]) REFERENCES [Produtos] ([Id]),
    CONSTRAINT [FK_DetalhesDasVendas_Vendas_VendaId] FOREIGN KEY ([VendaId]) REFERENCES [Vendas] ([Id])
);
GO


CREATE INDEX [IX_DetalhesDasVendas_ProdutoId] ON [DetalhesDasVendas] ([ProdutoId]);
GO


CREATE INDEX [IX_DetalhesDasVendas_VendaId] ON [DetalhesDasVendas] ([VendaId]);
GO


CREATE INDEX [IX_Estoques_LojaId] ON [Estoques] ([LojaId]);
GO


CREATE INDEX [IX_Estoques_ProdutoId] ON [Estoques] ([ProdutoId]);
GO


CREATE INDEX [IX_Pagamentos_LojaId] ON [Pagamentos] ([LojaId]);
GO


CREATE INDEX [IX_Pagamentos_TipoPagamentoId] ON [Pagamentos] ([TipoPagamentoId]);
GO


CREATE INDEX [IX_PontosDeVendas_LojaId] ON [PontosDeVendas] ([LojaId]);
GO


CREATE INDEX [IX_Produtos_CategoriaId] ON [Produtos] ([CategoriaId]);
GO


CREATE INDEX [IX_Vendas_ClienteId] ON [Vendas] ([ClienteId]);
GO


CREATE INDEX [IX_Vendas_LojaId] ON [Vendas] ([LojaId]);
GO


CREATE INDEX [IX_Vendas_PagamentoId] ON [Vendas] ([PagamentoId]);
GO


CREATE INDEX [IX_Vendas_PontoDeVendaId] ON [Vendas] ([PontoDeVendaId]);
GO


CREATE INDEX [IX_Vendas_UtilizadorId] ON [Vendas] ([UtilizadorId]);
GO


