using ContosoPizza.Data;
using ContosoPizza.Services;
using Microsoft.EntityFrameworkCore;
// Additional using declarations

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add the PizzaContext
builder.Services.AddSqlite<PizzaContext>("Data Source=ContosoPizza.db"); // Exemplo criado do zero
//builder.Services.AddSqlite<PizzaContext>("Data Source=ContosoPizzaProducao.db"); //Exemplo seed
//builder.Services.AddDbContext<PizzaContext>(options => options.UseInMemoryDatabase("Pizzaria"));
builder.Services.AddSqlite<PromotionsContext>("Data Source=./Promotions/Promotions.db");
// Add the PromotionsContext

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
