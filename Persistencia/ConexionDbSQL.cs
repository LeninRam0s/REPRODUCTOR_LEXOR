using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.Persistencia
{
    class ConexionDbSQL
    {
        public SqlConnection conexion;
        private String conexionDB { get; }

        public ConexionDbSQL()
        {
            conexionDB = "Data Source=DESKTOP-5G9V952;Initial Catalog=reproductorDB;Integrated Security=True";
        }

        public void closeConexionBD()
        {
            conexion.Close();
        }

        public void openConexion()
        {
            conexion = new SqlConnection(conexionDB);
            Console.WriteLine("Conexion Establecida");
            conexion.Open();
        }

        /// <summary>
        /// metodo que ejecuta una consulta, esta clase maneja la apertura y clausura a la base de datos
        /// </summary>
        /// <param name="sqll"></param>
        /// <returns></returns>
        public DataTable consultaDT(String sqll)
        {
            openConexion();
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            closeConexionBD();
            return dataTable;
        }

        /// <summary>
        /// ejecuta una instrucción de insersion, eliminación y actualización,
        /// esta clase se encarga de manejar las aperturas y clausuras de la conexion.
        /// </summary>
        /// <param name="sqll"></param>
        public void ejecutaScripSQL(String sqll)
        {
            openConexion();
            try
            {

                SqlCommand comm = new SqlCommand(sqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                closeConexionBD();
            }
        }

        /// <summary>
        /// ejecuta instrucciones SQL, pero el progromador debe manejar la apertura y clausura
        /// de las conexiones.
        /// </summary>
        /// <param name="sqll"></param>
        public void EjecutaSQLManual(String sqll)
        {
            // se abre y cierra la conexino manualmente
            SqlCommand comm = new SqlCommand(sqll, conexion);
            comm.ExecuteReader();
        }
    }
}
