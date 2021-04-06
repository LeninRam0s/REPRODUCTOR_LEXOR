using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_DE_CLASES
{
    public class ClsCarroBase
    {
        public bool Arranque = false;
        protected String marca = "";
        protected String Color = "";
        protected int añoCreación = 1900; //VALOR DE REFERENCIA
        protected int VelocidadMaxima = 300;//VALOR DE REFERENCIA
        protected int velocidad = 0;

        public ClsCarroBase(String marcaCarro, String ColorCarro, int yearCreate, int VelMAX)//constructor
        {
            marca = marcaCarro;
            Color = ColorCarro;
            añoCreación = yearCreate;
            VelocidadMaxima = VelMAX;
        }

        public void acelerar()
        {
            if (Arranque == true)
            {
                if (velocidad < VelocidadMaxima)
                {
                    velocidad += 10;
                }
            }
        }

        public int VelocidadMax()
        {
            return VelocidadMaxima;
        }
        public int obtenerVelocidad()
        {
            return velocidad;
        }
      
        public void frenar()
        {
            velocidad = 0;
        }

        public String GetDatos()
        {
            String datosCarro = "Marca: " + marca + "\nColor: " + Color + "\nModelo: " + añoCreación + "\nVelMax: " + VelocidadMaxima+" Km/h";
            return datosCarro;
        }
    }
}