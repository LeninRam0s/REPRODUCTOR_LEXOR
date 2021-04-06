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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        ClsPickUp carro = new ClsPickUp("Chevrolet", "Blanco", 2019, 100); //creamos el vehiculo       

        private void btnArranqueClick(object sender, EventArgs e)
        {
            switch (carro.Arranque) //VALIDAR EL ARRANQIE
            {
                case false:
                    carro.Arranque = true;
                    btn_Arranque.Image = Properties.Resources.Power_ButtonON1;
                    txtEstatus.Text = "Encendido";
                    txtData.Text = carro.GetDatos();
                    break;

                case true:
                    btn_Arranque.Image = Properties.Resources.Power_ButtonOFF1;
                    txtEstatus.Text = "Apagado";
                    txtData.Text = "";
                    txtVMAX.Text = "";
                    carro.frenar();
                    txtVelocidad.Text = carro.obtenerVelocidad().ToString();
                    carro.Arranque = false;
                    break;
            }
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            if (carro.Arranque == true) //VALIDACION DE ENCENDIDO
            {
                carro.acelerar();
                int velocidad = carro.obtenerVelocidad();
                txtVelocidad.Text = velocidad.ToString();
                int VMAX = carro.VelocidadMax();

                if (velocidad == VMAX) //SE VALIDA LA VELOCIDAD
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
            if (carro.Arranque == true)
            {
                carro.frenar();
                txtVMAX.Text = "";
                txtVelocidad.Text = carro.obtenerVelocidad().ToString();
            }
            else
            {
                MessageBox.Show("El vehiculo se encuentra apagado");
            }
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            if (carro.Arranque == true)
            {
                Form Formulario = new Reproductor();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Debe endender el vehiculo para poder usar la radio");
            }
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            FrmAsistente Asistente = new FrmAsistente();
            Reproductor Rep = new Reproductor();
            Rep.Close();
            this.Hide();
            Asistente.ShowDialog();
            this.Close();
        }
    }
}