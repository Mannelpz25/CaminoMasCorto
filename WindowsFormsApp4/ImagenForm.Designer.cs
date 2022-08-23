namespace WindowsFormsApp4
{
    partial class ImagenForm
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
            this.openButton = new System.Windows.Forms.Button();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.findButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grafoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(589, 27);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Abrir Imagen";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.Location = new System.Drawing.Point(12, 12);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(510, 314);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPictureBox.TabIndex = 1;
            this.imgPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Location = new System.Drawing.Point(589, 56);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Centroide";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(539, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 186);
            this.listBox1.TabIndex = 3;
            // 
            // grafoButton
            // 
            this.grafoButton.Enabled = false;
            this.grafoButton.Location = new System.Drawing.Point(589, 85);
            this.grafoButton.Name = "grafoButton";
            this.grafoButton.Size = new System.Drawing.Size(75, 23);
            this.grafoButton.TabIndex = 4;
            this.grafoButton.Text = "Grafo";
            this.grafoButton.UseVisualStyleBackColor = true;
            this.grafoButton.Click += new System.EventHandler(this.grafoButton_Click);
            // 
            // ImagenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 340);
            this.Controls.Add(this.grafoButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.openButton);
            this.Name = "ImagenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camino mas corto";
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button grafoButton;
    }
}

