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
        public Nodo cabeza; //se cambio de protected a public

        //constructor

        public clsListaDoble()
        {
            cabeza = null;
        }

        public clsListaDoble insertarCabezaLista(int entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return this;
        }

        public clsListaDoble insertaDespues(Nodo anterior, int entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;
            if (anterior.adelante != null)
            {
                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }

        public void eliminar(int entrada)
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;
            //ciclo de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato == entrada); //con estring la comparacion == se cambia a equals
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }//enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                //distinguir entre nodo cabecera del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                    else if (actual.adelante != null)
                    { //no es el ultimo nodo si la condicion se cumple
                        actual.atras.adelante = actual.adelante;
                        actual.adelante.atras = actual.atras;
                    }
                    else //sino es el ultimo nodo
                    {
                        actual.atras.adelante = null;
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
                n = n.adelante;
            }
        }
    }
}
