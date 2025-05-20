using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using capaEntidades;
using capaDatos;
using System.Data;

namespace capaLogica
{
    public class clasePuente
    {
        claseOperacion objOpera = new claseOperacion();

        public List<string> listarCategoria()
        {
            return objOpera.listCategorias();
        }

        public List<string> listarInstruCatego(string catego)
        {
            return objOpera.listInstrumentoCategoria(catego);
        }

        public DataTable objetenercarrito()
        {
            DataTable datos = objOpera.GetDatosCarrito();
            return datos;
        }
        
        public Carrito obtenerpreciototal()
        {
            return objOpera.Precio_Total();
        }


    }
}
