using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_LEXOR.DAO
{
    class playListDB
    {
        string nombrePista { get; set; }
        string nombreLista { get; set; }

        public void setNombrePista(string pista)
        {
            this.nombrePista = pista;
        }
        public void setNombreLista(string lista)
        {
            this.nombreLista = lista;
        }
        public string getNombrePista()
        {
            return this.nombrePista;
        }
        public string getNombreLista()
        {
            return this.getNombreLista();
        }
    }
}
