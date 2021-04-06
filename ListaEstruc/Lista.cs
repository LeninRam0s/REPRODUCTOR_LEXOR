using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPRODUCTOR_LEXOR.ListaEstruc;


namespace REPRODUCTOR_LEXOR.ListaEstruc
{
    class Lista
    {
        public Nodo primero;
        public Lista()
        {
            primero = null;
        }

        private int leerEntero()
        {
            int x = Console.Read();
            Console.WriteLine("Ingrese: -1 para finalizar");
            return x;
        }//fin leer Entero
       
        public Lista crearLista()
        {
            int x;
            primero = null;
            do
            {
                x = leerEntero();
                if (x!=-1)
                {
                    primero = new Nodo(x, primero);
                }

            } while (x!=-1);
            return this;
        }//fin crear lista

        public Nodo buscarPosicion(int posicion)
        {
            Nodo indice;
            int i;
            if (posicion<0)
            {
                return null;
            }

            indice = primero;
            for (i = 1; (i < posicion) && (indice!=null); i++)
            {
                indice = indice.enlace;
            }

            return indice.enlace;
        }//fin buscar posicion

        public Lista insertarUltimo(Nodo ultimo, int entrada)
        {
            ultimo.enlace = new Nodo(entrada);
            ultimo = ultimo.enlace;

            return (Lista) this;//lo cambie x List
        }//fin insertar ultimo

        public Lista insertarCabeza(Nodo cabeza, int valor)
        {
            cabeza.enlace = new Nodo(valor);
            cabeza = cabeza.enlace;
            return this;
        }//fin insertar Cabeza

        public Nodo buscarLista(int destino)
        {
            Nodo indice;
            for (indice = primero; indice !=null; indice= indice.enlace)
            {
                if (destino==indice.dato)
                {
                    return indice;
                }
            }return null;
        }//fin buscar lista

        public void eliminar(int entrada)
        {
            Nodo actual, anterior;
            bool encontrado;

            //inicializa apuntadores de memoria
            actual = primero;
            anterior = null;
            encontrado = false;

            //buscar nodo anterior
            while ((actual!=null)&&(!encontrado))
            {
                encontrado = (actual.dato == entrada);

                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//fin while

            //enlace del nodo anterior con el siguiente (puente)
            if (actual!=null)
            {
                //destinguir entre el nodo cabeza o si es otro de la lista

                if (actual==primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }//fin if
        }//fin eliminar

        public Lista insertarLista(int testigo, int entrada)
        {
            Nodo nuevo, anterior;
            anterior = buscarLista(testigo);
            if (anterior!=null)
            {
                nuevo = new Nodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo.enlace;
            }return this;
        }//fin insetar Lista

        public void visuzlizar()
        {
            Nodo n;
            int k = 0;
            n = primero;

            while (n!=null)
            {
                Console.WriteLine(n.dato);
                n = n.enlace;
                k++;
                Console.WriteLine(k % 15 != 0 ? " " : "\n");
            }
        }//fin visualizar

    }//fin clase lista
}
