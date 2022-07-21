--Select * from endereco
--Select * from Pessoa where Nome = 'Jonatas'

--95C3CB49-CF00-4CAF-B4E4-3705DB35C002

--insert into endereco (Distrito, PessoaId) values ('Porto', '85B5BF28-6685-4E7E-A627-8A7509D34E54')

Select p.Nome, e.Distrito, e.Rua
from Pessoa as p, endereco as e
where p.Id = e.PessoaId --Join implícito

--join explícito
Select p.Nome, e.Distrito
from Pessoa as p
join Endereco as e on p.Id = e.PessoaId

--pessoas independente do endereco
Select p.Nome, e.Distrito
from Pessoa as p
left join Endereco as e on p.Id = e.PessoaId


--endereco independente das pessoas
Select p.Nome, e.Distrito
from Pessoa as p
right join Endereco as e on p.Id = e.PessoaId


--Só pessoas que moram no barreiro
Select p.Nome, e.Distrito
from Pessoa as p
left join Endereco as e on p.Id = e.PessoaId
where e.distrito = 'Barreiro'