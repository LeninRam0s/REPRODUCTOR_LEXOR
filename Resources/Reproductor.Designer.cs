namespace REPRODUCTOR_LEXOR
{
    partial class Reproductor
    {
        /// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.ReproductorWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.LstCanciones = new System.Windows.Forms.ListBox();
            this.BarrAvance = new XComponent.SliderBar.MACTrackBar();
            this.BarVolumen = new XComponent.SliderBar.MACTrackBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnAleatorio = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Agg = new System.Windows.Forms.PictureBox();
            this.Power = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorWMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.SuspendLayout();
            // 
            // ReproductorWMP
            // 
            this.ReproductorWMP.Enabled = true;
            this.ReproductorWMP.Location = new System.Drawing.Point(12, 453);
            this.ReproductorWMP.Name = "ReproductorWMP";
            this.ReproductorWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorWMP.OcxState")));
            this.ReproductorWMP.Size = new System.Drawing.Size(304, 69);
            this.ReproductorWMP.TabIndex = 0;
            this.ReproductorWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.ReproductorWMP_PlayStateChange);
            // 
            // LstCanciones
            // 
            this.LstCanciones.BackColor = System.Drawing.Color.DarkGray;
            this.LstCanciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstCanciones.FormattingEnabled = true;
            this.LstCanciones.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LstCanciones.Location = new System.Drawing.Point(12, 174);
            this.LstCanciones.Name = "LstCanciones";
            this.LstCanciones.Size = new System.Drawing.Size(304, 249);
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
            this.BarrAvance.IndentHeight = 6;
            this.BarrAvance.Location = new System.Drawing.Point(12, 148);
            this.BarrAvance.Maximum = 10;
            this.BarrAvance.Minimum = 0;
            this.BarrAvance.Name = "BarrAvance";
            this.BarrAvance.Size = new System.Drawing.Size(278, 20);
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
            this.BarVolumen.Location = new System.Drawing.Point(296, 51);
            this.BarVolumen.Maximum = 100;
            this.BarVolumen.Minimum = 0;
            this.BarVolumen.Name = "BarVolumen";
            this.BarVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BarVolumen.Size = new System.Drawing.Size(20, 75);
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
            this.Label1.Location = new System.Drawing.Point(22, 138);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(13, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnAleatorio
            // 
            this.BtnAleatorio.Location = new System.Drawing.Point(396, 32);
            this.BtnAleatorio.Name = "BtnAleatorio";
            this.BtnAleatorio.Size = new System.Drawing.Size(111, 23);
            this.BtnAleatorio.TabIndex = 12;
            this.BtnAleatorio.Text = "Generar Aleatorio";
            this.BtnAleatorio.UseVisualStyleBackColor = true;
            this.BtnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.AleatorioBnt_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.stop;
            this.BtnStop.Location = new System.Drawing.Point(85, 89);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(37, 37);
            this.BtnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnStop.TabIndex = 9;
            this.BtnStop.TabStop = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(296, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.play_button;
            this.BtnPlay.Location = new System.Drawing.Point(191, 89);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(37, 37);
            this.BtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnPlay.TabIndex = 7;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.next_1;
            this.pictureBox2.Location = new System.Drawing.Point(248, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.back_1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Agg
            // 
            this.Agg.BackColor = System.Drawing.Color.Transparent;
            this.Agg.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.Agg;
            this.Agg.Location = new System.Drawing.Point(140, 12);
            this.Agg.Name = "Agg";
            this.Agg.Size = new System.Drawing.Size(49, 50);
            this.Agg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agg.TabIndex = 2;
            this.Agg.TabStop = false;
            this.Agg.Click += new System.EventHandler(this.Agg_Click);
            // 
            // Power
            // 
            this.Power.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.power;
            this.Power.Location = new System.Drawing.Point(25, 12);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(50, 50);
            this.Power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Power.TabIndex = 13;
            this.Power.TabStop = false;
            this.Power.Visible = false;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(329, 433);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.BtnAleatorio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarVolumen);
            this.Controls.Add(this.BarrAvance);
            this.Controls.Add(this.Agg);
            this.Controls.Add(this.LstCanciones);
            this.Controls.Add(this.ReproductorWMP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Reproductor";
            this.Text = "Reproductor Lexor";
            this.Load += new System.EventHandler(this.Reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorWMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ReproductorWMP;
        private System.Windows.Forms.ListBox LstCanciones;
        private System.Windows.Forms.PictureBox Agg;
        private XComponent.SliderBar.MACTrackBar BarrAvance;
        private XComponent.SliderBar.MACTrackBar BarVolumen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnPlay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox BtnStop;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnAleatorio;
        private System.Windows.Forms.PictureBox Power;
    }
}

