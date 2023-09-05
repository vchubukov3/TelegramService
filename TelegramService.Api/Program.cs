using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TelegramService.Api.Middleware;
using TelegramService.Domain.Interfaces.Repositories;
using TelegramService.Infrastructure.Data;
using TelegramService.Infrastructure.Repositories;
using TelegramService.Shared.Interfaces.Repositories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TelegramService.Infrastructure.Data.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = builder.Configuration;
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

// builder.Services.AddDefaultIdentity<IdentityUser>()
//     .AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationContext>()
    .AddDefaultTokenProviders();



builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProxyRepository, ProxyRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<LoggingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthentication(); 
app.UseAuthorization();
app.MapControllers();

app.MapGet("/", (ApplicationContext db) => db.Users.ToList());

app.Run();