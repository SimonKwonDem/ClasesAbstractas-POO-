using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz3.Logica
{
    internal interface IWeb
    {
       
        public void Get(int id);
        public void Post(string nuevo);
        public void Put(int id, string cambio);
        public void Delete(int id);
        

       
    }
}
