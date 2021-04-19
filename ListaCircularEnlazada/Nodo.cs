using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.ListaCircularEnlazada
{
    class Nodo
    {
        public string dato;
        public Nodo enlace;

        public Nodo(string entrada)
        {
            dato.Equals(entrada);
            enlace = this;// se apunta asímismo
        }
    }
}
