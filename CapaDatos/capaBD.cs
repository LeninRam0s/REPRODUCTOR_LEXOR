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
    class capaBD
    {
        ConexionDbSQL cn = new ConexionDbSQL();
        public bool existe(Multimedia multimedia)
        {
            String query = $"SELECT * FROM multimedia WHERE nombre = '{multimedia.getNombre()}'";

            DataTable dt = cn.consultaDT(query);
            int n = dt.Rows.Count;
            return n == 0 ? true : false;
        }

        public void agregar(Multimedia multimedia)
        {
            String query = $"INSERT INTO multimedia VALUES('{multimedia.getNombre()}')";
            cn.ejecutaScripSQL(query);
        }

        public String insertar(string nombre)
        {
            String query = $"INSERT INTO listas VALUES('{nombre}')";
            cn.ejecutaScripSQL(query);

            return "Lista Guardada";
        }

        public List<String> listasReproduccion()
        {
            String query = $"SELECT * FROM listas";
            DataTable dt = cn.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombreArchivo"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
                nombreMultimedia = "";
            }
            return archivosMultimedia;
        }

        public void guardarReproduccion(String pista, String lista)
        {
            String query = $"INSERT INTO playlist VALUES('{pista}','{lista}')";
            cn.ejecutaScripSQL(query);
        }

        public List<String> cancionesRepro(string lista)
        {
            String query = $"SELECT  * FROM playlist WHERE nombreLista='{lista}';";
            DataTable dt = cn.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombrePista"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
                nombreMultimedia = "";
            }
            return archivosMultimedia;
        }
    }
}
