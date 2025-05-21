using EjercicioInterfaz3.Datos;
using EjercicioInterfaz3.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Estamos desarrollando una Api Rest y debemos asegurarnos de que cada clase que creemos (las
        cuales representan una tabla de nuestra base de datos) tenga las posibilidades de que se puedan
        realizar peticiones GET(int id) para obtener información, POST(string nuevo) para crear nuevos
        registros, PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.*/

        LogicaProducto producto = new LogicaProducto();
        Console.WriteLine($"Se cargó el producto: {producto.CargarProducto(1, "Monitor", 200)}");
        producto.Get(1);
        producto.Post("Celular");
        producto.Put(1, "Notebook");
        producto.Delete(1);
    }

}