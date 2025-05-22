using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaCom;
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
            int idCliente = DatosComun.ClienteId;
            DataTable dt = new DataTable();
            String consulta = @"SELECT C.id_cliente, C.codigo_producto, P.nombre_producto, P.marca, P.modelo, P.precio_producto, C.cantidad, C.fecha_agregado FROM Carrito C INNER JOIN Productos P ON P.codigo_producto = C.codigo_producto WHERE id_cliente = "+idCliente+"";
            SqlCommand sqlC = new SqlCommand(consulta, objConec.conectar);
            SqlDataAdapter da = new SqlDataAdapter(sqlC);
            da.Fill(dt);

            objConec.Cerrar();
            return dt;
        }

        public double Precio_Total()
        {
            objConec.Abrir();
            int idCliente = DatosComun.ClienteId;
            SqlCommand sqlC = new SqlCommand($"SELECT SUM((P.precio_producto * C.cantidad)) AS totalP FROM Carrito C INNER JOIN Productos P ON P.codigo_producto = C.codigo_producto WHERE id_cliente = {idCliente}", objConec.conectar);
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

        public double Obtener_Iva()
        {
            objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("SELECT valor_iva FROM IVA", objConec.conectar);
            SqlDataReader reader = sqlC.ExecuteReader();
            if (reader.Read())
            {
                double ivaobtenido = Convert.ToDouble(reader["valor_iva"]);
                objConec.Cerrar();
                return ivaobtenido;
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

        public Instrumento objetoInstrumento(string busCodInstru)
        {
            objConec.Abrir();
            string sentencia = $"SELECT * FROM Productos WHERE codigo_producto = '{busCodInstru}'";
            SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
            SqlDataReader reader = sqlC.ExecuteReader();

            if (reader.Read())
            {
                // Verifica si el campo "foto" es NULL
                byte[] fotoBytes = null;
                if (reader["foto"] != DBNull.Value)
                {
                    fotoBytes = (byte[])reader["foto"];
                }

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
                    proveedor = Convert.ToString(reader["proveedor"]),
                    color = Convert.ToString(reader["color"]),
                    material = Convert.ToString(reader["material"]),
                    dimension = Convert.ToString(reader["dimension"]),
                    foto = fotoBytes
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

            string query = @"INSERT INTO Productos 
                        (codigo_producto, nombre_producto, marca, modelo, 
                         precio_producto, anio_fabricacion, id_iva, cantidad, 
                         id_categoriaYo, proveedor, color, material, dimension, foto) 
                        VALUES 
                        (@Codigo, @Nombre, @Marca, @Modelo, 
                         @Precio, @Anio, @IdIva, @Cantidad, 
                         @IdCategoria, @IdProveedor, @Color, @Material, @Dimension, @Foto)";

            using (SqlCommand cmd = new SqlCommand(query, objConec.conectar))
            {
                // Parámetros normales
                cmd.Parameters.AddWithValue("@Codigo", instrumento.codInstru);
                cmd.Parameters.AddWithValue("@Nombre", instrumento.nombre);
                cmd.Parameters.AddWithValue("@Marca", instrumento.marca);
                cmd.Parameters.AddWithValue("@Modelo", instrumento.modelo);
                cmd.Parameters.AddWithValue("@Precio", instrumento.precio);
                cmd.Parameters.AddWithValue("@Anio", instrumento.anioFabrica);
                cmd.Parameters.AddWithValue("@IdIva", instrumento.idIva);
                cmd.Parameters.AddWithValue("@Cantidad", instrumento.cantidad);
                cmd.Parameters.AddWithValue("@IdCategoria", instrumento.idCatego);
                cmd.Parameters.AddWithValue("@IdProveedor", instrumento.proveedor);
                cmd.Parameters.AddWithValue("@Color", instrumento.color);
                cmd.Parameters.AddWithValue("@Material", instrumento.material);
                cmd.Parameters.AddWithValue("@Dimension", instrumento.dimension);

                // Manejo especial para la foto
                if (instrumento.foto != null && instrumento.foto.Length > 0)
                {
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = instrumento.foto;
                }
                else
                {
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = DBNull.Value;
                }

                cmd.ExecuteNonQuery();
            }
            objConec.Cerrar();

            /*objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("INSERT INTO Productos (codigo_producto, nombre_producto, marca, modelo, precio_producto, anio_fabricacion, id_iva, cantidad, id_categoriaYo, id_Proveedor, color, material, dimension, foto) VALUES ('" + instrumento.codInstru + "', '" + instrumento.nombre + "', '" + instrumento.marca + "', '" + instrumento.modelo + "', '" + instrumento.precio + "', '" + instrumento.anioFabrica + "', '" + instrumento.idIva + "', '" + instrumento.cantidad + "', '" + instrumento.idCatego + "', '" + instrumento.idProvee + "', '" + instrumento.color + "', '" + instrumento.material + "', '" + instrumento.dimension + "', '" + instrumento.foto + "')", objConec.conectar);
            sqlC.ExecuteNonQuery();
            objConec.Cerrar();*/
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

        public List<Clientes> listaCliente()
        {
            List<Clientes> VarDatos = new List<Clientes>();
            try
            {
                objConec.Abrir();
                string sentencia = "SELECT * FROM Cliente";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                if (reader.Read())
                {
                    Clientes objClientes = new Clientes
                    {
                        id_cliente = Convert.ToInt32(reader["id_cliente"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Apellido = Convert.ToString(reader["Apellido"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Telefono = Convert.ToString(reader["Telefono"]),
                        Correo_electronico = Convert.ToString(reader["Correo Electronico"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        Contraseña = Convert.ToString(reader["Contraseña"]),
                        Usuario = Convert.ToString(reader["Usuario"])

                    };

                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }

        public void Insertar(Clientes c)
        {
            objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("Insert into Cliente(Nombre,Apellido,Cedula,Telefono,Correo_electronico,Direccion,Contraseña,Usuario) VALUES ('" + c.Nombre + "','" + c.Apellido + "','" + c.Cedula + "','" + c.Telefono + "','" + c.Correo_electronico + "','" + c.Direccion + "','" + c.Contraseña + "','"+c.Usuario+"')", objConec.conectar);
            sqlC.ExecuteNonQuery();
            objConec.Cerrar();
        }

        public List<Clientes> listClientes()
        {
            List<Clientes> VarDatos = new List<Clientes>();
            try
            {
                objConec.Abrir();
                string sentencia = "SELECT * FROM Cliente";
                SqlCommand sqlC = new SqlCommand(sentencia, objConec.conectar);
                SqlDataReader reader = sqlC.ExecuteReader();
                while (reader.Read())
                {
                    Clientes cli = new Clientes
                    {
                        id_cliente = Convert.ToInt32(reader["id_cliente"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Apellido = Convert.ToString(reader["Apellido"]),
                        Cedula = Convert.ToString(reader["Cedula"]),
                        Telefono = Convert.ToString(reader["Telefono"]),
                        Correo_electronico = Convert.ToString(reader["Correo_electronico"]),
                        Direccion = Convert.ToString(reader["Direccion"]),
                        Contraseña = Convert.ToString(reader["Contraseña"]),
                        Usuario = Convert.ToString(reader["Usuario"])
                    };
                    VarDatos.Add(cli);
                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }

        public void modificarInstrumento(string codigo, decimal precio, int cantidad, string proveedor)
        {
            objConec.Abrir();
            SqlCommand sqlC = new SqlCommand("UPDATE Productos SET precio_producto = '"+precio+"', cantidad = '"+cantidad+"', proveedor = '"+proveedor+"' WHERE codigo_producto = '"+codigo+"'", objConec.conectar);
            sqlC.ExecuteNonQuery();
            objConec.Cerrar();
        }
    }
}
