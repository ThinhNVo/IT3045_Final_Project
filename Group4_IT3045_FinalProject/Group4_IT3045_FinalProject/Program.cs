using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Group4_IT3045_FinalProject.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Group4_IT3045_FinalProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Group4_IT3045_FinalProjectContext") ?? throw new InvalidOperationException("Connection string 'Group4_IT3045_FinalProjectContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
