﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.ListaCircularEnlazada
{
    class clsListaCircularBase
    {
        private Nodo lc;
        public clsListaCircularBase()
        {
            lc = null;
        }

        public clsListaCircularBase insertarDatosLDE(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (lc != null)
            {//cuando la lista no esta vacia
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;
            }
            lc = nuevo;
            return this;
        }

        public void eliminar(string entrada)
        {
            Nodo actual;
            bool encontrado = false;
            //bucle de búsqueda
            actual = lc;
            while ((actual.enlace != lc) && (!encontrado))
            {
                encontrado = (actual.enlace.dato == entrada);
                if (!encontrado)
                {
                    actual = actual.enlace;
                }
            }

            encontrado = (actual.enlace.dato == entrada);
            // Enlace de nodo anterior con el siguiente
            if (encontrado)
            {
                Nodo p;
                p = actual.enlace; // Nodo a eliminar
                if (lc == lc.enlace) // Lista con un solo nodo
                    lc = null;
                else
                {
                    if (p == lc)
                    {
                        lc = actual; // Se borra el elemento referenciado por lc,
                                     // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                p = null;
            }
        }

        public void recorrer()
        {
            Nodo p;
            if (lc != null)
            {
                p = lc.enlace; // siguiente nodo al de acceso
                do
                {
                    Console.WriteLine("\t" + p.dato);
                    p = p.enlace;
                } while (p != lc.enlace);
            }
            else
                Console.WriteLine("\t Lista Circular vacía.");
        }
    }
}
