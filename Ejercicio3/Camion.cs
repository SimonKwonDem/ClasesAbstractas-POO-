using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Camion : Vehiculo
    {
        public Camion(string marca, string color) : base(marca, color) 
        { 
        }

        public override void Arrancar()
        {
            Console.WriteLine("Camión en marcha..");
        }
        public override void Acelerar()
        {
            Console.WriteLine($"Acelerando el {marca}, bbbff ");
        }
    }
}
