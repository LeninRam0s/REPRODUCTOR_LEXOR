using REPRODUCTOR_LEXOR.DAO;
using REPRODUCTOR_LEXOR.ListaCircularEjemplos;
using REPRODUCTOR_LEXOR.listaDoble;
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
        }//VERIFICAR SI EXISTE LA CANCION

        public void agregar(string multimedia)
        {
            String query = $"INSERT INTO multimedia VALUES('{multimedia}')";
            conexionSQL.ejecutaScripSQL(query);
        }//AGREGAR PISTAS MULTIMEDIA

        public void guardarLista(string multimedia)
        {
            String query = $"INSERT INTO listas VALUES('{multimedia}')";
            conexionSQL.ejecutaScripSQL(query);
        }//GUARDA LISTAS DE REPRODUCCION

        public List<String> listasReproduccion()
        {
            String query = $"SELECT * FROM listas";
            DataTable dt = conexionSQL.consultaDT(query);
            List<String> archivosMultimedia = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombre"].ToString();
                archivosMultimedia.Add(nombreMultimedia);
            }
            return archivosMultimedia;
        }//RETORNA LISTAS DE REPROCCIONES

        public List<String> listaMultimedia()
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
        }//LISTA LAS PISTAS MULTIMEDIA

        public void guardarPlayList(String pista, String lista)
        {
            String query = $"INSERT INTO playlist VALUES('{pista}','{lista}')";
            conexionSQL.ejecutaScripSQL(query);
        }//GUARDAR LISTAS DE REPRODUCCION

        public ListaCircular reproducirListaCircular(string lista)
        {
            String query = $"SELECT  * FROM playlist WHERE nombreLista='{lista}';";
            DataTable dt = conexionSQL.consultaDT(query);
            ListaCircular listaCircular = new ListaCircular();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombrePista"].ToString();
                listaCircular.insertarDato(nombreMultimedia);
            }
            return listaCircular;
        }//LISTA CIRCULAR

        public clsListaDoble insertarAlInicio(string lista)
        {
            String query = $"SELECT  * FROM playlist WHERE nombreLista='{lista}';";
            DataTable dt = conexionSQL.consultaDT(query);
            clsListaDoble datoInicio = new clsListaDoble();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombrePista"].ToString();
                datoInicio.insertarCabezaLista(nombreMultimedia);
            }
            return datoInicio;
        }//INSERTA INICIO

        public clsListaDoble insertarAlFinal(string lista)
        {
            String query = $"SELECT  * FROM playlist WHERE nombreLista='{lista}';";
            DataTable dt = conexionSQL.consultaDT(query);
            clsListaDoble listaEnlazada = new clsListaDoble();
            foreach (DataRow dr in dt.Rows)
            {
                String nombreMultimedia = dr["nombrePista"].ToString();
                listaEnlazada.insertaDespues(, nombreMultimedia);
            }
            return listaEnlazada;
        }//INSERTA INICIO



    }
}
