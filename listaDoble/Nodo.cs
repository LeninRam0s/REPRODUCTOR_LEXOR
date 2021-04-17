using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class Nodo
    {
        public int dato;
        public Nodo adelante;
        public Nodo atras;

        public int getDato()
        {
            return dato;
        }

        //constructor

        public Nodo(int entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }
    }
}
