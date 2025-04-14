using EmployeeAPI;
using EmployeeAPI.Models;
using EmployeeAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var emp = new List<EmployeeModel> 
{
    new EmployeeModel
    { 
        EmpID = 1, EmpName = "Kiran", EmpLocation = "Bengaluru" 
    }
};

// Add services to the container.
builder.Services.AddDbContext<EmployeeDbContext>(op => op.UseSqlServer
(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<List<EmployeeModel>>(emp);
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

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
