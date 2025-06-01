using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas.Ejercicio1.Model
{
    internal abstract class Usuario
    {
        private string name;
        private string email;

        public Usuario(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public abstract void VerPermisos();

        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }

    }
}
