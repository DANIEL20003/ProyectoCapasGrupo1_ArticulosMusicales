using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidades
{
    public class Carrito
    {
        public int idCli { get; set; }
        public string codigoInstru { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
        
    }
}
