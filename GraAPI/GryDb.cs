using Microsoft.EntityFrameworkCore;

namespace GraAPI;

public class GryDb : DbContext
{
    public GryDb(DbContextOptions<GryDb> options) : base(options)
    {

    }

    public DbSet<Gry> WszystkieGry { get; set; } = null!;
}