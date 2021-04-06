namespace REPRODUCTOR_LEXOR
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtVelocidad = new System.Windows.Forms.Label();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.carroPNG = new System.Windows.Forms.PictureBox();
            this.btn_Arranque = new System.Windows.Forms.PictureBox();
            this.labelKm = new System.Windows.Forms.Label();
            this.btnFreno = new System.Windows.Forms.Button();
            this.btnMENU = new System.Windows.Forms.Button();
            this.txtEstatus = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.Label();
            this.txtVMAX = new System.Windows.Forms.Label();
            this.Radio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carroPNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Arranque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.AutoSize = true;
            this.txtVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocidad.ForeColor = System.Drawing.Color.Navy;
            this.txtVelocidad.Location = new System.Drawing.Point(20, 161);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(20, 24);
            this.txtVelocidad.TabIndex = 2;
            this.txtVelocidad.Text = "0";
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(305, 233);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(75, 63);
            this.btnAcelerar.TabIndex = 3;
            this.btnAcelerar.Text = "ACELERAR";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // carroPNG
            // 
            this.carroPNG.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.carro;
            this.carroPNG.Location = new System.Drawing.Point(12, 12);
            this.carroPNG.Name = "carroPNG";
            this.carroPNG.Size = new System.Drawing.Size(372, 148);
            this.carroPNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carroPNG.TabIndex = 4;
            this.carroPNG.TabStop = false;
            // 
            // btn_Arranque
            // 
            this.btn_Arranque.Image = global::REPRODUCTOR_LEXOR.Properties.Resources.Power_ButtonOFF1;
            this.btn_Arranque.Location = new System.Drawing.Point(407, 12);
            this.btn_Arranque.Name = "btn_Arranque";
            this.btn_Arranque.Size = new System.Drawing.Size(62, 62);
            this.btn_Arranque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Arranque.TabIndex = 0;
            this.btn_Arranque.TabStop = false;
            this.btn_Arranque.Click += new System.EventHandler(this.btnArranqueClick);
            // 
            // labelKm
            // 
            this.labelKm.AutoSize = true;
            this.labelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKm.ForeColor = System.Drawing.Color.Navy;
            this.labelKm.Location = new System.Drawing.Point(68, 163);
            this.labelKm.Name = "labelKm";
            this.labelKm.Size = new System.Drawing.Size(54, 24);
            this.labelKm.TabIndex = 5;
            this.labelKm.Text = "Km/h";
            this.labelKm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFreno
            // 
            this.btnFreno.Location = new System.Drawing.Point(224, 233);
            this.btnFreno.Name = "btnFreno";
            this.btnFreno.Size = new System.Drawing.Size(75, 63);
            this.btnFreno.TabIndex = 6;
            this.btnFreno.Text = "FRENAR";
            this.btnFreno.UseVisualStyleBackColor = true;
            this.btnFreno.Click += new System.EventHandler(this.btnFreno_Click);
            // 
            // btnMENU
            // 
            this.btnMENU.Location = new System.Drawing.Point(239, 189);
            this.btnMENU.Name = "btnMENU";
            this.btnMENU.Size = new System.Drawing.Size(117, 38);
            this.btnMENU.TabIndex = 7;
            this.btnMENU.Text = "MENU PRINCIPAL";
            this.btnMENU.UseVisualStyleBackColor = true;
            this.btnMENU.Click += new System.EventHandler(this.btnMENU_Click);
            // 
            // txtEstatus
            // 
            this.txtEstatus.AutoSize = true;
            this.txtEstatus.Location = new System.Drawing.Point(414, 78);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(50, 13);
            this.txtEstatus.TabIndex = 8;
            this.txtEstatus.Text = "Apagado";
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(404, 108);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(0, 13);
            this.txtData.TabIndex = 9;
            // 
            // txtVMAX
            // 
            this.txtVMAX.AutoSize = true;
            this.txtVMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVMAX.ForeColor = System.Drawing.Color.Maroon;
            this.txtVMAX.Location = new System.Drawing.Point(120, 167);
            this.txtVMAX.Name = "txtVMAX";
            this.txtVMAX.Size = new System.Drawing.Size(32, 17);
            this.txtVMAX.TabIndex = 10;
            this.txtVMAX.Text = "----";
            this.txtVMAX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Radio
            // 
            this.Radio.Image = ((System.Drawing.Image)(resources.GetObject("Radio.Image")));
            this.Radio.Location = new System.Drawing.Point(16, 208);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(70, 70);
            this.Radio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Radio.TabIndex = 11;
            this.Radio.TabStop = false;
            this.Radio.Click += new System.EventHandler(this.Radio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 311);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.txtVMAX);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.btnMENU);
            this.Controls.Add(this.btnFreno);
            this.Controls.Add(this.labelKm);
            this.Controls.Add(this.carroPNG);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.btn_Arranque);
            this.Name = "Form2";
            this.Text = "CHALLENGER SRT";
            ((System.ComponentModel.ISupportInitialize)(this.carroPNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Arranque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Arranque;
        private System.Windows.Forms.Label txtVelocidad;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.PictureBox carroPNG;
        private System.Windows.Forms.Label labelKm;
        private System.Windows.Forms.Button btnFreno;
        private System.Windows.Forms.Button btnMENU;
        private System.Windows.Forms.Label txtEstatus;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Label txtVMAX;
        private System.Windows.Forms.PictureBox Radio;
    }
}