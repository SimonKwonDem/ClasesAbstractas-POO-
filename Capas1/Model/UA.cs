using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas1.Model
{
    internal class UA : Usuario
    {
        public UA(string name) : base(name) 
        { }

        public override List<String> ListarModulos()
        {
            return new List<String> { "Administración", "Gestión de cursos", "Estadísticas" };
        }
    }
}
