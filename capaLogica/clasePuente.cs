using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using capaEntidades;
using capaDatos;

namespace capaLogica
{
    public class clasePuente
    {
        claseOperacion objOpera = new claseOperacion();

        public List<string> listarCategoria()
        {
            return objOpera.listCategorias();
        }




    }
}
