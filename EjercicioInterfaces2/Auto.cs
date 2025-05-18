using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Auto : IVehiculo
    {
        public string marca;
        public string color;

        public Auto(string marca, string color)
        {
            this.marca = marca;
            this.color = color;
        }

        public void Conducir()
        {
            Console.WriteLine($"Conduciendo mi {marca} de color {color}");
        }
    }
}
