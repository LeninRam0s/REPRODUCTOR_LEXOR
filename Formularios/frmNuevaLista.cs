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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevaLista_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarALista_Click(object sender, EventArgs e)
        {
            TodoSobreMultimedia media = new TodoSobreMultimedia();
            media.guardarLista(txtNombreNuevaLista.Text);
            this.Close();
        }
    }
}
