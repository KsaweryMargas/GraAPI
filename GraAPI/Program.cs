using GraAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GryDb>(options => options.UseSqlite("Data Source=gry.db"));
var app = builder.Build();

app.Run();
