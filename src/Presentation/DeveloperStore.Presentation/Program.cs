using DeveloperStore.Domain.Core.Interfaces.Repositorys;
using OpenApi.Models;
using DeveloperStore.Infrastructure.Data;
using DeveloperStore.Infrastructure.Repository.Repositorys;
using System.Data.SQLite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Swagger configuration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo 
    {
        Title = "DeveloperStore API",
        Version = "v1",
        Description = "API for managing sales records using DDD and Entity Framework"
    });
});

// EF Core: Configure DB Context (using InMemory for simplicity — switch to SQLServer if needed)
builder.Services.AddDbContext<SqlContext>(options =>
    options.UseSqlite("developer_store.sqlite")); // Replace with .UseSqlServer(...) if using SQL Server

// Dependency Injection: Register Repositories
builder.Services.AddScoped<IRepositorySale, RepositorySale>();
builder.Services.AddScoped<IRepositorySaleItem, RepositorySaleItem>();
builder.Services.AddScoped<IRepositoryCustomer, RepositoryCustomer>();

var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "DeveloperStore API V1");
        c.RoutePrefix = string.Empty; // Swagger UI on root
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

SeedInitialData(app.Services); // optional

app.Run();

// Optional: Seeding example
void SeedInitialData(IServiceProvider services)
{
    using var scope = services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<SqlContext>();

    // You can add initial seed data here if required for testing
    context.SaveChanges();
}

