using BibliothecaVehiculos.Models;
using BibliothecaVehiculos.Repositories;
using BibliothecaVehiculos.Data;
using BibliothecaVehiculos;

namespace AppVehiculosWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var vehiculo = new Vehiculo
            {
                Marca = textBox1.Text,
                Modelo = textBox2.Text,
                Año = int.Parse(textBox3.Text)
            };
            VehiculoRepository.AgregarVehiculo(vehiculo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehiculoRepository.ObtenerVehiculos();
        }
    }
}
