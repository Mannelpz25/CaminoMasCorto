using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class ImageProcessing
    {
        Bitmap img;
        Bitmap imgFC;

        public ImageProcessing() { }
        public ImageProcessing(Bitmap img)
        {
            this.img = img;
            this.imgFC = new Bitmap(img);
        }
        public List<Point> findCenters()
        {
            List<Point> lp = new List<Point>();
            for (int j = 0; j < imgFC.Height; j++)
                for (int i = 0; i < imgFC.Width; i++)
                    if (imgFC.GetPixel(i, j).R == 0)
                        if (imgFC.GetPixel(i, j).G == 0)
                            if (imgFC.GetPixel(i, j).B == 0)
                            {
                                Point p = new Point();
                                p = findCircleCenter(i, j);
                                lp.Add(p);
                                int x_i;
                                int x_f;
                                int y_i;
                                int r;
                                int w;
                                int h;
                                for (x_f = p.X; x_f < imgFC.Width; x_f++)
                                {
                                    if (imgFC.GetPixel(x_f, p.Y).R != 0)
                                        break;
                                    if (imgFC.GetPixel(x_f, p.Y).G != 0)
                                        break;
                                    if (imgFC.GetPixel(x_f, p.Y).B != 0)
                                        break;


                                }
                                x_f--;
                                r = x_f - p.X;
                                x_i = p.X - r - 6;
                                y_i = p.Y - r - 6;
                                w = 2 * r + 12;
                                h = w;
                                

                                Graphics g = Graphics.FromImage(imgFC);
                                Brush brocha = new SolidBrush(Color.IndianRed);
                                g.FillEllipse(brocha, x_i, y_i, w, h);
                               // CambiosForm1 ventanacambios = new CambiosForm1(imgFC);
                               // ventanacambios.ShowDialog();
                            }
            return lp;
        }
            public Point findCircleCenter(int i, int j)
        {
            int x_i, y_i;
            int x_c, y_c;
            int x_f, y_f;
            x_i = i;
            y_i = j;
            for(x_f=x_i; x_f<imgFC.Width;x_f++)
            {
                if (imgFC.GetPixel(x_f, y_i).R != 0)
                    break;
                if (imgFC.GetPixel(x_f, y_i).G != 0)
                    break;
                if (imgFC.GetPixel(x_f, y_i).B != 0)
                    break;
                                            
                                             
            }
            x_f--;
            for (y_f = y_i; y_f < imgFC.Height; y_f++)
            {
                if (imgFC.GetPixel(x_i, y_f).R != 0)
                    break;
                if (imgFC.GetPixel(x_i, y_f).G != 0)
                    break;
                if (imgFC.GetPixel(x_i, y_f).B != 0)
                    break;
                                            
            }
            x_c = (x_i + x_f) / 2;
            y_c = (y_i + y_f) / 2;
           
            return new Point(x_c, y_c);
                            
        }
    
    }
}
