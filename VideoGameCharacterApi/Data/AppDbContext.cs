using Microsoft.EntityFrameworkCore;
using VideoGameCharacterApi.Models;
namespace VideoGameCharacterApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext
    {
        DbSet<Character> Characters => Set<Character>();


    }
}
