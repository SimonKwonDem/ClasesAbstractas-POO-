using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal abstract class Animal
    {
        public string nombre;
        public string tipoPelaje;
        public string color;

        public Animal(string nombre, string tipoPelaje, string color)
        {
            this.nombre = nombre;
            this.tipoPelaje = tipoPelaje;
            this.color = color;
        }

        public abstract void SonidoCaracteristico();
    }
}
