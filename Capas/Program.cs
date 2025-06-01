using Capas.Ejercicio1.Controller;
using Capas.Ejercicio1.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        UsuarioController controller = new UsuarioController();
        controller.MostrarPermisos();
        Console.WriteLine("");

        controller.AgregarUsuario(new Lector("Martin", "MartinLector@exapmle.com"));
        controller.MostrarPermisos();

    }
}