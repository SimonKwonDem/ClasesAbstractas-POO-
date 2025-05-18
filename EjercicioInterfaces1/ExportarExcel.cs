using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces1
{
    internal class ExportarExcel : IExportable
    {
        public void Exportar(string contenido)
        {
            Console.WriteLine($"Exportando a formato Excel: {contenido}");
        }
    }
}
