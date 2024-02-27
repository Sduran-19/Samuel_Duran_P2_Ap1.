using Microsoft.EntityFrameworkCore;

namespace Samuel_duran_P2_Ap1.DAL
{
    public class Contexto : DbContext
    {
      
       public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    }
}
