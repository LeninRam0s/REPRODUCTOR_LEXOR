
namespace REPRODUCTOR_LEXOR.Formularios
{
    partial class frmNuevaLista
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
            this.txtNombreNuevaLista = new System.Windows.Forms.TextBox();
            this.labelNuevaLista = new System.Windows.Forms.Label();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreNuevaLista
            // 
            this.txtNombreNuevaLista.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombreNuevaLista.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNombreNuevaLista.Location = new System.Drawing.Point(28, 25);
            this.txtNombreNuevaLista.Name = "txtNombreNuevaLista";
            this.txtNombreNuevaLista.Size = new System.Drawing.Size(327, 20);
            this.txtNombreNuevaLista.TabIndex = 0;
            // 
            // labelNuevaLista
            // 
            this.labelNuevaLista.AutoSize = true;
            this.labelNuevaLista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaLista.ForeColor = System.Drawing.Color.Gold;
            this.labelNuevaLista.Location = new System.Drawing.Point(25, 7);
            this.labelNuevaLista.Name = "labelNuevaLista";
            this.labelNuevaLista.Size = new System.Drawing.Size(159, 15);
            this.labelNuevaLista.TabIndex = 1;
            this.labelNuevaLista.Text = "Nombre para tu nueva Lista";
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.Location = new System.Drawing.Point(28, 51);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(89, 32);
            this.btnAgregarALista.TabIndex = 2;
            this.btnAgregarALista.Text = "Agregar";
            this.btnAgregarALista.UseVisualStyleBackColor = true;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 51);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(378, 102);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarALista);
            this.Controls.Add(this.labelNuevaLista);
            this.Controls.Add(this.txtNombreNuevaLista);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmNuevaLista";
            this.Text = "Nueva Lista de Reprocuccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreNuevaLista;
        private System.Windows.Forms.Label labelNuevaLista;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.Button btnCancelar;
    }
}