using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Cuadrado : Figura 
    {
        public double lado;
        public Cuadrado(double ladoCuadrado) 
        {
            this.lado = ladoCuadrado;
        }
        public override void CalcularArea()
        {
            area = (lado * lado);
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Cuadrado es: {area}");
        }
    }
}
