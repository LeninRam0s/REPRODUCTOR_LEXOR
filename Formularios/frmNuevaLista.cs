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
    public partial class frmNuevaLista : Form
    {
        public frmNuevaLista()
        {
            InitializeComponent();

        }

 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();
            media.guardarLista(txtNombreNuevaLista.Text);
            MessageBox.Show("Lista: "+txtNombreNuevaLista.Text+" Creada con Exito!");
            this.Close();
        }
    }
}
