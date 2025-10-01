using BibliothecaVehiculos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothecaVehiculos.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-B9HDS386;Database=GestionVehiculosDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
