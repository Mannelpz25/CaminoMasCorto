namespace WindowsFormsApp4
{
    partial class infGrafo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.verticeListbox = new System.Windows.Forms.ListBox();
            this.aristaListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caminoButton = new System.Windows.Forms.Button();
            this.caminoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // verticeListbox
            // 
            this.verticeListbox.FormattingEnabled = true;
            this.verticeListbox.Location = new System.Drawing.Point(434, 33);
            this.verticeListbox.Name = "verticeListbox";
            this.verticeListbox.Size = new System.Drawing.Size(43, 329);
            this.verticeListbox.TabIndex = 1;
            // 
            // aristaListbox
            // 
            this.aristaListbox.FormattingEnabled = true;
            this.aristaListbox.HorizontalScrollbar = true;
            this.aristaListbox.Location = new System.Drawing.Point(485, 33);
            this.aristaListbox.Name = "aristaListbox";
            this.aristaListbox.Size = new System.Drawing.Size(451, 329);
            this.aristaListbox.TabIndex = 2;
            this.aristaListbox.SelectedIndexChanged += new System.EventHandler(this.aristaListbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aristas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vertice";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // caminoButton
            // 
            this.caminoButton.Location = new System.Drawing.Point(813, 368);
            this.caminoButton.Name = "caminoButton";
            this.caminoButton.Size = new System.Drawing.Size(123, 23);
            this.caminoButton.TabIndex = 5;
            this.caminoButton.Text = "Camino mas corto ";
            this.caminoButton.UseVisualStyleBackColor = true;
            this.caminoButton.Click += new System.EventHandler(this.caminoButton_Click);
            // 
            // caminoLabel
            // 
            this.caminoLabel.AutoSize = true;
            this.caminoLabel.Location = new System.Drawing.Point(497, 368);
            this.caminoLabel.Name = "caminoLabel";
            this.caminoLabel.Size = new System.Drawing.Size(0, 13);
            this.caminoLabel.TabIndex = 6;
            this.caminoLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // infGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 396);
            this.Controls.Add(this.caminoLabel);
            this.Controls.Add(this.caminoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aristaListbox);
            this.Controls.Add(this.verticeListbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "infGrafo";
            this.Text = "Grafo";
            this.Load += new System.EventHandler(this.infGrafo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox verticeListbox;
        private System.Windows.Forms.ListBox aristaListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button caminoButton;
        private System.Windows.Forms.Label caminoLabel;
    }
}