using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capas1.Model;

namespace Capas1.Controller
{
    internal class UserController
    {
        private List<IUsuarioModulo> usuarios = new List<IUsuarioModulo>();

        public UserController() 
        {
            usuarios.Add(new UA("Ale"));
            usuarios.Add(new Dedu("Martina"));
            usuarios.Add(new Estudiante("Simón"));
            
        }
        public void ListarModuloPorUsuario()
        {
            Console.WriteLine("Módulos accesibles por usuario.");
            foreach (IUsuarioModulo usuario in usuarios)
            {
                Console.WriteLine("");
                Console.WriteLine($"Usuario {usuario.Name}");
                foreach (var modulo in usuario.ListarModulos())
                {
                    Console.WriteLine($"- {modulo}");
                }
            }
        }
        public void AgregarUsuario(IUsuarioModulo user)
        {
            if (user != null)
            {
                Console.WriteLine("Usuario agregado con éxito");
                usuarios.Add(user);
            }
            else
            {
                Console.WriteLine("Usuario inválido");
            }
        }
    }
}
