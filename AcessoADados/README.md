## Aula 01
- Explorando o SQLServer

## Aula 02
- Introdução às bases de dados (DP900): https://docs.microsoft.com/pt-br/certifications/exams/dp-900

## Aula 03
- SQLPROJ
- Acesso a dados com ADO.NET - Framework 4.X
- Dapper: https://dapper-plus.net/overview

## Aula 04
- Database First
- Partial Classes
- Entity Framework Core

## Aula 05
- Model
- Code First : https://docs.microsoft.com/en-us/learn/modules/build-web-api-minimal-database/

## Aula 06
- Model
- Migrations: https://docs.microsoft.com/en-us/learn/modules/persist-data-ef-core/ 
- Validação de Modelos : https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0
- Data Annotation: https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-6.0

## Aula 07
- Migrando para o SQLServer
- dotnet ef add migrations DatabaseInicial --context PizzaContext 
- dotnet ef database update --context PizzaContext
- Script-Migration --context PizzaContext --from MigracaoDoDia07 --to MigracaoDoDia10
- builder.Services.AddDbContext(x => x.UseSqlServer(builder.Configuration.GetConnectionString("PizzariaAzure")));
