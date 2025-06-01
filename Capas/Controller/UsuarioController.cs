using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas.Ejercicio1.Model;

namespace Capas.Ejercicio1.Controller
{
    internal class UsuarioController
    {
        public List<Usuario> listUser = new List<Usuario>();

        public UsuarioController()
        {
            listUser = new List<Usuario>()
            {
            new Admin("José", "JoséAdmin@example.com"),
            new Editor("Simón", "SimónEditor@example.com")
            };
        }   
        public void AgregarUsuario(Usuario user)
        {
            if(user != null)
            {
                Console.WriteLine($"Nuevo usuario agregado. Nombre: {user.getName()}");
              listUser.Add(user);
            }else
            {
                Console.WriteLine($"No es posible agregar este usuario {user}");
            }
        }

        public void MostrarPermisos()
        {
            foreach (Usuario usuario in listUser)
            {
                usuario.VerPermisos();
            }
        }

    }
}
