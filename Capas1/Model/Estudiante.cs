using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas1.Model
{
    internal class Estudiante : Usuario
    {
        public Estudiante(string name) : base (name)
        {
        }

        public override List<String> ListarModulos()
        {
            return new List<String> { "Soporte" };
        }
    }
}
