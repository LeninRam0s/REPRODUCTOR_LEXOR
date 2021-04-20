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
            formNuevaLista.Show();
            this.Close();
        }//FRM PARA NUEVA LISTA

        private void frmListas_Load(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();

            foreach (var cancion in media.todasLasListas())
            {
                listBoxReproduccion.Items.Add(cancion);
            }
        }//CARGA LAS LISTAS AL ABRIR EL FRM

        private void btnAgregarAListaActual_Click(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();

            if (cancion != null)
            {
                media.insertarAPlaylist(listBoxReproduccion.SelectedItem.ToString(), cancion);
                MessageBox.Show("Pista Agregada");
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado la pista!");
                this.Close();
            }
        }//AGG CANCION A LISTA

        private void btnReproducirLista_Click(object sender, EventArgs e)
        {
            frmReproductor reproductor = Owner as frmReproductor;
            reproductor.LstCanciones.Items.Clear();
            reproductor.ReproductorWMP.Ctlcontrols.stop();

            TodoSobreMultimedia media = new TodoSobreMultimedia();
            if(reproductor.LstCanciones!=null)
            {
                int i = 0;
                foreach (var cancion in media.reproducirPlaylist(listBoxReproduccion.SelectedItem.ToString()).mostrarAZ()) //
                {
                    reproductor.LstCanciones.Items.Add(cancion);
                    i++;
                }
                reproductor.Ruta = new string[i];
                reproductor.Ruta = media.reproducirPlaylist(listBoxReproduccion.SelectedItem.ToString()).mostrarAZ();
            }
            else
            {
                MessageBox.Show("Lista Vacia");
                this.btnReproducirLista.Dispose();
                this.Close();
            }
            this.Close();
        }//REPRODUCIR LISTA

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            //validar cuando no hayan pistas seleccionadas
            String nombrelista = listBoxReproduccion.SelectedItem.ToString();
            TodoSobreMultimedia media = new TodoSobreMultimedia();
            media.eliminarLista(nombrelista);
            MessageBox.Show(nombrelista + " Eliminada");
            this.Update();
        }//ELIMINAR LISTA

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            new frmNuevaLista();
            this.Refresh();
        }//REFRESCAR
    }
}
