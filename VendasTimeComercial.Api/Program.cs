using Microsoft.EntityFrameworkCore;
using VendasTimeComercial.Application.Services;
using VendasTimeComercial.Domain.Repositories;
using VendasTimeComercial.Infrastructure.Data;
using VendasTimeComercial.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("VendasTimeComercialConnection");

builder.Services.AddDbContext<VendasTimeComercialContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<IVendaRepository, VendaRepository>();

// Service da Application
builder.Services.AddScoped<VendaService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
