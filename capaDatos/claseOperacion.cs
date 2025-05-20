using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using capaEntidades;

namespace capaDatos
{
    public class claseOperacion
    {
        claseConexion objConec = new claseConexion();

        public List<string> listCategorias()
        {
            List<string> VarDatos = new List<string>();
            try
            {
                objConec.Abrir();
                string sentencia = "SELECT * FROM Categoria";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    string categoria = Convert.ToString(reader["Nombre"]); 
                    VarDatos.Add(categoria);
                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }

        public List<string> listInstrumentoCategoria(string busCatego)
        {
            List<string> VarDatos = new List<string>();
            try
            {
                objConec.Abrir();
                string sentencia = $"SELECT nombre_producto FROM Productos P INNER JOIN Categoria C ON P.id_categoriaYo = C.id_categoria WHERE C.Nombre = '{busCatego}'";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    string instrumento = Convert.ToString(reader["nombre_producto"]);
                    VarDatos.Add(instrumento);
                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }

        public DataTable GetDatosCarrito()
        {
            objConec.Abrir();
            DataTable dt = new DataTable();
            String consulta = @"SELECT C.id_cliente, C.codigo_producto, P.nombre_producto, P.marca, P.modelo, P.precio_producto, C.cantidad, C.fecha_agregado FROM Carrito C INNER JOIN Productos P ON P.codigo_producto = C.codigo_producto";
            SqlCommand sqlC = new SqlCommand(consulta, objConec.conectar);
            SqlDataAdapter da = new SqlDataAdapter(sqlC);
            da.Fill(dt);

            objConec.Cerrar();
            return dt;
        }


        public List<string> listCodInstrumento(string busInstru)
        {
            List<string> VarDatos = new List<string>();
            try
            {
                objConec.Abrir();
                string sentencia = $"SELECT * FROM Productos WHERE nombre_producto = '{busInstru}'";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    string codigos = Convert.ToString(reader["codigo_producto"]);
                    VarDatos.Add(codigos);
                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }

        public Instrumento objetoInstrumento(string busIdInstru)
        {
            objConec.Abrir();
            string sentencia = $"SELECT * FROM Productos WHERE codigo_producto = {busIdInstru}";
            SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
            SqlDataReader reader = sqlC.ExecuteReader();

            if (reader.Read())
            {
                Instrumento objInstru = new Instrumento
                {
                    codInstru = Convert.ToString(reader["codigo_producto"]),
                    nombre = Convert.ToString(reader["nombre_producto"]),
                    cantidad = Convert.ToInt64(reader["cantidad"]),
                    precio = Convert.ToDouble(reader["precio_producto"]),
                    marca = Convert.ToString(reader["marca"]),
                    modelo = Convert.ToString(reader["modelo"]),
                    anioFabrica = Convert.ToInt32(reader["anio_fabricacion"]),
                    idIva = Convert.ToInt32(reader["id_iva"])
                };
                objConec.Cerrar();
                return objInstru;
            }
            else
            {
                objConec.Cerrar();
                return null;
            }
        }

        public decimal ObtenerValorIva(int idIva)
        {
            decimal valorIva = 0;
            try
            {
                objConec.Abrir();

                
                string sentencia = "SELECT valor_iva FROM IVA WHERE id_iva = @idIva";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                sqlC.Parameters.AddWithValue("@idIva", idIva);

                SqlDataReader reader = sqlC.ExecuteReader();

                if (reader.Read())
                {
                    
                    if (!reader.IsDBNull(reader.GetOrdinal("valor_iva")))
                    {
                        valorIva = Convert.ToDecimal(reader["valor_iva"]);
                    }
                    else
                    {
                        Console.WriteLine("valor_iva es NULL para el id_iva: " + idIva);
                        valorIva = 0; 
                    }
                }
                else
                {
                    Console.WriteLine("No se encontró valor_iva para el id_iva: " + idIva);
                    valorIva = 0; 
                }

                objConec.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerValorIva: " + ex.Message);
                valorIva = 0;
            }

            return valorIva;
        }

    }
}
