using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class IteradorLista
    {
        public IteradorLista(clsListaDoble listaDoble)
        {
        }

        private Nodo actual;

        public void IteratorLista(clsListaDoble id)
        {
            actual = id.cabeza;

        }
        public Nodo siguiente()
        {
            Nodo a;
            a = actual;
            if (actual != null)
            {
                actual = actual.adelante;
            }
            return a;
        }
    }
}
