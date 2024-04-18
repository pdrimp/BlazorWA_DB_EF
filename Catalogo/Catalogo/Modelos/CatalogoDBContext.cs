using Microsoft.EntityFrameworkCore;

namespace Catalogo.Modelos
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get; set; }
    }
}
