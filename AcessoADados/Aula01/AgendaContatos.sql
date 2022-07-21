
/****** Object:  Table [dbo].[Pessoa]    Script Date: 16/07/2022 12:25:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[Nome] [varchar](150) NOT NULL,
	[DataNascimento] [datetime] NULL,
	[Id] [uniqueidentifier] NOT NULL,
	[PosicaoAgenda] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 16/07/2022 12:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Endereco](
	[Id] [uniqueidentifier] NOT NULL,
	[Distrito] [varchar](50) NULL,
	[Rua] [varchar](100) NULL,
	[CodigoPostal] [char](4) NULL,
	[CodigoPostalComplemento] [char](3) NULL,
	[NumeroPorta] [varchar](5) NULL,
	[PessoaId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contato]    Script Date: 16/07/2022 12:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contato](
	[Id] [uniqueidentifier] NOT NULL,
	[Tipo] [varchar](20) NULL,
	[Telefone] [char](9) NOT NULL,
	[PessoaId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_PessoasComTelefone]    Script Date: 16/07/2022 12:25:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_PessoasComTelefone]
as
	Select p.Nome, e.Distrito, c.Telefone
	from Pessoa as p
	left join endereco as e on e.pessoaId = p.Id
	left join contato as c on c.PessoaId = p.Id
	where c.telefone is not null
GO
INSERT [dbo].[contato] ([Id], [Tipo], [Telefone], [PessoaId]) VALUES (N'8c569674-15c6-4553-b057-16c410983ce5', N'Telemóvel', N'999999999', N'95c3cb49-cf00-4caf-b4e4-3705db35c002')
INSERT [dbo].[contato] ([Id], [Tipo], [Telefone], [PessoaId]) VALUES (N'01667e8e-c6ee-48eb-b6d2-3daa3e72bd23', N'Telemóvel', N'123456789', N'1366b9a3-d1ec-4057-b9e8-053ede8f71ab')
INSERT [dbo].[contato] ([Id], [Tipo], [Telefone], [PessoaId]) VALUES (N'd568cedf-0efb-47d7-89f0-bb46b164c921', N'Telemóvel', N'44444444 ', N'95c3cb49-cf00-4caf-b4e4-3705db35c002')
INSERT [dbo].[contato] ([Id], [Tipo], [Telefone], [PessoaId]) VALUES (N'ba90405c-7829-4eb9-898e-ea9891a5ea36', N'Telemóvel', N'555555555', N'95c3cb49-cf00-4caf-b4e4-3705db35c002')
GO
INSERT [dbo].[Endereco] ([Id], [Distrito], [Rua], [CodigoPostal], [CodigoPostalComplemento], [NumeroPorta], [PessoaId]) VALUES (N'e76534f5-1bed-493c-ba51-38a9e338a47b', N'Porto', NULL, NULL, NULL, NULL, N'85b5bf28-6685-4e7e-a627-8a7509d34e54')
INSERT [dbo].[Endereco] ([Id], [Distrito], [Rua], [CodigoPostal], [CodigoPostalComplemento], [NumeroPorta], [PessoaId]) VALUES (N'7295dba3-eeca-43e6-b26c-7b72cd82d6f6', N'Sintra', NULL, NULL, NULL, NULL, N'1366b9a3-d1ec-4057-b9e8-053ede8f71ab')
INSERT [dbo].[Endereco] ([Id], [Distrito], [Rua], [CodigoPostal], [CodigoPostalComplemento], [NumeroPorta], [PessoaId]) VALUES (N'7e36defd-b397-4042-96ef-d97b40fe17c1', N'Barreiro', NULL, NULL, NULL, NULL, N'95c3cb49-cf00-4caf-b4e4-3705db35c002')
GO
SET IDENTITY_INSERT [dbo].[Pessoa] ON 

INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Mario', CAST(N'1974-04-25T00:00:00.000' AS DateTime), N'1366b9a3-d1ec-4057-b9e8-053ede8f71ab', 1)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Jonatas', CAST(N'1984-05-29T00:00:00.000' AS DateTime), N'95c3cb49-cf00-4caf-b4e4-3705db35c002', 4)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Magda', NULL, N'c59af324-0507-4c42-8677-49b90307387f', 8)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Jonatas', CAST(N'1984-05-29T00:00:00.000' AS DateTime), N'd0eaa46f-708a-40c2-be66-4a1b59ab2e60', 18)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Jonatas', CAST(N'1984-05-29T00:00:00.000' AS DateTime), N'93019d42-8429-43c4-b1bb-6bd072977fd0', 16)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Jonatas', CAST(N'1984-05-29T00:00:00.000' AS DateTime), N'8f073e26-1396-4850-88ba-7db8e4830eb6', 17)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Teste', NULL, N'85b5bf28-6685-4e7e-a627-8a7509d34e54', 11)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Jonatas', CAST(N'1984-05-29T00:00:00.000' AS DateTime), N'55e9c27d-0469-45f5-afb3-a6bb35dcdd64', 15)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Rui', CAST(N'1993-12-17T00:00:00.000' AS DateTime), N'bea7b80e-7a29-4bd0-a28c-dc80c5593d29', 7)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Rúben', NULL, N'fb33f9c3-3eda-48b1-ae12-eb1cb7ffb7ee', 9)
INSERT [dbo].[Pessoa] ([Nome], [DataNascimento], [Id], [PosicaoAgenda]) VALUES (N'Marcelo', NULL, N'7012e2b4-a869-4555-a3d2-eba2fdb381f1', 14)
SET IDENTITY_INSERT [dbo].[Pessoa] OFF
GO
ALTER TABLE [dbo].[contato] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[contato] ADD  DEFAULT ('Telemóvel') FOR [Tipo]
GO
ALTER TABLE [dbo].[Endereco] ADD  CONSTRAINT [DF_Endereco_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Pessoa] ADD  CONSTRAINT [DF_Pessoa_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[contato]  WITH CHECK ADD FOREIGN KEY([PessoaId])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Pessoa] FOREIGN KEY([PessoaId])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Pessoa]
GO
