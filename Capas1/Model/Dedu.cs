using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas1.Model
{
    internal class Dedu : Usuario
    {
        public Dedu(string name) : base(name)
        {
        }

        public override List<String> ListarModulos()
        {
            return new List<String> { "Gestión de cursos", "Estadísticas", "Soporte" };
        }
    }
}
