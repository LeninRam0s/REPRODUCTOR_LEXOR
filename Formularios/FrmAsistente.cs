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
    public partial class FrmAsistente : Form
    {
        public FrmAsistente()
        {
            InitializeComponent();
        }

        private void btnGT_Click(object sender, EventArgs e)
        {
            Form2 GT = new Form2();
            this.Hide();
            GT.ShowDialog();
            this.Close();
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            Form3 PickUp = new Form3();
            this.Hide();
            PickUp.ShowDialog();
            this.Close();
        }

        private void btnMoto_Click(object sender, EventArgs e)
        {
            Form4 Moto = new Form4();
            this.Hide();
            Moto.ShowDialog();
            this.Close();
        }
    }
}
