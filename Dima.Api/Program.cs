using Dima.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection")?? string.Empty;

builder.Services.AddDbContext<AppDbContext>(
  x=>
   {
     x.UseSqlServer(cnnStr);
  });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
