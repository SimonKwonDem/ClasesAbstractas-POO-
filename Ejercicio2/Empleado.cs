using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal abstract class Empleado
    {
        public string nombre;
        protected float sueldoBase;

        public Empleado(string nombre, float sueldoBase)
        {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
        }

        public abstract void CalcularSueldo();
    }
}
