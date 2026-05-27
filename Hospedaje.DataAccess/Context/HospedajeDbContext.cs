using Hospedaje.DataAccess.Entities.Hospedaje;
using Microsoft.EntityFrameworkCore;

namespace Hospedaje.DataAccess.Context
{
    public class HospedajeDbContext : DbContext
    {
        public HospedajeDbContext(DbContextOptions<HospedajeDbContext> options) : base(options)
        {
        }

        public DbSet<EstadiaEntity> Estadias => Set<EstadiaEntity>();
        public DbSet<CargoEstadiaEntity> CargosEstadia => Set<CargoEstadiaEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HospedajeDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
