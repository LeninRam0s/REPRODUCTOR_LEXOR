
using REPRODUCTOR_LEXOR.Clases;
using System;
using System.Windows.Forms;

namespace REPRODUCTOR_LEXOR
{       
      public partial class Menu : Reproductor
      {
        public Menu()
        {
            InitializeComponent();
        }
           // ClsCarroBase carro = new ClsCarroBase("FOR MUNSTANG PRICES", "GRIS", 2020);
           // ClsMoto Moto = new ClsMoto("HONDA CRF 250", "BLANCO Y ROJO", 2017); 
           // ClsPickUp Picop = new ClsPickUp("CHEVROLET SILVERADO", "BLANCO", 2019);
           // ClsGT Sedan = new ClsGT("HONDA CRF 250", "BLANCO Y ROJO", 2017);
           // private int tipo_carro = 0;
          //  string tipo;
          //  bool seleccion = false;//borrar

            private void Radio_Click(object sender, EventArgs e)
        {
            Form Formulario = new Reproductor();
            Formulario.Show();
        } //llama la radio desde un boton

        private void Encendido_Click(object sender, EventArgs e)
        {
           //pendiente
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}