using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaPresentacion
{
    public class Usuario
    {
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }

        // Constructor
        public Usuario(string usuarioNombre, string contraseña)
        {
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }
    }
}
