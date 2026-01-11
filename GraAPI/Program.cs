using Microsoft.EntityFrameworkCore;
using GraAPI;

var builder = WebApplication.CreateBuilder(args);
// Konfiguracja bazy danych SQLite
builder.Services.AddDbContext<GryDb>(options => options.UseSqlite("Data Source=gry.db"));
var app = builder.Build();

    // Pobieranie tagów z bazy gier
    app.MapGet("/api/tags",(GryDb db) =>
    {
        return db.WszystkieGry.Select(gra => gra.Tag).Distinct();
    });

    // Pobieranie gier filtrowanych tagiem
    app.MapGet("/api/games",(string? tag, GryDb db) =>
    {
        if (tag == null)
        {
            return db.WszystkieGry;
        }
            return db.WszystkieGry.Where(gra => gra.Tag == tag);
    });

app.Run();