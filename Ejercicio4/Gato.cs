using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Gato : Animal
    {
        public Gato(string nombre, string tipoPelaje, string color) : base(nombre, tipoPelaje, color) 
        {
        }

        public override void SonidoCaracteristico()
        {
            Console.WriteLine($"{nombre} ronronea, (miau miau)");
        }
    }
}
