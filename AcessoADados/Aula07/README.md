## Trocar de Banco de Dados

0 - Enquanto desenvolvedores, vamos começar no LocalDB
1 - Recuperar a String de Conexão para o SQL SERver
2 - Instalar as bibliotecas / providers na nossa solução para o SQLServer
3 - Remover as Migrations específicas para o SQLLite
	dotnet ef database update 0
	dotnet ef migrations remove
	
4 - Mudar o Middleware para conhecer o SQL SERVER
	var connectionString = "(LocalDB)\\MSSQLLocalDB;Initial Catalog=Pizzaria;Integrated Security=True;";
	builder.Services.AddDbContext<PizzaContext>(x => x.UseSqlServer(connectionString));

5 - Quando for para produção

6 - Gerar as Migrations para o SQLServer
	dotnet ef add migrations DatabaseInicial --context PizzaContext
	dotnet ef database update --context PizzaContext
	
7 - Exportar as Migrations para o SQLServer de Produção
	Script-Migration --context PizzaContext	     //PrimeiraPassagem	
	Script-Migration --context PizzaContext --from MigracaoDoDia07 --to MigracaoDoDia10 //Atualizações


8 - Exemplo conexão de produção
	Server=tcp:sqldb-rumos-acao74240.database.windows.net,1433;Initial Catalog=sqldb-formacao-learn-uks-001;Persist Security Info=False;User ID=rumos;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;	