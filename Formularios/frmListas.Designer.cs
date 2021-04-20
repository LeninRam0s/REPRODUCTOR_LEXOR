
namespace REPRODUCTOR_LEXOR.Formularios
{
    partial class frmListas
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
            this.listBoxReproduccion = new System.Windows.Forms.ListBox();
            this.labelTituloListas = new System.Windows.Forms.Label();
            this.btnFormNuevaLista = new System.Windows.Forms.Button();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.btnAgregarAListaActual = new System.Windows.Forms.Button();
            this.btnReproducirLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxReproduccion
            // 
            this.listBoxReproduccion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxReproduccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReproduccion.ForeColor = System.Drawing.Color.Yellow;
            this.listBoxReproduccion.FormattingEnabled = true;
            this.listBoxReproduccion.ItemHeight = 15;
            this.listBoxReproduccion.Location = new System.Drawing.Point(25, 48);
            this.listBoxReproduccion.Name = "listBoxReproduccion";
            this.listBoxReproduccion.Size = new System.Drawing.Size(277, 349);
            this.listBoxReproduccion.TabIndex = 0;
            // 
            // labelTituloListas
            // 
            this.labelTituloListas.AutoSize = true;
            this.labelTituloListas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloListas.ForeColor = System.Drawing.Color.Coral;
            this.labelTituloListas.Location = new System.Drawing.Point(21, 19);
            this.labelTituloListas.Name = "labelTituloListas";
            this.labelTituloListas.Size = new System.Drawing.Size(230, 22);
            this.labelTituloListas.TabIndex = 1;
            this.labelTituloListas.Text = "Listas de Reproducción";
            // 
            // btnFormNuevaLista
            // 
            this.btnFormNuevaLista.Location = new System.Drawing.Point(26, 446);
            this.btnFormNuevaLista.Name = "btnFormNuevaLista";
            this.btnFormNuevaLista.Size = new System.Drawing.Size(88, 31);
            this.btnFormNuevaLista.TabIndex = 2;
            this.btnFormNuevaLista.Text = "Nueva Lista";
            this.btnFormNuevaLista.UseVisualStyleBackColor = true;
            this.btnFormNuevaLista.Click += new System.EventHandler(this.btnFormNuevaLista_Click);
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.Location = new System.Drawing.Point(212, 446);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(88, 31);
            this.btnEliminarLista.TabIndex = 3;
            this.btnEliminarLista.Text = "Eliminar Lista";
            this.btnEliminarLista.UseVisualStyleBackColor = true;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Location = new System.Drawing.Point(118, 446);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(88, 31);
            this.btnActualizarLista.TabIndex = 4;
            this.btnActualizarLista.Text = "Actualizar Lista";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // btnAgregarAListaActual
            // 
            this.btnAgregarAListaActual.Location = new System.Drawing.Point(25, 403);
            this.btnAgregarAListaActual.Name = "btnAgregarAListaActual";
            this.btnAgregarAListaActual.Size = new System.Drawing.Size(137, 31);
            this.btnAgregarAListaActual.TabIndex = 5;
            this.btnAgregarAListaActual.Text = "Agregar a Lista";
            this.btnAgregarAListaActual.UseVisualStyleBackColor = true;
            this.btnAgregarAListaActual.Click += new System.EventHandler(this.btnAgregarAListaActual_Click);
            // 
            // btnReproducirLista
            // 
            this.btnReproducirLista.Location = new System.Drawing.Point(164, 403);
            this.btnReproducirLista.Name = "btnReproducirLista";
            this.btnReproducirLista.Size = new System.Drawing.Size(136, 31);
            this.btnReproducirLista.TabIndex = 6;
            this.btnReproducirLista.Text = "Reproducir Lista";
            this.btnReproducirLista.UseVisualStyleBackColor = true;
            this.btnReproducirLista.Click += new System.EventHandler(this.btnReproducirLista_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(329, 489);
            this.Controls.Add(this.btnReproducirLista);
            this.Controls.Add(this.btnAgregarAListaActual);
            this.Controls.Add(this.btnActualizarLista);
            this.Controls.Add(this.btnEliminarLista);
            this.Controls.Add(this.btnFormNuevaLista);
            this.Controls.Add(this.labelTituloListas);
            this.Controls.Add(this.listBoxReproduccion);
            this.Name = "frmListas";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.frmListas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReproduccion;
        private System.Windows.Forms.Label labelTituloListas;
        private System.Windows.Forms.Button btnFormNuevaLista;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Button btnAgregarAListaActual;
        private System.Windows.Forms.Button btnReproducirLista;
    }
}