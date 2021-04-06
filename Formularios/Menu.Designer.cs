namespace REPRODUCTOR_LEXOR
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button4 = new System.Windows.Forms.Button();
            this.Radio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Radio
            // 
            this.Radio.Image = ((System.Drawing.Image)(resources.GetObject("Radio.Image")));
            this.Radio.Location = new System.Drawing.Point(332, 98);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(70, 70);
            this.Radio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Radio.TabIndex = 7;
            this.Radio.TabStop = false;
            this.Radio.Click += new System.EventHandler(this.Radio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Encendido_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.button4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Menu";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.Radio, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Radio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox Radio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}