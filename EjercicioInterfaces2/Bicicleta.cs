using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces2
{
    internal class Bicicleta : IVehiculo
    {
        public string marca;
        public int rodado;

        public Bicicleta(string marca, int rodado)
        {
            this.marca = marca; 
            this.rodado = rodado;
        }

        public void Conducir()
        {
            Console.WriteLine($"Pedaleando mi bicicleta {marca}, rodado {rodado}");
        }

    }
}
