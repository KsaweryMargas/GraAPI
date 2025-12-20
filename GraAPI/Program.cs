using Microsoft.EntityFrameworkCore;
using GraAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GryDb>(options => options.UseSqlite("Data Source=gry.db"));
var app = builder.Build();

    app.MapGet("/api/tags",(GryDb db) =>
    {
        return db.WszystkieGry.Select(gra => gra.Tag).Distinct();
    });

    app.MapGet("/api/games",(string? tag, GryDb db) =>
    {
        if (tag == null)
        {
            return db.WszystkieGry;
        }
            return db.WszystkieGry.Where(gra => gra.Tag == tag);
    });
app.Run();