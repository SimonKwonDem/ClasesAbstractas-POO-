using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio4
{
    internal class Perro : Animal
    {
        public Perro(string nombre, string tipoPelaje, string color) : base(nombre, tipoPelaje, color)
        {
        }
        public override void SonidoCaracteristico()
        {
            Console.WriteLine($"{nombre} ladra (guau guau)");
        }
    }
}
