CREATE VIEW VW_PessoasComEmail
AS
SELECT p.Nome, c.EnderecoEletronico
FROM Pessoa AS p
LEFT JOIN Contato AS c ON c.PessoaId = p.Id