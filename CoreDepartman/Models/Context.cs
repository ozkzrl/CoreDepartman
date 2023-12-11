using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {   
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-UQPST9J;database=corepersonel;integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<Departmanlar> Departmanlars { get; set; }

        public DbSet<Personel> Personels { get; set; } 
    }
}
