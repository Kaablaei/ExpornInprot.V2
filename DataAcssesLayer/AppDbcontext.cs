using DataAcssesLayer.Repositoryes.InterFases;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAcssesLayer
{
    public class AppDbcontext :DbContext
    {

        public DbSet<CodeingKoll> CodeingKoll { get; set; }
        public DbSet<CodingGrohTafsili> CodingGrohTafsili { get; set; }
        public DbSet<CodingMoin> CodingMoind { get; set; }
        public DbSet<CodingTafsili> CodingTafsili { get; set; }
        public DbSet<Kala> Kalas { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<TarkhisKar> TarkhisKars { get; set; }
        public DbSet<sardkhane> sardkhane { get; set; }
        public DbSet<Farmers> farmers { get; set; }
        public DbSet<Border> Border { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<City> City { get; set; }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExportInport_v2;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
