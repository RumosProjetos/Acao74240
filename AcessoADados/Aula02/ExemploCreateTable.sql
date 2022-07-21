--SQL
  --DML -- Data Manipulation Language (Delete, Insert, Select, Update, ...) 
  --DDL -- Data Definition Language (Create Table, Drop Table, Alter Table, ...)
  --DCL -- Data Control Language (Grant Access, Deny Access, ...)


--Create Table contato(
--	Id uniqueIdentifier not null primary key default newid(),
--	Tipo varchar(20) null default 'Telemóvel',
--	Telefone char(9) not null,
--	PessoaId uniqueIdentifier not null foreign key (PessoaId) References Pessoa (Id)
--)


--Select top 10 * from Pessoa where Nome = 'Jonatas'
--95C3CB49-CF00-4CAF-B4E4-3705DB35C002
--insert into contato (telefone, pessoaId) values ('44444444', '95C3CB49-CF00-4CAF-B4E4-3705DB35C002')


Select p.Nome, e.Distrito, c.Telefone
from Pessoa as p
left join endereco as e on e.pessoaId = p.Id
left join contato as c on c.PessoaId = p.Id
where c.telefone is null



select p.Nome, COUNT(c.Id)
from pessoa as p
left join contato c on c.PessoaId = p.Id
--where p.nome = 'Jonatas'
group by p.Nome

