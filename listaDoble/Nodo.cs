using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class Nodo
    {
        public string dato;
        public Nodo siguiente;
        public Nodo atras;

        public string getDato()
        {
            return dato;
        }

        //constructor

        public Nodo(string multimedia)
        {
            dato = multimedia;
            siguiente = atras = null;
        }
    }
}
