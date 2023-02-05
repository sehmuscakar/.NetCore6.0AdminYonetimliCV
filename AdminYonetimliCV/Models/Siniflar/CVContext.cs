using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AdminYonetimliCV.Models.Siniflar
{
    public class CVContext:DbContext
    {
      
        public DbSet<Anasayfa> Anasayfas { get; set; }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;Database=AdminYonetimliCV; Persist Security Info=True; MultipleActiveResultSets=True; TrustServerCertificate=True; integrated security=true");
        }

    }

   
}
