using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAcssesLayer
{
    public class AppDbcontext :DbContext
    {

        public DbSet<CodeingKoll> CodeingKoll { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Server=.;Database=ExportInport_v2;Integrated Security=True;TrustServerCertificate=True;");


        }
    }
}
