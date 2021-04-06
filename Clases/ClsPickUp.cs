using PROYECTO_DE_CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.Clases
{
    class ClsPickUp : ClsCarroBase
    {
        public ClsPickUp(string marcaCarro, string ColorCarro, int yearCreate, int VelMAX) : base(marcaCarro, ColorCarro, yearCreate, VelMAX)
        {
            marca = marcaCarro;
            Color = ColorCarro;
            añoCreación = yearCreate;
            VelocidadMaxima = VelMAX;
        }
    }
}