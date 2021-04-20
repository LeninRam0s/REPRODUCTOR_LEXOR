using REPRODUCTOR_LEXOR.CapaDatos;
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
            new ConexionDbSQL();
            Application.Run(new frmReproductor());






        }


    }
}