using REPRODUCTOR_LEXOR.ListaCircularEjemplos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_LEXOR.Formularios
{
    public partial class frmListas : Form
    {
        //propiedades de la clase

        Form formNuevaLista = new frmNuevaLista();
        string cancion;

        public frmListas(string cancion)
        {
            InitializeComponent();
            this.cancion = cancion;
        }

        public frmListas()
        {
            InitializeComponent();
        }

        private void btnFormNuevaLista_Click(object sender, EventArgs e)
        {
            //AddOwnedForm(formNuevaLista); 
            formNuevaLista.Show();
            this.Close();
        }

        private void frmListas_Load(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();

            foreach (var cancion in media.todasLasListas())
            {
                listBoxReproduccion.Items.Add(cancion);
            }
        }

        private void btnAgregarAListaActual_Click(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();
            media.insertarPlaylist(listBoxReproduccion.SelectedItem.ToString(), cancion);
            this.Close();
        }

        private void btnReproducirLista_Click(object sender, EventArgs e)
        {
            ListaCircular listaCircular = new ListaCircular();

            frmReproductor reproductor = Owner as frmReproductor;
            reproductor.LstCanciones.Items.Clear();
            //reproductor.ReproductorWMP.Ctlcontrols.stop();

            TodoSobreMultimedia media = new TodoSobreMultimedia();

            int i = 0;
            foreach (var cancion in media.reproducirPlaylist(listBoxReproduccion.SelectedItem.ToString()).traerArreglo()) //
            {
                reproductor.LstCanciones.Items.Add(cancion);
                i++;
            }

            reproductor.Ruta = new string[i];
            reproductor.Ruta = media.reproducirPlaylist(listBoxReproduccion.SelectedItem.ToString()).traerArreglo();

            //reproductor.LstCanciones.SelectedIndex = 0;

            reproductor.ReproductorWMP.URL = reproductor.Ruta[0];


            this.Close();
        }


    }
}
