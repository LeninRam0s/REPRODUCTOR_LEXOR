using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class IteradorLista
    {
        private Nodo actual;

        public IteradorLista(clsListaDoble listaDoble)
        {
        }

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
