using Microsoft.EntityFrameworkCore;
using PetroAtivos324173957.Models;

namespace PetroAtivos324173957.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ativo> Ativos { get; set; }
    }
}