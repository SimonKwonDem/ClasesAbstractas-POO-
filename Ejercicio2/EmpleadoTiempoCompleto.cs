using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        public int bonoPresentismo;
        public int diasTrabajados;

        public EmpleadoTiempoCompleto(string nombre, float sueldoBase, int bonoPresentismo, int diasTrabajados) : base(nombre, sueldoBase)
        {
            this.bonoPresentismo = bonoPresentismo;
            this.diasTrabajados = diasTrabajados;
        }
        public override void CalcularSueldo()
        {
            if (diasTrabajados >= 24) 
            { 
                sueldoBase += bonoPresentismo;
                Console.WriteLine($"El sueldo del empleado {nombre} es igual a {sueldoBase}");
            } 
            else
             if(diasTrabajados < 24)
              {
                Console.WriteLine($"El empleado no completo sus días laborales. Su sueldo es {sueldoBase}");
              }
        }
    }
}
