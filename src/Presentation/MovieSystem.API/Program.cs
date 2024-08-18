using Microsoft.EntityFrameworkCore;
using MovieSystem.Application.Extensions;
using MovieSystem.Persistence;
using MovieSystem.Persistence.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddScoped<IRepository<User>, UserRepository>();
//builder.Services.AddScoped<IService<User>, UserService>();
builder.Services.AddDbContext<MovieSystemContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

Serviceconfiguration.RegisteredServices(builder.Services);
RepositoryConfiguration.RegisterRepositories(builder.Services);

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

app.Run();
