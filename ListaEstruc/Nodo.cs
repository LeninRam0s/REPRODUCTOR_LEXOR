using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.ListaEstruc
{
    class Nodo
    {
        public int dato;
        public Nodo enlace;

        public Nodo(int x)
        {
            dato = x;
            enlace = null;
        }

        public Nodo(int x, Nodo n)
        {
            dato = x;
            enlace = n;
        }

        public int getDato()
        {
            return dato;
        }

        public Nodo getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }

    }//fin clase nodo
}
