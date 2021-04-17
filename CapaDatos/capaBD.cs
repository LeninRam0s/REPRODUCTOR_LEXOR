using REPRODUCTOR_LEXOR.DAO;
using REPRODUCTOR_LEXOR.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.CapaDatos
{
    class CapaBD
    {
        ConexionDbSQL conexionSQL = new ConexionDbSQL();
        public bool existeDato(string multimedia)
        {
            String query = $"SELECT * FROM multimedia WHERE nombreArchivo = '{multimedia}'";
            DataTable dt = conexionSQL.consultaDT(query);
            int n = dt.Rows.Count;
            return n == 0 ? false : true;
        }

        public void agregar(string multimedia)
        {
            String query = $"INSERT INTO multimedia VALUES('{multimedia}')";
            conexionSQL.ejecutaScripSQL(query);
        }

        public void guardarLista(string multimedia)
        {
            String query = $"INSERT INTO listas VALUES('{multimedia}')";
            conexionSQL.ejecutaScripSQL(query);
        }



        public List<String> listasReproduccion()
        {
            String query = $"SELECT * FROM listas";
            DataTable dt = conexionSQL.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombre"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
                nombreMultimedia = "";
            }
            return archivosMultimedia;
        }

        public List<String> listasMultimedia()
        {
            String query = $"SELECT * FROM multimedia";
            DataTable dt = conexionSQL.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombreArchivo"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
            }
            return archivosMultimedia;
        }

        public void guardarReproduccion(String pista, String lista)
        {
            String query = $"INSERT INTO playlist VALUES('{pista}','{lista}')";
            conexionSQL.ejecutaScripSQL(query);
        }

        public List<String> reproList(string lista)
        {
            String query = $"SELECT  * FROM playlist WHERE nombreLista='{lista}';";
            DataTable dt = conexionSQL.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombrePista"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
                //nombreMultimedia = "";
            }
            return archivosMultimedia;
        }
    }
}
