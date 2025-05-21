using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioInterfaz3.Datos;

namespace EjercicioInterfaz3.Logica
{
    internal class LogicaProducto : IWeb
    {
        public Producto p1;

        public int id;
        public string nombre;
        public decimal precio;

        public bool CargarProducto(int id, string nombre, decimal precio)
        {
            if (id > 0)
            {
                this.id = id;
            }
            else return false;
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                this.nombre = nombre;
            }
            else return false;
            if (precio > 0)
            {
                this.precio = precio;
            }
            else return false;
            p1 = new Producto(this.id, this.nombre, this.precio);
            if (p1 != null)
            {
                return true;
            }
            else return false;
        } 

        public void Get(int id)
        {
            Console.WriteLine($"Obteniendo Producto con ID {id}. Datos. Id: {p1.id}, Nombre: {p1.nombre}, Precio: {p1.precio}");
        }
        public void Post(string nuevo)
        {
            Console.WriteLine($"Cargando Producto: {nuevo}");
        }
        public void Put(int id, string cambio)
        {
            Console.Write($"Actualizando Producto con ID {id}.");
            if (id == p1.id)
            {
                p1.nombre = cambio;
                Console.WriteLine($"Producto actualizado. Cambio de nombre: {p1.nombre}");
            }
            else Console.WriteLine("No se encontró el producto con ese Id");
        }
        public void Delete(int id)
        {
            if (id == p1.id)
            {
                Console.WriteLine($"Producto con id {id} eliminado");
            }
            else Console.WriteLine("Producto no encontrado.");
        }
    }
}
