using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.Clases
{
    class ClsReproductor
    {
        public int ReproductorA(int rango)
        {
            Random ramdon = new Random();
            int aleatorio = ramdon.Next(rango);
            return aleatorio;
        }
    }
}
