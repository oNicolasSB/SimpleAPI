using CoffeeShoper.API.DependencyInjection;
using CoffeeShoper.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices(builder.Configuration);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

app.InitializeData();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
