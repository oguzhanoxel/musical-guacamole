using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<CommandContext>
	(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CommandAPIConnectionString")));

var app = builder.Build();

app.MapControllers();

app.Run();
