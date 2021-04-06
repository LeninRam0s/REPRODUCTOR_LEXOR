namespace REPRODUCTOR_LEXOR
{
    partial class FrmAsistente
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
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnMoto = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.Titulo_Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPickUp
            // 
            this.btnPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickUp.ForeColor = System.Drawing.Color.Purple;
            this.btnPickUp.Location = new System.Drawing.Point(250, 84);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(130, 66);
            this.btnPickUp.TabIndex = 0;
            this.btnPickUp.Text = "PickUp";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnMoto
            // 
            this.btnMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoto.ForeColor = System.Drawing.Color.Purple;
            this.btnMoto.Location = new System.Drawing.Point(57, 84);
            this.btnMoto.Name = "btnMoto";
            this.btnMoto.Size = new System.Drawing.Size(130, 65);
            this.btnMoto.TabIndex = 1;
            this.btnMoto.Text = "Motocicleta";
            this.btnMoto.UseVisualStyleBackColor = true;
            this.btnMoto.Click += new System.EventHandler(this.btnMoto_Click);
            // 
            // btnGT
            // 
            this.btnGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGT.ForeColor = System.Drawing.Color.Purple;
            this.btnGT.Location = new System.Drawing.Point(439, 84);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(130, 66);
            this.btnGT.TabIndex = 2;
            this.btnGT.Text = "CHALLENGER SRT";
            this.btnGT.UseVisualStyleBackColor = true;
            this.btnGT.Click += new System.EventHandler(this.btnGT_Click);
            // 
            // Titulo_Bienvenida
            // 
            this.Titulo_Bienvenida.AutoSize = true;
            this.Titulo_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Titulo_Bienvenida.Location = new System.Drawing.Point(43, 36);
            this.Titulo_Bienvenida.Name = "Titulo_Bienvenida";
            this.Titulo_Bienvenida.Size = new System.Drawing.Size(541, 29);
            this.Titulo_Bienvenida.TabIndex = 3;
            this.Titulo_Bienvenida.Text = "Bienvenid@, Elija un Vehiculo para transportarse.";
            // 
            // FrmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 208);
            this.Controls.Add(this.Titulo_Bienvenida);
            this.Controls.Add(this.btnGT);
            this.Controls.Add(this.btnMoto);
            this.Controls.Add(this.btnPickUp);
            this.Name = "FrmAsistente";
            this.Text = "ASISTENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnMoto;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Label Titulo_Bienvenida;
    }
}