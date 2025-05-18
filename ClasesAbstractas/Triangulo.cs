using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras.Semana5
{
    internal class Triangulo: Figura
    {
        public double baseT;
        public double alturaT;
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseT = baseTriangulo;
            this.alturaT = alturaTriangulo;
        }
        public override void CalcularArea()
        {
            area = (baseT * alturaT) / 2; 
        }
        public override void MostrarArea()
        {
            Console.WriteLine($"El área del Triangulo es: {area}");
        }
    }
}
