using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.DAO
{
    class Multimedia
    {
        int id;
        string nombre { get; set; }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int getId()
        {
            return this.id;
        }
        public string getNombre()
        {
            return this.nombre;
        }
    }
}
