using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.ListaCircularExamples
{
    class Nodo
    {
        public String dato;
        public Nodo enlace;
        public Nodo(String entrada)
        {
            dato = entrada;
            enlace = this;// se apunta asímismo
        }
    }//este nodo trabaja con string en el dato
}
