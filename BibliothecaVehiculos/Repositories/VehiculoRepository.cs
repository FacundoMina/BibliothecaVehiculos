using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliothecaVehiculos.Models;
using BibliothecaVehiculos.Data;

namespace BibliothecaVehiculos.Repositories
{
    public class VehiculoRepository
    {
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            using (var context = new AplicationDbContext())
            {
                
                context.Vehiculos.Add(vehiculo);
                context.SaveChanges();
            }
        }
        public void ObtenerVehiculos()
        {
            using (var context = new AplicationDbContext())
            {
                var vehiculos = context.Vehiculos.ToList();
                foreach (var vehiculo in vehiculos)
                {
                    Console.WriteLine($"ID: {vehiculo.ID}, Marca: {vehiculo.Marca}, Modelo: {vehiculo.Modelo}, Año: {vehiculo.Año}");
                }
            }
        }
    }
}
