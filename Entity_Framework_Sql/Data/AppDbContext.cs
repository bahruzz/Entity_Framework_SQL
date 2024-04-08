using Entity_Framework_Sql.Models;
using Microsoft.EntityFrameworkCore;


namespace Entity_Framework_Sql.Data
{

    internal class AppDbContext:DbContext
    {

        public DbSet<Setting> Settings  { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HMGHF14\\SQLEXPRESS;Database=EntityFrameworkPB101Db;Trusted_Connection=true;TrustServerCertificate=True");
        }

    }
}
