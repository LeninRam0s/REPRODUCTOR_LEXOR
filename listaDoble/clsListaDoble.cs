using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class clsListaDoble
    {
        //el primer nodo que se inserta
        public Nodo cabeza;

        //constructor

        public clsListaDoble()
        {
            cabeza = null;
        }

        public clsListaDoble insertarCabezaLista(string entradaMultimedia)
        {
            Nodo nuevo;
            nuevo = new Nodo(entradaMultimedia);
            nuevo.siguiente = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return this;
        }

        public clsListaDoble insertaDespues(Nodo anterior, string entradaMultimedia)
        {
            Nodo nuevo;
            nuevo = new Nodo(entradaMultimedia);
            nuevo.siguiente = anterior.siguiente;
            if (anterior.siguiente != null)
            {
                anterior.siguiente.atras = nuevo;
            }
            anterior.siguiente = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(string entradaMultimedia)
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;
            //ciclo de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato.Equals(entradaMultimedia)); //con estring la comparacion == se cambia a equals
                if (!encontrado)
                {
                    actual = actual.siguiente;
                }
            }//enlace del nodo anterior con el siguiente

            if (actual != null)
            {
                //distinguir entre nodo cabecera del resto de la lista
                if (actual==cabeza)
                {
                    cabeza = actual.siguiente;
                    if (actual.siguiente != null)
                    {
                        actual.siguiente.atras = null;
                    }
                    else if (actual.siguiente != null)
                    { //no es el ultimo nodo si la condicion se cumple
                        actual.atras.siguiente = actual.siguiente;
                        actual.siguiente.atras = actual.atras;
                    }
                    else //sino es el ultimo nodo
                    {
                        actual.atras.siguiente = null;
                    }
                }
                actual = null;
            }//fin del while
        }

        public void visualizar()
        {
            Nodo n;
            n = cabeza;
            while (n != null)
            {
                Console.WriteLine(n.dato + "\n");
                n = n.siguiente;
            }
        }
    }
}
