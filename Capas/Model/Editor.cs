using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Ejercicio1.Model
{
    internal class Editor : Usuario
    {
        public Editor(string name, string email) : base(name, email) 
        { }
        public override void VerPermisos()
        {
            Console.WriteLine($"[Editor] {getName()}. Permisos: Editar, Ver");
        }
    }
}
