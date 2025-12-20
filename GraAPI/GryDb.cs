using Microsoft.EntityFrameworkCore;

namespace GraAPI;

public class GryDb : DbContext
{
    public GryDb(DbContextOptions<GryDb> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gry>().HasData(
            new Gry { Id = 1, Tytul = "Wiedźmin 3", Tag = "RPG" },
            new Gry { Id = 2, Tytul = "FIFA 23", Tag = "Sportowe" },
            new Gry { Id = 3, Tytul = "Cyberpunk 2077", Tag = "RPG" },
            new Gry { Id = 4, Tytul = "League of Legends", Tag = "MOBA" },
            new Gry { Id = 5, Tytul = "Dota 2", Tag = "MOBA" },
            new Gry { Id = 6, Tytul = "Counter-Strike 2", Tag = "FPS" },
            new Gry { Id = 7, Tytul = "Valorant", Tag = "FPS" },
            new Gry { Id = 8, Tytul = "Minecraft", Tag = "Survival" },
            new Gry { Id = 9, Tytul = "Forza Horizon 5", Tag = "Wyścigowe" },
            new Gry { Id = 10, Tytul = "Elden Ring", Tag = "RPG" },
            new Gry { Id = 11, Tytul = "StarCraft II", Tag = "Strategiczne" },
            new Gry { Id = 12, Tytul = "Age of Empires IV", Tag = "Strategiczne" },
            new Gry { Id = 13, Tytul = "Hades", Tag = "Roguelike" },
            new Gry { Id = 14, Tytul = "Dead Cells", Tag = "Roguelike" },
            new Gry { Id = 15, Tytul = "Call of Duty", Tag = "FPS" },
            new Gry { Id = 16, Tytul = "The Sims 4", Tag = "Symulator" },
            new Gry { Id = 17, Tytul = "F1 24", Tag = "Sportowe" },
            new Gry { Id = 18, Tytul = "Diablo IV", Tag = "RPG" },
            new Gry { Id = 19, Tytul = "Terraria", Tag = "Survival" },
            new Gry { Id = 20, Tytul = "Apex Legends", Tag = "FPS" }
        );
    }

    public DbSet<Gry> WszystkieGry { get; set; } = null!;
}