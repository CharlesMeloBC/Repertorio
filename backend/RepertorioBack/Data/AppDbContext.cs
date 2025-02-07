using Microsoft.EntityFrameworkCore;
using RepertorioBack.Models;

namespace RepertorioBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { } 
    
        public DbSet<MusicaModel> LOUVORES { get; set; }
    }

}
