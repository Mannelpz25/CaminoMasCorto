using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Grafo
    {
        List<Vertice> lv;
        public Grafo(List<Point> lp)
        {
            lv = new List<Vertice>();
            int cont = 0;
            foreach(Point p in lp)
            {
                cont++;
                Vertice v = new Vertice(p, cont);
                lv.Add(v);
            }

            foreach(Vertice origen in lv)
            {
                foreach(Vertice destino in lv)
                {
                    if(origen != destino)
                    {
                        double peso = Math.Sqrt(Math.Pow((destino.getPoint().X - origen.getPoint().X), 2) + Math.Pow((destino.getPoint().Y - origen.getPoint().Y), 2));
                        Arista a = new Arista(destino, peso);
                        origen.insertaArista(a);
                    }
                }
            }
        }
        public List<Vertice> getLV()
        {
            return lv;
        }
        
        
    }

    public class Vertice
    {
        List<Arista> la;
        int nombre;
        Point p;
        public Vertice(Point p, int c)
        {
            this.la = new List<Arista>();
            this.p = p;
            this.nombre = c;
        }
        public Point getPoint()
        {
            return this.p;
        }
        public int getNombre()
        {
            return this.nombre;
        }
        public void insertaArista(Arista a)
        {
            this.la.Add(a);
        }
        public List<Arista> getLA()
        {
            return la;
        }
    }

    public class Arista
    {
        double ponderacion;
        Vertice v;

        public Arista(Vertice v, double peso)
        {
            this.v = v;
            ponderacion = peso;
        }
        public Vertice getV()
        {
            return v;
        }
        public double getP()
        {
                return ponderacion;
        }
            public String toS()
        {
            string c = getV().getNombre() + ":" + Math.Round(ponderacion,1);
            return c;
        }
    }
}
