using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal abstract class Vehiculo
    {
        public string marca;
        public string color;

        public Vehiculo(string marca, string color)
        {
            this.marca = marca;
            this.color = color;
        }
        public abstract void Arrancar();
        public virtual void Acelerar()
        {
            Console.WriteLine("Acelerando vehículo..");
        }

    }
}
