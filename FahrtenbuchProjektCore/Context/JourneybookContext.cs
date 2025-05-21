using FahrtenbuchProjektCore.Models;
using Microsoft.EntityFrameworkCore;

namespace FahrtenbuchProjektCore.Context
{
    public class JourneybookContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CompanyCar> CompanyCars { get; set; }
        public DbSet<Journey> Journeys { get; set; }

        public string DbPath { get; set; }

        public JourneybookContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Journeybook.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
