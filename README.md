## Camino mas corto

**Este programa a partir de una imagen se encuentren los centros de cada circulo que se encuentre en la imagen.**

**Para poder realizarlo se necesitó agregar dos botones en el Form para que uno al seleccionarlo cargue una imagen y la posicione en un ImageBox y se muestre en la ventana y otro botón el cual acciona los métodos necesarios para analizar la imagen.**

Botón para agregar la imagen:

    private void openButton_Click(object sender, EventArgs e)
    
    {
    
    this.openFileDialog1.ShowDialog();
    
    s = openFileDialog1.FileName;
    
    this.imgPictureBox.Load(s);
    
    }
Botón para buscar centroides:


    private void findButton_Click(object sender, EventArgs e)
    
    {
    
    Bitmap img = new Bitmap(s);
    
    ImageProcessing IP = new ImageProcessing(img);
    
    List<Point> lp = new List<Point>();
    
    lp = IP.findCenters();
    
    _// Point p = IP.findCircleCenter();_
    
    _//Console.WriteLine(p.ToString());_
    
    Graphics c = Graphics.FromImage(img);
    
    Brush b = new SolidBrush(Color.White);
    
    foreach (Point p in lp)
    
    {
    
    c.FillEllipse(b, p.X - 2, p.Y - 2, 4, 4);
    
    }
    
    imgPictureBox.Image=img;
    
    foreach (Point p in lp)
    
    listBox1.Items.Add(p);
    
    }
<![endif]-->

En el cual se crea un Bitmap a partir de la imagen cargada, se crea un objeto de la clase ImageProcessing y se le llama IP, se crea una lista de Point el cual se utiliza para coordenadas XY**

Llamada lp.

Se le añaden lo que retorna findCenters() a la lista lp.

Ya que se obtienen los centroides con la clase Graphics se pintan los centros de los círculos y después se añaden a la listBox las coordenadas XY de cada centroide.



**Para encontrar los centros en la clase ImageProcessing() se utilizaron dos métodos uno llamado findCircleCenter() el cual encuentra el centroide de un circulo cuando encuentra un pixel de color negro se encuentra el centro. Y lo retorna a la función findCenters() **

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
    
    CambiosForm1 ventanacambios = new CambiosForm1(imgFC);
    
    ventanacambios.ShowDialog();
    
    }
    
    return lp;
    
    }



**Se integra una clase llamada Grafo**

**La cual se encargará de identificar los centroides de los círculos dados de una imagen para generar vértices, y a partir de esos vértices crear aristas que conecten a todos los vértices, generando un grafo fuertemente conexo.**

**A partir de nuestro Form creamos un nuevo botón para generar en grafo con el evento click:**

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


**Este botón funciona solo si ya se ha cargado una imagen y se han encontrado los centroides con el botón findButton. Con este botón de grafo lo que hace es que a partir de los centroides pinta una línea para generar las aristas entre los grafos. Y lo muestra en la ventana de cambios.**

**Después de generar todas las aristas y guardarlas en listas de adyacencia en la ventana de infGrafo se tiene una lista con todas las ponderaciones de las aristas.**

**Y un botón para generar el camino más corto que involucre 4 vértices el cual se implementa con fuerza bruta:**

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


**Con esto se genera el camino más corto evaluando cada cuarteto de vértices y con otro cuarteto hasta encontrar el de menor costo, para esto se llama mandar a partir del evento click en el botón.**

    private void caminoButton_Click(object sender, EventArgs e)
    {
         caminoCorto();
    }


**Se muestra en el mismo pictureBox y se escribe en un label la información del camino mas corto.**



## **Impresiones de pantalla**


A partir de la imagen cargada y ya encontrados los circulos
![enter image description here](https://i.postimg.cc/mr8SfJYx/Imagen4.png)

Al pulsar el botón grafo se abre una ventana llamada inf grafo, donde se muestra ya dibujado el grafo fuertemente conexo, con un número de identificación cada vértice y a su derecha la lista de adyacencia con sus ponderaciones correspondientes.
![enter image description here](https://i.postimg.cc/fbwvPD0j/Imagen3.png)


Al seleccionar el botón Camino más corto se muestra gráficamente con color amarillo el camino más corto que involucra los 4 vértices y en la parte inferior se muestra con texto el camino y la ponderación total.
![enter image description here](https://i.ibb.co/fC9QxWJ/Imagen2.png)
