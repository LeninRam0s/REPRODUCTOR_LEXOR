using REPRODUCTOR_LEXOR.CapaDatos;
using REPRODUCTOR_LEXOR.DAO;
using REPRODUCTOR_LEXOR.ListaCircularEjemplos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.Formularios
{
    class TodoSobreMultimedia
    {


        public List<MultimediaDB> canciones(string[] rutas)
        {
            List<MultimediaDB> lista = new List<MultimediaDB>();
            MultimediaDB cancion = new MultimediaDB();

            foreach (var mp3 in rutas)
            {
                TagLib.File archivo = TagLib.File.Create(mp3);
                cancion.setNombreArchivo(archivo.Tag.Title);
                lista.Add(cancion);
                cancion = new MultimediaDB();
            }
            return lista;
        }
        public void insertarCancion(string archivo)
        {
            CapaBD datos = new CapaBD();
            datos.agregar(archivo);
        }

        public bool exiteCancion(string nombre)
        {
            CapaBD datos = new CapaBD();
            return datos.existeDato(nombre);
        }

        public void guardarLista(string nombre)
        {
            CapaBD datos = new CapaBD();
            datos.guardarLista(nombre);
        }

        public List<string> todasLasListas()
        {
            CapaBD datos = new CapaBD();
            return datos.listasReproduccion();
        }

        public List<string> todasLasPistas()
        {
            CapaBD datos = new CapaBD();
            return datos.listasMultimedia();
        }



        public void insertarPlaylist(string nombreLista, string nombreCancion)
        {
            CapaBD datos = new CapaBD();
            datos.guardarReproduccion(nombreCancion, nombreLista);
        }

        public ListaCircular reproducirPlaylist(string playlist)
        {
            CapaBD datos = new CapaBD();
            return datos.reproList(playlist);
        }
    }
}
