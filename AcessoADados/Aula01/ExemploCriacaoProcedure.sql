USE [AgendaDB]
GO
/****** Object:  StoredProcedure [dbo].[usp_InserirPessoaComTelefone]    Script Date: 16/07/2022 12:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jonatas Neto
-- Create date: 2022/07/16
-- Description:	Guardar os dados das pessoas com telefone
-- =============================================
ALTER PROCEDURE [dbo].[usp_InserirPessoaComTelefone]
	@nome VARCHAR(150),
	@telefone CHAR(9) 
AS
BEGIN
	BEGIN TRAN
		DECLARE @idDaPessoa UNIQUEIDENTIFIER = NEWID()
		INSERT INTO Pessoa (id, nome) VALUES (@idDaPessoa, @nome)
		INSERT INTO Contato (PessoaId, Telefone) VALUES (@idDaPessoa, @telefone)		
	COMMIT TRAN
END
