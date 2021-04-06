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

namespace REPRODUCTOR_LEXOR
{
    public partial class Reproductor:Form 
    {
       // Reproductor rp = new Reproductor();
        bool Play = false;      
        string[] ArhivosMP3;
        string[] Ruta;
        
        ClsRandom azar = new ClsRandom(1, 5);

        public Reproductor()
        {
            InitializeComponent(); //inicializa el formulario
        }

        private void Agg_Click(object sender, EventArgs e)
        {            
            OpenFileDialog Busqueda = new OpenFileDialog
            {
                Multiselect = true //se pueden seleccionar multiples archivos simultaneos    
            }; 

          
            if (Busqueda.ShowDialog() == DialogResult.OK)
            {
                ArhivosMP3 = Busqueda.SafeFileNames;
                Ruta = Busqueda.FileNames;

                foreach (var PistaMP3 in ArhivosMP3)  
                {
                    LstCanciones.Items.Add(PistaMP3);
                }
            }//seleccion multiple y aceptar para agregar

            ReproductorWMP.URL = Ruta[0];//inicia en la posicion cero el arreglo
            LstCanciones.SelectedIndex = 0; //aca se establece q posicion se va a reproducir
            BtnPlay.Image = Properties.Resources.pause; //el boton se cambia de play a pausa dependiendo el caso


            
            

        } //agg archivos desde una ubicacion

        private void LstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {


            ReproductorWMP.URL = Ruta[LstCanciones.SelectedIndex];//reproduce el elemento seleccionado en la lst
            Label1.Text = ArhivosMP3[LstCanciones.SelectedIndex];//muestra la cancion que se reproduce  
        }

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
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            ReproductorWMP.Ctlcontrols.stop();
            BtnPlay.Image = Properties.Resources.play_button;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarAvance();
            BarrAvance.Value = (int)ReproductorWMP.Ctlcontrols.currentPosition;
            BarVolumen.Value = ReproductorWMP.settings.volume;
        }
        public void ActualizarAvance()
        {
            if (ReproductorWMP.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Controla el tiempo maximo de la pista en reprodducion
                BarrAvance.Maximum=(int)ReproductorWMP.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (ReproductorWMP.playState==WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop(); //para parar la actualizacion del tiempo recorrido de la pista
            }
            else if (ReproductorWMP.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop(); //reinica el avance de la pista hasta la pocicion inicial
                BarrAvance.Value = 0;
            }
        }
        private void ReproductorWMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarAvance();
        }

        private void BarVolumen_ValueChanged(object sender, decimal value)
        {
            ReproductorWMP.settings.volume = BarVolumen.Value;
        }

        private void BarrAvance_ValueChanged(object sender, decimal value)//sincronizar la barra de reproductor
        {
             ReproductorWMP.Ctlcontrols.currentPosition= BarrAvance.Value;           
        }
        private void pictureBox3_Click(object sender, EventArgs e) //NO TERMINADO
        {
            string Anterior="";
            ArhivosMP3[0]= Anterior;
           
            int Ann = Convert.ToInt32(Anterior);
            int Validacion=1;
           
            do
            {
                Random fortuito = new Random();
                int Aleatorio = fortuito.Next(ArhivosMP3.Length);
                if (Aleatorio!=Ann)
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

        } //era el aleatorio

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            //OTRO RANGO DIFERENTE AL INDICADO DEL 100 AL 200 COMO EJEMPLO
            ClsRandom azar = new ClsRandom(0, 200);
            MessageBox.Show(azar.GenerarRandom().ToString());
        }//NO TERMINADO
 
        public void AleatorioBnt_Click(object sender, EventArgs e)
            
        {
            //ClsRandom Aleatorio = new ClsRandom(0,ArhivosMP3.Length);
            ClsRandom Aleatorio = new ClsRandom(1, Ruta.Length);
           
            ReproductorWMP.URL = Aleatorio.GenerarRandom().ToString();
            //LstCanciones.SelectedIndex = Aleatorio;
            ReproductorWMP.Ctlcontrols.play();
            Play = true;
            ReproductorWMP.URL = Ruta[1];//reproduce el elemento seleccionado en la lst
            Label1.Text = ArhivosMP3[LstCanciones.SelectedIndex];//muestra la cancion que se reproduce
            //LstCanciones.SelectedIndex = ArhivosMP3[Aleatorio];
        }
        private void Power_Click(object sender, EventArgs e)
        {
            Ruta = Directory.GetFiles(@"C:\MUSIC", "*mp3*");

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
        }//pendiente         

        private void Reproductor_Load(object sender, EventArgs e)
        {
        }
    }
}
