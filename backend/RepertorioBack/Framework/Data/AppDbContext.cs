using Microsoft.EntityFrameworkCore;
using RepertorioBack.Domain.Models;

namespace RepertorioBack.Framework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MusicaModel> LOUVORES { get; set; }
    }

}
