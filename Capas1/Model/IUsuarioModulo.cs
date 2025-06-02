using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas1.Model
{
    internal interface IUsuarioModulo
    {
        string Name { get; }
        List<string> ListarModulos();
    }
}
