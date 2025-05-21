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

        public double Precio_Total()
        {
            objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("SELECT SUM(P.precio_producto * C.cantidad) AS totalP FROM Carrito C INNER JOIN Productos P ON P.codigo_producto = C.codigo_producto", objConec.conectar);
            SqlDataReader reader = sqlC.ExecuteReader();
            if (reader.Read())
            {
                double precioT = Convert.ToDouble(reader["totalP"]);
                objConec.Cerrar();
                return precioT;
            }
            else
            {
                objConec.Cerrar();
                return 0;
            }
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
            string sentencia = $"SELECT * FROM Productos WHERE codigo_producto = '{busIdInstru}'";
            SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
            SqlDataReader reader = sqlC.ExecuteReader();

            if (reader.Read())
            {
                Instrumento objInstru = new Instrumento
                {
                    codInstru = Convert.ToString(reader["codigo_producto"]),
                    nombre = Convert.ToString(reader["nombre_producto"]),
                    marca = Convert.ToString(reader["marca"]),
                    modelo = Convert.ToString(reader["modelo"]),
                    precio = Convert.ToDecimal(reader["precio_producto"]),
                    anioFabrica = Convert.ToInt32(reader["anio_fabricacion"]),
                    idIva = Convert.ToInt32(reader["id_iva"]),
                    cantidad = Convert.ToInt64(reader["cantidad"]),
                    idCatego = Convert.ToInt32(reader["id_categoriaYo"]),
                    idProvee = Convert.ToInt32(reader["id_Proveedor"]),
                    color = Convert.ToString(reader["color"]),
                    material = Convert.ToString(reader["material"]),
                    dimension = Convert.ToString(reader["dimension"])
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

        public void eliminarProducto(string codProducto)
        {
            objConec.Abrir();
            
            SqlCommand eliminarC=new SqlCommand($"DELETE FROM Carrito WHERE codigo_producto = '{codProducto}';", objConec.conectar);
            eliminarC.ExecuteNonQuery();
            SqlCommand eliminarP=new SqlCommand($"Delete from Productos where codigo_producto='{codProducto}';", objConec.conectar);
            eliminarP.ExecuteNonQuery();

            objConec.Cerrar();
        }

        public void actualizarIva(decimal valorI)
        {
            objConec.Abrir();

            SqlCommand actualizarI = new SqlCommand($"Update IVA set valor_iva={valorI} where id_iva=1", objConec.conectar);
            actualizarI.ExecuteNonQuery();

            objConec.Cerrar();
        }

        public decimal obtenerIva(int idIva)
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
        

        public void insertarCarrito(List<Carrito> newCarrito)
        {
            objConec.Abrir();

            foreach(Carrito c in newCarrito)
            {
                string sentencia = $"INSERT INTO Carrito (id_cliente, codigo_producto, cantidad, fecha_agregado) VALUES ({c.idCli}, '{c.codigoInstru}',{c.cantidad}, '{c.fecha}')";
                SqlCommand insertarP = new SqlCommand(sentencia, objConec.conectar);
                insertarP.ExecuteNonQuery();
            }
            objConec.Cerrar();

        }
        public void IngresarInstrumento(Instrumento instrumento)
        {
            objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("INSERT INTO Productos (codigo_producto, nombre_producto, marca, modelo, precio_producto, anio_fabricacion, id_iva, cantidad, id_categoriaYo, id_Proveedor, color, material, dimension, foto) VALUES ('" + instrumento.codInstru + "', '" + instrumento.nombre + "', '" + instrumento.marca + "', '" + instrumento.modelo + "', '" + instrumento.precio + "', '" + instrumento.anioFabrica + "', '" + instrumento.idIva + "', '" + instrumento.cantidad + "', '" + instrumento.idCatego + "', '" + instrumento.idProvee + "', '" + instrumento.color + "', '" + instrumento.material + "', '" + instrumento.dimension + "', '" + instrumento.foto + "')", objConec.conectar);
            sqlC.ExecuteNonQuery();
            objConec.Cerrar();
        }

        public claseIva getIvaActual()
        {
            objConec.Abrir();
            SqlCommand consulta = new SqlCommand($"select * from IVA where id_iva=1", objConec.conectar);
            SqlDataReader reader = consulta.ExecuteReader();

            if (reader.Read())
            {
                claseIva objIva = new claseIva()
                {
                    id_iva = Convert.ToInt32(reader["id_iva"]),
                    valor_iva = Convert.ToDecimal(reader["valor_iva"])
                };
                objConec.Cerrar();
                return objIva;
            }
            else
            {
                objConec.Cerrar();
                return null;
            }
        }
    }
}
