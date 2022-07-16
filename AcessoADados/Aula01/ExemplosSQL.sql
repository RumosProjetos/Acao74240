--Select
--Insert
--Delete
--Update

Select p.Nome, p.PosicaoAgenda  --3
from Pessoa as p ---1
where p.Nome = 'Jonatas'  --2
order by p.PosicaoAgenda --4



--insert into Pessoa (nome) values ('Jonatas')

--insert into Pessoa (nome, DataNascimento) values ('Jonatas', '1984/05/29')
--Select * from Pessoa where Nome = 'Jonatas'

update Pessoa set DataNascimento = '1984/05/29' where Nome = 'Jonatas'

begin tran
delete from Pessoa where (Id <> '95C3CB49-CF00-4CAF-B4E4-3705DB35C002' and Nome = 'Jonatas')
commit
select * from Pessoa where (Id <> '95C3CB49-CF00-4CAF-B4E4-3705DB35C002' and Nome = 'Jonatas')


select distinct(p.Nome) as nomedocolaborador
from Pessoa as p
order by p.Nome



select  p.nome, LEN(p.Nome) as nomedocolaborador
from Pessoa as p
order by p.Nome  


declare @meuParametro varchar(50)
set @meuParametro = 'Jonatas'
Select * from Pessoa where Nome = @meuParametro

