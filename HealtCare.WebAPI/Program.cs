using HealtCare.DAL.Data;
using HealtCare.DAL.GenericClass;
using HealtCare.WebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;



var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options => {
    options.AddPolicy(MyAllowSpecificOrigins, policy => {
        policy.WithOrigins("http://127.0.0.1:5500", "http://127.0.0.1:5501", "https://lively-flower-06e136603.3.azurestaticapps.net").AllowAnyHeader().AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddDbContext<RetiDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnStr")));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<Mapper>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



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
