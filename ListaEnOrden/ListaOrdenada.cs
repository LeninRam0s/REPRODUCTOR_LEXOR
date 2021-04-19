using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPRODUCTOR_LEXOR.ListaEstruc;

namespace REPRODUCTOR_LEXOR.ListaEnOrden
{
    class ListaOrdenada : Lista
    {
        public ListaOrdenada() : base()
        {

        }

        public ListaOrdenada listaOrden(int entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                //busca el nodo anterior a partir de aca
                //se ejecuta la insercion

                Nodo anterior, p;
                anterior = p = primero;
                while ((p.getEnlace() != null) && (entrada > p.getDato()))
                {
                    anterior = p;
                    p = p.getEnlace();
                }
                if (entrada > p.getDato())
                {
                    anterior = p;
                }
                nuevo.setEnlace(anterior.getEnlace());
                anterior.setEnlace(nuevo);
            }
            return this;
        }
    }
}
