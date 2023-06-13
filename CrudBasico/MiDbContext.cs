using Microsoft.EntityFrameworkCore;


namespace CrudBasico
{
    public class MiDbContext: DbContext
    {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    
    }
}

