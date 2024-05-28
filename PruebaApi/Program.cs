using Microsoft.EntityFrameworkCore;
using PruebaApi.Aplicattion.Cars;
using PruebaApi.Aplicattion.Contracts.Cars;
using PruebaApi.DataAccess.Context;
using PruebaApi.Domain.Services.Cars;
using PruebaApi.Domain.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddDbContext<CarContext>(options => options.UseSqlServer("ConnectionStrings:ConnectionStringDb"));

builder.Services.AddControllers();
builder.Services.AddTransient<ICarsAppService, CarAppService>();
builder.Services.AddTransient<ICarDomainService, CarDomainService>();


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
