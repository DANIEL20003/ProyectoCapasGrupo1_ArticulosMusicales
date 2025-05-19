using System;
using System.Collections.Generic;
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
                    string objEnt = Convert.ToString(reader["Nombre"]); 
                    VarDatos.Add(objEnt);
                }
            }
            catch
            {
                VarDatos = null;
            }
            objConec.Cerrar();
            return VarDatos;
        }
    }
}
