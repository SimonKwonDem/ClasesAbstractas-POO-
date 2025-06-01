using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Ejercicio1.Model
{
    internal class Lector : Usuario
    {
        public Lector(string name, string email) : base(name, email) 
        { }
        public override void VerPermisos()
        {
            Console.WriteLine($"[Lector] {getName()}. Permisos: Ver");
        }
    }
}
