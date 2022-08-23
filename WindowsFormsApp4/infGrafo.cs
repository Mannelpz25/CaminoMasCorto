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
    public partial class infGrafo : Form
    {
        Grafo g;
        Bitmap imgGrafo;
        public infGrafo(Bitmap b, Grafo g)
        {
            string aristas = "";
            InitializeComponent();
            imgGrafo = b;
            pictureBox1.Image = imgGrafo;
            
            this.g = g;
            foreach (Vertice v in g.getLV())
            {
                foreach (Arista a in v.getLA())
                {
                    aristas = aristas + a.toS() + "     ";             
                    
                }
                verticeListbox.Items.Add(v.getNombre());
                aristaListbox.Items.Add(aristas);
                aristas = "";
            }
        }
        public void caminoCorto()
        {
            double min = g.getLV().First().getLA().First().getP() + g.getLV().First().getLA().First().getV().getLA().First().getP() + g.getLV().First().getLA().First().getV().getLA().First().getV().getLA().First().getP();
            Vertice destino, origen, v2, v3;
            List<Vertice> vC = new List<Vertice>();
            foreach (Vertice v in g.getLV())
            {
                origen = v;
                foreach (Arista a1 in v.getLA())
                {
                    v2 = a1.getV();
                    foreach (Arista a2 in a1.getV().getLA())
                    {
                        v3 = a2.getV();
                        foreach (Arista a3 in a2.getV().getLA())
                        {
                            destino = a3.getV();
                            if (origen != destino && origen != v2 && origen != v3 && v2 != destino && v2 != v3 && v3 != destino)
                            {
                                //if (origen.getNombre() < v2.getNombre() && v2.getNombre() < v3.getNombre() && v3.getNombre() < destino.getNombre())
                                //{
                                    
                                    if(min> a1.getP() + a2.getP() + a3.getP())
                                    {
                                        min = a1.getP() + a2.getP() + a3.getP();
                                        vC.Clear();
                                        vC.Add(origen);
                                        vC.Add(v2);
                                        vC.Add(v3);
                                        vC.Add(destino);
                                    }
                                //}
                            }
                           
                        }
                    }
                }
            }
            Console.WriteLine(min.ToString());
            foreach (Vertice v in vC)
                Console.WriteLine(v.getNombre().ToString());
            Graphics c = Graphics.FromImage(imgGrafo);
            Brush b = new SolidBrush(Color.Yellow);
            Brush b2 = new SolidBrush(Color.DodgerBlue);
            Font f = new Font("century", 14, FontStyle.Bold);
            int cont = 0;
            string inf = "";;
            foreach (Vertice v in vC)
            {
                cont++;
                Point x = new Point(v.getPoint().X - 10, v.getPoint().Y - 10);

                inf += v.getNombre().ToString() + "->";
                c.FillEllipse(b, v.getPoint().X - 13, v.getPoint().Y - 13, 26, 26);
                foreach (Arista a in v.getLA())
                {
                    
                    Point p_i = v.getPoint();
                    Point p_f = a.getV().getPoint();
                    if(cont<vC.Count)
                    if (a.getV().getNombre() == vC.ElementAt(cont).getNombre())
                    {
                        Pen pen1 = new Pen(Color.Yellow, 5);
                        c.DrawLine(pen1, p_i, p_f);
                           
                        


                    }

                }
                c.DrawString(v.getNombre().ToString(), f, b2, x);
            }
            inf += " Costo: " + Math.Round(min,1).ToString();
            caminoLabel.Text = inf;
            pictureBox1.Image = imgGrafo;
        }

            private void infGrafo_Load(object sender, EventArgs e)
        {

        }

        private void aristaListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void caminoButton_Click(object sender, EventArgs e)
        {
            caminoCorto();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
