using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.DAO
{
    class MultimediaDB
    {
        string nombreArchivo { get; set; }

        public void setNombreArchivo(string nombreFichero)
        {
            this.nombreArchivo = nombreFichero;
        }
        public string getNombreArchivo()
        {
            return this.nombreArchivo;
        }
    }
}
