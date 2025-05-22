using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<string> listarCodInstrumento(string instru)
        {
            return objOpera.listCodInstrumento(instru);
        }

        public Instrumento infoInstrumento(string codInstrumento)
        {
            return objOpera.objetoInstrumento(codInstrumento);
        }

        public DataTable objetenercarrito()
        {
            DataTable datos = objOpera.GetDatosCarrito();
            return datos;
        }

        public double obtenerpreciototal()
        {
            return objOpera.Precio_Total() * (1 + (objOpera.Obtener_Iva() / 100));
        }

        public double obtneriva()
        {
            return objOpera.Obtener_Iva();
        }

        public void eliminarProd(string producto)
        {
            objOpera.eliminarProducto(producto);
        }

        public void actualizarIv(decimal newValor)
        {
            objOpera.actualizarIva(newValor);
        }

        public decimal getIva(int idIVA)
        {
            return objOpera.obtenerIva(idIVA);
        }

        public void insertCarrito(List<Carrito> listCarritos)
        {
            objOpera.insertarCarrito(listCarritos);
        }
        public claseIva showIvaActual()
        {
            return objOpera.getIvaActual();
        }
        public void IngresarInstrumento(Instrumento instrumento)
        {
            objOpera.IngresarInstrumento(instrumento);
        }
        public List<Clientes> listarD()
        {
            return objOpera.listaCliente();
        }

        public void Ingresar(Clientes DatosUsuario)
        {
            objOpera.Insertar(DatosUsuario);
        }

        public List<Clientes> getClientes()
        {
            return objOpera.listClientes();
        }
        public string getC(int id)
        {
            return objOpera.getCategoria(id);
        }

        public void modificarInstrumento(string codigo, decimal precio, int cantidad, string proveedor)
        {
            objOpera.modificarInstrumento(codigo, precio, cantidad, proveedor);
        }
    }
}