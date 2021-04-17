using REPRODUCTOR_LEXOR.Formularios;
using REPRODUCTOR_LEXOR.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_LEXOR
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAsistente());
            // Application.Run(new Menu());
            //Application.Run(new Reproductor());
            new ConexionDbSQL();
            Application.Run(new frmReproductor());

            
            
        }


    }
}