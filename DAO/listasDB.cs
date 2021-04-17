using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.DAO
{
    class listasDB
    {
        string nombre { get; set; }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        
        public string getNombre()
        {
            return this.nombre;
        }
    }
}
