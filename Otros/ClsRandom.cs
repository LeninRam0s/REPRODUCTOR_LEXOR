using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.Clases
{
    class ClsRandom
    {
        //Constructor
        private int vMIN = 0;  //PRIVATE SOLO ES ACCESIBLE EN EL OBJETO DONDE ESTE
        private int vMAX = 0;
        //private string NOMBRE;

        //CONSTRUCTOR
        public ClsRandom(int MIN, int MAX)
        {
            vMIN = MIN;
            vMAX = MAX;
        }

        public int GenerarRandom()
        {
            Random Aleatorio = new Random();
            int Respuesta = Aleatorio.Next(vMIN, vMAX);
            return Respuesta; ;
        }

       
    }
}
