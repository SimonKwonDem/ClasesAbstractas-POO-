using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class EmpleadoMedioTiempo : Empleado
    {
        public int bonoExtra;
        public int horasSemanales;

        public EmpleadoMedioTiempo(string nombre, float sueldoBase,int bonoExtra, int horasSemanales) : base(nombre, sueldoBase)
        {
            this.bonoExtra = bonoExtra;
            this.horasSemanales = horasSemanales;
        }
        public override void CalcularSueldo()
        {
            if (horasSemanales > 20)
            {
                sueldoBase += bonoExtra;
                Console.WriteLine($"El empleado {nombre} superó las 20 horas semanales. Su sueldo es {sueldoBase}");
            }
            else
            {
                Console.WriteLine($"El empleado {nombre}, no superó las 20 horas semanales. Su sueldo es {sueldoBase}");
            } 
        }
    }
}
