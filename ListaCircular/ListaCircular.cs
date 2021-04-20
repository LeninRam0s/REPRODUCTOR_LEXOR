
using REPRODUCTOR_LEXOR.ListaCircularExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.ListaCircularEjemplos
{
    class ListaCircular
    {
        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        int totalDatos;

        public ListaCircular()
        {
            primero = null;
            ultimo = null;
            totalDatos = 0;
        }

        public void insertarDato(string dato)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = dato;
            if (primero==null)//en primera instancia el dato es nulo
            {
                primero = nuevo;
                ultimo = nuevo;

                primero.siguiente = primero;
                primero.atras = ultimo;
            }//se le agrega un dato a la cabeza
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.atras = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
            }
            totalDatos++;
        }//insertar

        public void verLista()
        {

            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    actual = actual.siguiente;
                } while (actual != primero);
            }
        }//ver lista

        public string[] traerArreglo()
        {
            string[] datosLista = new string[totalDatos];
            Nodo actual = new Nodo();
            actual = primero;
            int posicion = 0;
            if (actual != null)
            {
                do
                {
                    datosLista[posicion] = actual.dato;
                    actual = actual.siguiente;
                    posicion++;
                } while (actual != primero);
            }
            return datosLista;
        }
    }
}