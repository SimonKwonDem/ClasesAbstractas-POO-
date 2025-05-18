using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Auto : Vehiculo
    {
        public Auto(string marca, string color) : base(marca, color) 
        {
        }
        public override void Arrancar()
        {
            Console.WriteLine("Automóvil en marcha..");
        }
        public override void Acelerar()
        {
            Console.WriteLine($"Acelerando el {marca}, pa pa pa ");
        }
    }
}
