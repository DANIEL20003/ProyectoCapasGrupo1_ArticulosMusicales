using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class claseConexion
    {
        //string cadena = "Data Source = PANLOREX-LAPTOP; Initial Catalog = BDPRACTICALB; Integrated Security = True";
        string cadena = "Data Source = FIESWL01N15; Initial Catalog = BDPRACTICALB; User = sa; Password = SQLSERVER";
        
        //el error esta en el localhost es poner el inicio  y poner nombre del dbms o base
        //Data Source = ServidorSQL; Initial Catalog = BaseDatos; Integrated Security = True
        //cadena es para guardar datos

        public SqlConnection conectar = new SqlConnection();
        //esto es para una coneccion de base // y posterior a trasbajar con el constructor
        public claseConexion()
        {
            //cadena de coneccion, comando que permite conectar y aqui estan unidas las dos , mediante el constructor
            conectar.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexión abierta correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        public void Cerrar()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("Conexión cerrada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}

