using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Moto : IVehiculo
    {
        public string marca;
        public int cilindrada;

        public Moto(string marca, int cilindrada)
        {
            this.marca = marca;
            this.cilindrada = cilindrada;
        }
          
        public void Conducir()
        {
            Console.WriteLine($"Conduciendo mi {marca} que tiene una cilindrada de {cilindrada}cc");
        }
    }
}
