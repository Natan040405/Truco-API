using Microsoft.EntityFrameworkCore;
using Truco_API.Models;

namespace Truco_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Jogador> Jogadores {  get; set; }
    }
}
