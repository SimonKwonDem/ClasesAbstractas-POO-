using Capas1.Controller;
using Capas1.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        UserController controller = new UserController();
        controller.ListarModuloPorUsuario();
        controller.AgregarUsuario(new Estudiante("Mateo"));
        controller.AgregarUsuario(new Dedu("Superman"));
        controller.ListarModuloPorUsuario();
    }
}