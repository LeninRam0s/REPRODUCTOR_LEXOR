﻿using REPRODUCTOR_LEXOR.CapaDatos;
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
        }//INSERTAR PISTA

        public bool exiteCancion(string nombre)
        {
            CapaBD datos = new CapaBD();
            return datos.existeDato(nombre);
        }//VALIDA SI EXISTE LA CANCION

        public void guardarLista(string nombre)
        {
            CapaBD datos = new CapaBD();
            datos.guardarLista(nombre);
        }//GUARDA LA LISTA DE REPRODUCCION

        public List<string> todasLasListas()
        {
            CapaBD datos = new CapaBD();
            return datos.listasReproduccion();
        }//RETORNA LISTAS DE REPRODUCCION

        public List<string> todasLasPistas()
        {
            CapaBD datos = new CapaBD();
            return datos.listaMultimedia();
        }//RETORNA PISTAS DE LA DB

        public void insertarAPlaylist(string nombreLista, string nombreCancion)
        {
            CapaBD datos = new CapaBD();
            datos.guardarPlayList(nombreCancion, nombreLista);
        }//INSERTA ITEMS A LAS PLAYLIST

        public ListaCircular reproducirPlaylist(string playlist)
        {
            CapaBD datos = new CapaBD();
            return datos.reproducirListaCircular(playlist);
        }//REPRODUCE LA PLAYLIST SELECCIONADA
    }
}
