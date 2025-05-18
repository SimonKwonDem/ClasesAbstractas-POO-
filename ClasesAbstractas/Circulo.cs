using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Circulo : Figura
    {
        public double radio;
        public Circulo(double radioCirculo)
        {
            this.radio = radioCirculo;
        }
        public override void CalcularArea()
        {
            area = Math.PI * (radio * radio);
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Circulo es: {area}");
        }
    }
}
