using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo_electronico { get; set; }
        public string Direccion { get; set; }
        public int id_tipo_cliente { get; set; }
        public string Contraseña { get; set; }
        public string Usuario { get; set; }


    }
}
