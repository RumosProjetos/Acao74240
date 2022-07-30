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

//Adicionar SQLSErver
var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;";


var connectionStringProd = @"Server=tcp:sqldb-rumos-acao74240.database.windows.net,1433;Initial Catalog=sqldb-formacao-learn-uks-001;Persist Security Info=False;User ID=rumos;Password=abc,1234";
builder.Services.AddDbContext<PizzaContext>(x => x.UseSqlServer(connectionStringProd));

//optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");


//builder.Services.AddSqlite<PromotionsContext>("Data Source=./Promotions/Promotions.db");


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
