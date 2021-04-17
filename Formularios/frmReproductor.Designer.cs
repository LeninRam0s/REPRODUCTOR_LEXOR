
namespace REPRODUCTOR_LEXOR.Formularios
{
    partial class frmReproductor
    {/// <summary>
     /// Variable del diseñador necesaria.
     /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.LstCanciones = new System.Windows.Forms.ListBox();
            this.BarrAvance = new XComponent.SliderBar.MACTrackBar();
            this.BarVolumen = new XComponent.SliderBar.MACTrackBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelReprod = new System.Windows.Forms.Label();
            this.labelAgg = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelListas = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelAgregarAPlaylist = new System.Windows.Forms.Label();
            this.btnRepetirLista = new System.Windows.Forms.PictureBox();
            this.btnAgregarCancionesPlaylist = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnFormListas = new System.Windows.Forms.PictureBox();
            this.btnAleatorio = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.PictureBox();
            this.btnSiguinete = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.PictureBox();
            this.Agg = new System.Windows.Forms.PictureBox();
            this.ReproductorWMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepetirLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCancionesPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormListas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguinete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // LstCanciones
            // 
            this.LstCanciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstCanciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstCanciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstCanciones.ForeColor = System.Drawing.SystemColors.Window;
            this.LstCanciones.FormattingEnabled = true;
            this.LstCanciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LstCanciones.ItemHeight = 14;
            this.LstCanciones.Location = new System.Drawing.Point(12, 111);
            this.LstCanciones.Name = "LstCanciones";
            this.LstCanciones.Size = new System.Drawing.Size(319, 464);
            this.LstCanciones.TabIndex = 1;
            this.LstCanciones.SelectedValueChanged += new System.EventHandler(this.LstCanciones_SelectedIndexChanged);
            this.LstCanciones.SystemColorsChanged += new System.EventHandler(this.LstCanciones_SelectedIndexChanged);
            // 
            // BarrAvance
            // 
            this.BarrAvance.BackColor = System.Drawing.Color.Transparent;
            this.BarrAvance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BarrAvance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarrAvance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.BarrAvance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BarrAvance.IndentHeight = 6;
            this.BarrAvance.Location = new System.Drawing.Point(340, 659);
            this.BarrAvance.Maximum = 10;
            this.BarrAvance.Minimum = 0;
            this.BarrAvance.Name = "BarrAvance";
            this.BarrAvance.Size = new System.Drawing.Size(478, 20);
            this.BarrAvance.TabIndex = 3;
            this.BarrAvance.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.BarrAvance.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.BarrAvance.TickHeight = 4;
            this.BarrAvance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarrAvance.TrackerColor = System.Drawing.Color.Black;
            this.BarrAvance.TrackerSize = new System.Drawing.Size(8, 8);
            this.BarrAvance.TrackLineColor = System.Drawing.Color.Silver;
            this.BarrAvance.TrackLineHeight = 3;
            this.BarrAvance.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarrAvance.Value = 0;
            // 
            // BarVolumen
            // 
            this.BarVolumen.BackColor = System.Drawing.Color.Transparent;
            this.BarVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BarVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.BarVolumen.IndentHeight = 6;
            this.BarVolumen.Location = new System.Drawing.Point(959, 659);
            this.BarVolumen.Maximum = 100;
            this.BarVolumen.Minimum = 0;
            this.BarVolumen.Name = "BarVolumen";
            this.BarVolumen.Size = new System.Drawing.Size(137, 20);
            this.BarVolumen.TabIndex = 4;
            this.BarVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.BarVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.BarVolumen.TickHeight = 4;
            this.BarVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BarVolumen.TrackerColor = System.Drawing.Color.Black;
            this.BarVolumen.TrackerSize = new System.Drawing.Size(8, 8);
            this.BarVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BarVolumen.TrackLineHeight = 3;
            this.BarVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarVolumen.Value = 0;
            this.BarVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.BarVolumen_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label1.Location = new System.Drawing.Point(9, 674);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 15);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Nombre de la Pista";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelReprod
            // 
            this.labelReprod.AutoSize = true;
            this.labelReprod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReprod.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.labelReprod.Location = new System.Drawing.Point(12, 89);
            this.labelReprod.Name = "labelReprod";
            this.labelReprod.Size = new System.Drawing.Size(182, 19);
            this.labelReprod.TabIndex = 12;
            this.labelReprod.Text = "Lista de Reproduccion";
            // 
            // labelAgg
            // 
            this.labelAgg.AutoSize = true;
            this.labelAgg.BackColor = System.Drawing.Color.Transparent;
            this.labelAgg.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgg.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelAgg.Location = new System.Drawing.Point(270, 61);
            this.labelAgg.Name = "labelAgg";
            this.labelAgg.Size = new System.Drawing.Size(67, 15);
            this.labelAgg.TabIndex = 13;
            this.labelAgg.Text = "Agregar Pistas";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLogo.Location = new System.Drawing.Point(4, 18);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(136, 41);
            this.labelLogo.TabIndex = 14;
            this.labelLogo.Text = "LEXOR";
            // 
            // labelListas
            // 
            this.labelListas.AutoSize = true;
            this.labelListas.BackColor = System.Drawing.Color.Transparent;
            this.labelListas.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListas.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelListas.Location = new System.Drawing.Point(217, 61);
            this.labelListas.Name = "labelListas";
            this.labelListas.Size = new System.Drawing.Size(31, 15);
            this.labelListas.TabIndex = 16;
            this.labelListas.Text = "Listas";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbum.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelAlbum.Location = new System.Drawing.Point(9, 689);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(38, 15);
            this.labelAlbum.TabIndex = 18;
            this.labelAlbum.Text = "Album";
            // 
            // labelAgregarAPlaylist
            // 
            this.labelAgregarAPlaylist.AutoSize = true;
            this.labelAgregarAPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.labelAgregarAPlaylist.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarAPlaylist.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelAgregarAPlaylist.Location = new System.Drawing.Point(137, 61);
            this.labelAgregarAPlaylist.Name = "labelAgregarAPlaylist";
            this.labelAgregarAPlaylist.Size = new System.Drawing.Size(69, 15);
            this.labelAgregarAPlaylist.TabIndex = 20;
            this.labelAgregarAPlaylist.Text = "Agregar a Lista";
            // 
            // btnRepetirLista
            // 
            this.btnRepetirLista.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.replay;
            this.btnRepetirLista.Location = new System.Drawing.Point(358, 616);
            this.btnRepetirLista.Name = "btnRepetirLista";
            this.btnRepetirLista.Size = new System.Drawing.Size(37, 37);
            this.btnRepetirLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRepetirLista.TabIndex = 21;
            this.btnRepetirLista.TabStop = false;
            // 
            // btnAgregarCancionesPlaylist
            // 
            this.btnAgregarCancionesPlaylist.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.plus1;
            this.btnAgregarCancionesPlaylist.Location = new System.Drawing.Point(150, 7);
            this.btnAgregarCancionesPlaylist.Name = "btnAgregarCancionesPlaylist";
            this.btnAgregarCancionesPlaylist.Size = new System.Drawing.Size(50, 50);
            this.btnAgregarCancionesPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregarCancionesPlaylist.TabIndex = 19;
            this.btnAgregarCancionesPlaylist.TabStop = false;
            this.btnAgregarCancionesPlaylist.Click += new System.EventHandler(this.btnAgregarCancionesPlaylist_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(337, 572);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1042, 38);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // btnFormListas
            // 
            this.btnFormListas.BackColor = System.Drawing.Color.Transparent;
            this.btnFormListas.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.list;
            this.btnFormListas.Location = new System.Drawing.Point(207, 8);
            this.btnFormListas.Name = "btnFormListas";
            this.btnFormListas.Size = new System.Drawing.Size(50, 50);
            this.btnFormListas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFormListas.TabIndex = 15;
            this.btnFormListas.TabStop = false;
            this.btnFormListas.Click += new System.EventHandler(this.btnFormListas_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.aleatorio_btn;
            this.btnAleatorio.Location = new System.Drawing.Point(421, 616);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(37, 37);
            this.btnAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAleatorio.TabIndex = 11;
            this.btnAleatorio.TabStop = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.stop;
            this.BtnStop.Location = new System.Drawing.Point(638, 616);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(37, 37);
            this.BtnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnStop.TabIndex = 9;
            this.BtnStop.TabStop = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.volume_1;
            this.pictureBox4.Location = new System.Drawing.Point(933, 659);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.play_button;
            this.BtnPlay.Location = new System.Drawing.Point(567, 616);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(37, 37);
            this.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPlay.TabIndex = 7;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnSiguinete
            // 
            this.btnSiguinete.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.next_1;
            this.btnSiguinete.Location = new System.Drawing.Point(706, 616);
            this.btnSiguinete.Name = "btnSiguinete";
            this.btnSiguinete.Size = new System.Drawing.Size(37, 37);
            this.btnSiguinete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSiguinete.TabIndex = 6;
            this.btnSiguinete.TabStop = false;
            this.btnSiguinete.Click += new System.EventHandler(this.btnSiguinete_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.back_1;
            this.btnAnterior.Location = new System.Drawing.Point(494, 616);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(37, 37);
            this.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.TabStop = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Agg
            // 
            this.Agg.BackColor = System.Drawing.Color.Transparent;
            this.Agg.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.Agg;
            this.Agg.Location = new System.Drawing.Point(278, 9);
            this.Agg.Name = "Agg";
            this.Agg.Size = new System.Drawing.Size(49, 50);
            this.Agg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agg.TabIndex = 2;
            this.Agg.TabStop = false;
            this.Agg.Click += new System.EventHandler(this.Agg_Click);
            // 
            // ReproductorWMP
            // 
            this.ReproductorWMP.Enabled = true;
            this.ReproductorWMP.Location = new System.Drawing.Point(339, 0);
            this.ReproductorWMP.Name = "ReproductorWMP";
            this.ReproductorWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorWMP.OcxState")));
            this.ReproductorWMP.Size = new System.Drawing.Size(1027, 603);
            this.ReproductorWMP.TabIndex = 0;
            this.ReproductorWMP.UseWaitCursor = true;
            this.ReproductorWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.ReproductorWMP_PlayStateChange);
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1366, 713);
            this.Controls.Add(this.btnRepetirLista);
            this.Controls.Add(this.labelAgregarAPlaylist);
            this.Controls.Add(this.btnAgregarCancionesPlaylist);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelListas);
            this.Controls.Add(this.btnFormListas);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelAgg);
            this.Controls.Add(this.labelReprod);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.btnSiguinete);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.BarVolumen);
            this.Controls.Add(this.BarrAvance);
            this.Controls.Add(this.Agg);
            this.Controls.Add(this.LstCanciones);
            this.Controls.Add(this.ReproductorWMP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReproductor";
            this.Text = "Reproductor Lexor";
            this.Load += new System.EventHandler(this.frmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRepetirLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarCancionesPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFormListas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSiguinete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Agg;
        private XComponent.SliderBar.MACTrackBar BarrAvance;
        private XComponent.SliderBar.MACTrackBar BarVolumen;
        private System.Windows.Forms.PictureBox btnAnterior;
        private System.Windows.Forms.PictureBox btnSiguinete;
        private System.Windows.Forms.PictureBox BtnPlay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox BtnStop;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox btnAleatorio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelReprod;
        private System.Windows.Forms.Label labelAgg;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox btnFormListas;
        private System.Windows.Forms.Label labelListas;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.PictureBox btnAgregarCancionesPlaylist;
        private System.Windows.Forms.Label labelAgregarAPlaylist;
        public System.Windows.Forms.ListBox LstCanciones;
        public AxWMPLib.AxWindowsMediaPlayer ReproductorWMP;
        private System.Windows.Forms.PictureBox btnRepetirLista;
    }
}