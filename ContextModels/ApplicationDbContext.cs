using Microsoft.EntityFrameworkCore;
using model1.Models;

namespace model1.ContextModels
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Carte> Carte { get; set; }
        public DbSet<Autor> Autor { get; set; }
    }
}
