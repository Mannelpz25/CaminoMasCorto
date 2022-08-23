using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ImagenForm : Form
    {

        List<Point> lp;
        string s;
        public ImagenForm()
        {

            lp = new List<Point>();
            s = "";
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            s = openFileDialog1.FileName;
            this.imgPictureBox.Load(s);
            listBox1.Items.Clear();
            findButton.Enabled=true;
            grafoButton.Enabled = false;

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Bitmap img = new Bitmap(s);
            ImageProcessing IP = new ImageProcessing(img);
            lp = IP.findCenters();
            // Point p = IP.findCircleCenter();
            //Console.WriteLine(p.ToString());

            Graphics c = Graphics.FromImage(img);
            Brush b = new SolidBrush(Color.White);

            Brush b2 = new SolidBrush(Color.CornflowerBlue);
            Font f = new Font("century", 14, FontStyle.Bold);
            int cont = 0;
            foreach (Point p in lp)
            {
                cont++;
                c.FillEllipse(b, p.X - 2, p.Y - 2, 4, 4);
                Point x = new Point(p.X + 8, p.Y + 8);
                c.DrawString(cont.ToString(), f, b2, x);
            }
            imgPictureBox.Image=img;
            foreach (Point p in lp)
              listBox1.Items.Add(p);
            grafoButton.Enabled = true;
        }

        private void grafoButton_Click(object sender, EventArgs e)
        {
            Bitmap imgGrafo = new Bitmap(s);
            Grafo g = new Grafo(lp);
            List<Vertice> aux = new List<Vertice>();
            Graphics c = Graphics.FromImage(imgGrafo);
            Brush b = new SolidBrush(Color.White);

            Brush b2 = new SolidBrush(Color.CornflowerBlue);
            Font f = new Font("century", 16, FontStyle.Bold);
            int cont = 0;
            
            foreach (Vertice v in g.getLV())
                foreach (Arista a in v.getLA()) {
                    Point p_i = v.getPoint();
                    Point p_f = a.getV().getPoint();
                    if (a.getV().getNombre() > v.getNombre())
                    {
                        Pen pen1 = new Pen(Color.Black, 5);
                        c.DrawLine(pen1, p_i, p_f);
                        aux.Add(v);
                        aux.Add(a.getV());

                    }
                }
            foreach (Point p in lp)
            {
                cont++;

                Point x = new Point(p.X - 10, p.Y - 10);
                c.DrawString(cont.ToString(), f, b2, x);
            }
            infGrafo ventanacambios = new infGrafo(imgGrafo, g);
            ventanacambios.ShowDialog();
        }
    }
}
