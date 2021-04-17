using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.listaDoble
{
    class random
    {
        public random(int dato)
        {
        }

        public int aleatorio(int dato)
        {
            Random rd = new Random();
            rd = new Random(dato);

            return dato;
        }
    }
}
