using Microsoft.EntityFrameworkCore;
namespace WebApplication64

{
    public class EFcontext : DbContext
    {
        public EFcontext(DbContextOptions<EFcontext> options) : base(options) { }
        public DbSet<company> companies{get; set;}
        public DbSet<employee> employees { get; set; }

    }
}
