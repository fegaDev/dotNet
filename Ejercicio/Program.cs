//1. EntityFramework
using Ejercicio.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//2. Create Connexion 

const string ConnectionName = "CursoDB";
var ConnectionString = builder.Configuration.GetConnectionString(ConnectionName);

//3. Add Context 
builder.Services.AddDbContext<CursoDbContext>(options => options.UseSqlServer(ConnectionString));



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
