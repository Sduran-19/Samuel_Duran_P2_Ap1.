using Microsoft.EntityFrameworkCore;
using Samuel_Duran_P2_Ap1.Models;

namespace Samuel_duran_P2_Ap1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vehiculo>? Vehiculo { get; set; }

        public DbSet<Accesorios>? Accesorios { get; set; }
        public DbSet<VehiculoDetalle>? VehiculoDetalle { get; set; }


        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    }
}
