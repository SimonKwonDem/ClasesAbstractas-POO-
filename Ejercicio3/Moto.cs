using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Moto : Vehiculo
    {
        public Moto(string marca, string color) : base(marca, color) 
        { 
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motocicleta en marcha..");
        }
        public override void Acelerar()
        {
            Console.WriteLine($"Acelerando la {marca}, ra ta ta ra ta ta ");
        }
    }
    
}
