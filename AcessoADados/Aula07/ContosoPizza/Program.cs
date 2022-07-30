using ContosoPizza.Data;
using ContosoPizza.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Antes era SQLLite
//builder.Services.AddSqlite<PizzaContext>("Data Source=ContosoPizza.db"); 

//SQLSERVER Local ou na pasta da rede
//N�o deixar string martelada, foi s� para exemplo
//Utilizar AppSettings
var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;";

//String v�lida at� dezembro de 2022
//N�o deixar string martelada, foi s� para exemplo
//Utilizar AppSettings
var connectionStringProd = @"Server=tcp:sqldb-rumos-acao74240.database.windows.net,1433;Initial Catalog=sqldb-formacao-learn-uks-001;Persist Security Info=False;User ID=rumos;Password=abc,1234";

//Caso quisesse martelado: usar direto
//builder.Services.AddDbContext<PizzaContext>(x => x.UseSqlServer(connectionStringProd));

//Como queremos buscar do AppSettings Vamos usar o - Configuration.GetConnectionString("NomeDaConexao")
var conexao = builder.Configuration.GetConnectionString("PizzariaAzure");
builder.Services.AddDbContext<PizzaContext>(x => x.UseSqlServer(conexao));


//ConfigurationManager.ConnectionString - Para as vers�es anteriores ao CORE





//optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");


builder.Services.AddSqlite<PromotionsContext>("Data Source=./Promotions/Promotions.db");


builder.Services.AddScoped<PizzaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Add the CreateDbIfNotExists method call
app.CreateDbIfNotExists();


app.Run();
