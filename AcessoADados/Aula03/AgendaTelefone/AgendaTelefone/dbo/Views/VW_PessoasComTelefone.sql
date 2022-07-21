CREATE VIEW [dbo].[VW_PessoasComTelefone]
AS
	SELECT p.Nome, e.Distrito, c.Telefone, c.EnderecoEletronico
	FROM Pessoa AS p
	LEFT JOIN Endereco AS e ON e.PessoaId = p.Id
	LEFT JOIN Contato AS c ON c.PessoaId = p.Id
	WHERE c.Telefone IS NOT NULL
