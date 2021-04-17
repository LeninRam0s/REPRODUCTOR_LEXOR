using REPRODUCTOR_LEXOR.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using XComponent.SliderBar;
using AxWMPLib;
using WMPLib;
using REPRODUCTOR_LEXOR.CapaDatos;
using REPRODUCTOR_LEXOR.DAO;

namespace REPRODUCTOR_LEXOR.Formularios
{
    
    public partial class frmReproductor : Form
    {
        // Reproductor rp = new Reproductor();
        bool Play = false;
        public string[] ArhivosMP3;
        public string[] Ruta;

        TodoSobreMultimedia todoCancion = new TodoSobreMultimedia();
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void Agg_Click(object sender, EventArgs e)
        {
            LstCanciones.Items.Clear();
            OpenFileDialog Busqueda = new OpenFileDialog
            {
                Multiselect = true //se pueden seleccionar multiples archivos simultaneos    
            };
            TodoSobreMultimedia media = new TodoSobreMultimedia();
            List<MultimediaDB> lista;
            if (Busqueda.ShowDialog() == DialogResult.OK)
            {
                ArhivosMP3 = Busqueda.SafeFileNames;
                Ruta = Busqueda.FileNames;

                int i = 0;
                foreach (var PistaMP3 in ArhivosMP3)
                {
                    LstCanciones.Items.Add(PistaMP3);
                    if (media.exiteCancion(Ruta[i]) == false)
                    {
                        media.insertarCancion(Ruta[i]);
                    }
                    i++;
                }

               

            }//seleccion multiple y aceptar para agregar

            for (int i = 0; i < LstCanciones.Items.Count; i++)//  //LstCanciones.Items.Count
            {
                int j = 0;
                LstCanciones.SelectedIndex = j; //aca se establece q posicion se va a reproducir
                ReproductorWMP.URL = Ruta[j];//inicia en la posicion cero el arreglo
                BtnPlay.Image = Properties.Resources.pause; //el boton se cambia de play a pausa dependiendo el caso
                j++;
            }





        } //agg archivos desde una ubicacion

        private void LstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            ReproductorWMP.URL = Ruta[LstCanciones.SelectedIndex];//reproduce el elemento seleccionado en la lst
            //Label1.Text = ArhivosMP3[LstCanciones.SelectedIndex];//muestra la cancion que se reproduce  
        }//lista canciones seleccionadas

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            switch (Play) //evalua en que proceso esta y cambia los botones
            {
                case true:
                    ReproductorWMP.Ctlcontrols.pause();
                    BtnPlay.Image = Properties.Resources.play_button;
                    Play = false;
                    break;

                case false:
                    ReproductorWMP.Ctlcontrols.play();
                    BtnPlay.Image = Properties.Resources.pause;
                    Play = true;
                    break;
            }
        }//boton reproducir

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ReproductorWMP.Ctlcontrols.stop();
            BtnPlay.Image = Properties.Resources.play_button;
            Play = false;
        }//boton parar

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            ActualizarAvance();
            BarrAvance.Value = (int)ReproductorWMP.Ctlcontrols.currentPosition;
            BarVolumen.Value = ReproductorWMP.settings.volume;
        }//timer para barra avance y volumen

        public void ActualizarAvance()
        {
            if (ReproductorWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Controla el tiempo maximo de la pista en reprodducion
                BarrAvance.Maximum = (int)ReproductorWMP.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (ReproductorWMP.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop(); //para parar la actualizacion del tiempo recorrido de la pista
            }
            else if (ReproductorWMP.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop(); //reinica el avance de la pista hasta la pocicion inicial
                BarrAvance.Value = 0;
            }
        }//actualiza avance

        private void ReproductorWMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarAvance();
        }//metodo actualizar avance

        private void BarVolumen_ValueChanged(object sender, decimal value)
        {
            ReproductorWMP.settings.volume = BarVolumen.Value;
        }//Volumen actualizar

        private void BarrAvance_ValueChanged(object sender, decimal value)
        {
            ReproductorWMP.Ctlcontrols.currentPosition = BarrAvance.Value;
        }//sincronizar barra de reproductor

       /* private void btnAleatorio_Click(object sender, EventArgs e)
        {
            string Anterior = "";
            ArhivosMP3[0] = Anterior;

            int Ann = Convert.ToInt32(Anterior);
            int Validacion = 1;

            do
            {
                Random fortuito = new Random();
                int Aleatorio = fortuito.Next(ArhivosMP3.Length);
                if (Aleatorio != Ann)
                {
                    ReproductorWMP.URL = ArhivosMP3[Aleatorio];
                    Ann = Aleatorio;
                    Validacion = 1;
                }
                else
                {
                    Validacion = 0;
                }

            } while (Validacion == 0);

        } //era el aleatorio no sirve    */

        public void AleatorioBnt_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            int rd = Aleatorio.Next(1, LstCanciones.Items.Count);
            LstCanciones.SelectedIndex = rd;
            ReproductorWMP.Ctlcontrols.play();
            Play = true;
            ReproductorWMP.URL = Ruta[rd];//reproduce el elemento seleccionado en la lst
            Label1.Text = ArhivosMP3[rd];//muestra la cancion que se reproduce
        }//no sirve

        private void btnSiguinete_Click(object sender, EventArgs e)
        {
            ReproductorWMP.Ctlcontrols.next();
            ReproductorWMP.Ctlcontrols.play();
            Play = true;

            ReproductorWMP.URL = Ruta[LstCanciones.SelectedIndex];
            Label1.Text = ArhivosMP3[LstCanciones.SelectedIndex];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            ReproductorWMP.Ctlcontrols.previous();
            ReproductorWMP.URL = Ruta[LstCanciones.SelectedIndex];
            Label1.Text = ArhivosMP3[LstCanciones.SelectedIndex];
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();
            int rd = Aleatorio.Next(1, LstCanciones.Items.Count);
            LstCanciones.SelectedIndex = rd;
            ReproductorWMP.Ctlcontrols.play();
            Play = true;
            ReproductorWMP.URL = Ruta[rd];//reproduce el elemento seleccionado en la lst
            Label1.Text = ArhivosMP3[rd];//muestra la cancion que se reproduce
            //TODAVIA NO SIRVE ESTA MADRE

            

        }

        private void btnFormListas_Click(object sender, EventArgs e)
        {
            Form formListas = new frmListas();
            AddOwnedForm(formListas);
            //btnAgregarCancionesPlaylist.Dispose();
            formListas.Show();
        }


        private void btnAgregarCancionesPlaylist_Click(object sender, EventArgs e)
        {
            //validar cuando no hayan pistas seleccionadas
            string cancion = Ruta[LstCanciones.SelectedIndex];
            Form listasReproduccion = new frmListas(cancion);
            AddOwnedForm(listasReproduccion);
            listasReproduccion.Show();
        }








        /*  private void Power_Click(object sender, EventArgs e)
          {
              Ruta = Directory.GetFiles(@"E:\MUSIC", "*mp3*");

              switch (Play)
              {
                  case true:
                      Power.Image = Properties.Resources.power; //primer boton=cambio de boton
                      //label_encender.Text = "Apagar";
                      foreach (string cancion in Ruta)
                      {
                          LstCanciones.Items.Add(Path.GetFileName(cancion));
                      }
                      Random rand = new Random();
                      int al = rand.Next(Ruta.Length);
                      ReproductorWMP.URL = Ruta[al]; ;
                      LstCanciones.SelectedIndex = al;
                      BtnPlay.Image = Properties.Resources.pause;
                      Play = false;
                      break;

                  case false:
                      Power.Image = Properties.Resources.power;
                      //label_encender.Text = "Encender";
                      ReproductorWMP.Ctlcontrols.pause();
                      BtnPlay.Image = Properties.Resources.play_button;
                      foreach (string cancion in Ruta)
                      {
                          LstCanciones.Items.Remove(Path.GetFileName(cancion));
                      }
                      Play = true;
                      break;
              }
          }//pendiente      */


        /* private void LstCanciones_SelectedIndexChanged_1(object sender, EventArgs e)
         {
             ReproductorWMP.URL = Ruta[LstCanciones.SelectedIndex];
         }//la seleccion de la lista se reproduce
        */

    }
}
