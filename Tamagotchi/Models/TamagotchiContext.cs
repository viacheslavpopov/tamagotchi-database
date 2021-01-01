using Microsoft.EntityFrameworkCore;
using Tamagotchi.Models;

namespace Tamagotchi.Models
{
    public class TamagotchiContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

        public TamagotchiContext(DbContextOptions options) : base(options) { }

    }
}