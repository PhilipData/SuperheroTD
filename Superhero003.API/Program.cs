using Microsoft.EntityFrameworkCore;
using Superhero003.Repository.Database;
using Superhero003.Repository.Entities;
using Superhero003.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DatabaseContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

// our DI 
// Addscoped is used to the individuel user
builder.Services.AddScoped<IHeroRepository, HeroRepository>();
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
//builder.Services.AddTransient
//builder.Services.AddSingleton
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




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
