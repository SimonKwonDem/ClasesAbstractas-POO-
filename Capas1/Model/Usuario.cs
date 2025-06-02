using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas1.Model
{
    internal abstract class Usuario : IUsuarioModulo
    {
        public string Name { get; }
        public Usuario(string name) 
        {
            Name = name;   
        }
        public abstract List<String> ListarModulos();
       
    }
}
