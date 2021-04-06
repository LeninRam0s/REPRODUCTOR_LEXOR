using PROYECTO_DE_CLASES;
using REPRODUCTOR_LEXOR.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_LEXOR
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        ClsCarroBase GT = new ClsCarroBase("Dog", "Gris", 2020, 310); //creamos el vehiculo

        private void btnArranqueClick(object sender, EventArgs e)
        {
            switch (GT.Arranque) //VALIDAR EL ARRANQIE
            {
                case false:
                    GT.Arranque = true;
                    btn_Arranque.Image = Properties.Resources.Power_ButtonON1;
                    txtEstatus.Text = "Encendido";
                    txtData.Text = GT.GetDatos();
                    break;

                case true:
                    GT.Arranque = false;
                    btn_Arranque.Image = Properties.Resources.Power_ButtonOFF1;
                    txtEstatus.Text = "Apagado";
                    txtData.Text = "";
                    txtVMAX.Text = "";
                    GT.frenar();
                    txtVelocidad.Text = GT.obtenerVelocidad().ToString();                                      
                    break;
            }
        } 

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (GT.Arranque == true) //VALIDACION DE ENCENDIDO
            {
                GT.acelerar();
                int velocidad = GT.obtenerVelocidad();
                int VelMAX = GT.VelocidadMax();
                txtVelocidad.Text = velocidad.ToString();
                if (velocidad == VelMAX) //SE VALIDA LA VELOCIDAD
                {
                    txtVMAX.Text = "Usted ha llegado a la Velocidad Maxima!!!";
                }
            }
            else
            {
                 MessageBox.Show("El vehiculo esta Apagado!!");
                txtVMAX.Text = "";
            }
        }
        private void btnFreno_Click(object sender, EventArgs e)
        {
            if (GT.Arranque == true)
            {
                GT.frenar();
                txtVMAX.Text = "";
                txtVelocidad.Text = GT.obtenerVelocidad().ToString();
            }
            else
            {
                MessageBox.Show("El vehiculo se encuentra apagado");
            }
        }

        private void Radio_Click(object sender, EventArgs e)
        {           
            if (GT.Arranque == true)
            {
                Form Formulario = new Reproductor();
                Formulario.Show();              
            }
            else 
            {
                MessageBox.Show("Debe encender el vehiculo para poder usar la radio");
            }
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            FrmAsistente Asistente = new FrmAsistente(); 
            this.Hide();
            Asistente.ShowDialog();          
            this.Close();
        }    
    }
}