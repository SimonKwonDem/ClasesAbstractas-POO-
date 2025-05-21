using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaz3.Datos
{
    internal class Producto
    {
        public string nombre;
        public int id;
        public decimal precio;

        public Producto(int id, string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.id = id;
            this.precio = precio;
        }
    }
}
