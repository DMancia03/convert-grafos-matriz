using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Grafoos
{
    public partial class Form1 : Form
    {
        private CGrafo grafo;
        private CArco arco;
        private CVertice nuevoNodo;
        private CVertice NodoOrigen;
        private CVertice NodoDestino;
        private int var_control = 0;
        private Vertice ventanaVertice;
        private Arco ventanaArco;
        List<CVertice> nodosRuta;
        List<CVertice> nodosOrdenados;
        bool buscarRuta = false, nuevoVertice = false, nuevoArco = false;
        private int numeronodos = 0;
        bool profundidad = false, anchura = false, nodoEncontrado = false;
        Queue cola = new Queue();
        private string destino = "", origen = "";
        private int distancia = 0;

        public Form1()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new Vertice();
            ventanaArco = new Arco();
            nodosRuta = new List<CVertice>();
            nodosOrdenados = new List<CVertice>();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
                if (nuevoVertice)
                {
                    cbvertice.Items.Clear();
                    cbvertice.SelectedIndex = -1;
                    cbnodo.Items.Clear();
                    cbnodo.SelectedIndex = -1;
                    cbInicio.Items.Clear();
                    cbInicio.SelectedIndex = -1;
                    cbFinal.Items.Clear();
                    cbFinal.SelectedIndex = -1;
                    foreach (CVertice nodo in grafo.nodos)
                    {
                        
                        cbvertice.Items.Add(nodo.Valor);
                        cbnodo.Items.Add(nodo.Valor);
                        cbFinal.Items.Add(nodo.Valor);
                        cbInicio.Items.Add(nodo.Valor);
                    }
                    nuevoVertice = false;
                }
                if (nuevoArco)
                {
                    cbarco.Items.Clear();

                    cbarco.SelectedIndex = -1;
                    foreach(CVertice nodo in grafo.nodos)
                    {
                        Console.WriteLine("los nodos son es en nuevo arco " + nodo.Valor);
                        foreach (CArco arco in nodo.ListaAdyacencia)
                            cbarco.Items.Add("(" + nodo.Valor + "," + arco.nDestino.Valor + ") peso:" + arco.peso);
                    }
                    nuevoArco = false;
                }
                if (buscarRuta)
                {
                    foreach (CVertice nodo in nodosRuta)
                    {
                        nodo.colorear(e.Graphics);
                        Thread.Sleep(1000);
                        nodo.DibujarVertice(e.Graphics);
                    }
                    buscarRuta = false;
                }
                if (profundidad)
                {
                    ordenarNodos();
                    foreach (CVertice nodo in nodosOrdenados)
                    {
                        if (!nodo.Visitado)
                            recorridoProfundidad(nodo, e.Graphics);
                    }
                    profundidad = false;
                    foreach (CVertice nodo in grafo.nodos)
                        nodo.Visitado = false;
                }
                if (anchura)
                {
                    distancia = 0;
                    cola = new Queue();
                    ordenarNodos();
                    foreach (CVertice nodo in nodosOrdenados)
                    {
                        if (!nodo.Visitado && !nodoEncontrado)
                            recorridoAnchura(nodo, e.Graphics, destino);
                    }
                    anchura = false; 
                    nodoEncontrado = false; 
                    foreach (CVertice nodo in grafo.nodos)
                        nodo.Visitado = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ordenarNodos()
        {
            nodosOrdenados = new List<CVertice>();
            bool est = false;
            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    nodosOrdenados.Add(nodo);
                    est = true;
                }
                else if (est)
                    nodosOrdenados.Add(nodo);
            }   
            foreach (CVertice nodo in grafo.nodos)
            {
                if (nodo.Valor == origen)
                {
                    est = false;
                    break;
                }
                else if (est)
                    nodosOrdenados.Add(nodo);
            }

        }

        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void nuevoVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoNodo = new CVertice();
            var_control = 2;
        }

        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1:
                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        ventanaArco.Visible = false;
                        ventanaArco.control = false;
                        ventanaArco.ShowDialog();
                        if (ventanaArco.control)
                        {
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino))
                            {
                                int distancia = ventanaArco.dato; ;
                                NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                            }
                            nuevoArco = true;
                        }
                    }
                    var_control = 0;
                    NodoOrigen = null;
                    NodoDestino = null;
                    Pizarra.Refresh();
                    EscribirPreMatriz(grafo);
                    break;
            }
        }

        private void btnelimiver_Click(object sender, EventArgs e)
        {
            if (cbvertice.SelectedIndex > -1)
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    if(nodo.Valor == cbvertice.SelectedItem.ToString())
                    {
                        grafo.nodos.Remove(nodo);
                        nodo.ListaAdyacencia = new List<CArco>();
                        break;
                    }
                }
                foreach(CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if(arco.nDestino.Valor == cbvertice.SelectedItem.ToString())
                        {
                            nodo.ListaAdyacencia.Remove(arco);
                            break;
                        }
                    }
                }
                nuevoArco = true;
                nuevoVertice = true;
                cbvertice.SelectedItem = -1;
                Pizarra.Refresh();
            }
            else
            {
                LBLVER.Text = "Seleccione un nodo";
                LBLVER.ForeColor = Color.Red;
            }
        }

        private void btnelimiarco_Click(object sender, EventArgs e)
        {
            if (cbarco.SelectedIndex > -1 )
            {
                foreach (CVertice nodo in grafo.nodos)
                {
                    foreach (CArco arco in nodo.ListaAdyacencia)
                    {
                        if("(" + nodo.Valor + "," + arco.nDestino.Valor + ")" + arco.peso == cbarco.SelectedItem.ToString())
                        {
                            nodo.ListaAdyacencia.Remove(arco);
                            break;
                        }
                    }
                }
                nuevoVertice = true;
                nuevoArco = true;
                cbarco.SelectedIndex = -1;
                Pizarra.Refresh();
            }
            else
            {
                LBLVER.Text = "Seleccione un arco";
                LBLVER.ForeColor = Color.Red;
            }
        }
        private void recorridoProfundidad(CVertice vertice, Graphics g)
        {
            vertice.Visitado = true;
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarVertice(g);
            txtRecorrido.Text="";

            textBoxRecorrido.Text += vertice.Valor + "->";
           
            foreach (CArco adya in vertice.ListaAdyacencia)
            {
                if (!adya.nDestino.Visitado) {
                    //recorrido += "->"+adya.nDestino.Valor;
                    recorridoProfundidad(adya.nDestino, g); 

                }
            }
           
        }
        private void recorridoAnchura(CVertice vertice, Graphics g, string destino)
        {
            vertice.Visitado = true;
            // List<String>listaCamino=new List<String>();
            String recorrido = "";
            cola.Enqueue(vertice);
            vertice.colorear(g);
            Thread.Sleep(1000);
            vertice.DibujarVertice(g);
            recorrido += vertice.Valor + "->";

            if (vertice.Valor == destino) 
            {
                nodoEncontrado = true;
                MessageBox.Show("Recorrido: ->" + vertice.Valor);
                return;
            }
            while (cola.Count > 0)
            {
                
                CVertice aux = (CVertice)cola.Dequeue();

                foreach (CArco adya in aux.ListaAdyacencia)
                {
                    if(!adya.nDestino.Visitado)
                    {
                        if(!nodoEncontrado)
                        {
                            //lista camino
                            adya.nDestino.Visitado = true;
                            adya.nDestino.colorear(g);
                            Thread.Sleep(1000);
                            adya.nDestino.DibujarVertice(g) ;
                            if (destino != "")
                                distancia += adya.peso;
                            cola.Enqueue(adya.nDestino);
                           // listaCamino.Add(adya.nDestino.Valor.ToString());

                            recorrido += adya.nDestino.Valor + "->";


                            if (adya.nDestino.Valor == destino)
                            {
                               
                                
                                nodoEncontrado = true;
                                return;
                            }
                        }
                    }
                }
            }
           // string joined = string.Join("->", listaCamino.Select(x => x));
            //Console.WriteLine("camino "+recorrido);
           MessageBox.Show("El recorrido fue"+recorrido);
        }

        private void btnprofundida_Click(object sender, EventArgs e)
        {
            if(cbnodo.SelectedIndex >-1)
            {
                profundidad = true;
                origen = cbnodo.SelectedItem.ToString();
                Pizarra.Refresh();
                cbnodo.SelectedIndex = -1;
            }
            else
            {
                LBLVER.Text = "Seleccione un nodo de partida";
                LBLVER.ForeColor = Color.Red;
            }
        }

        private void btnanchura_Click(object sender, EventArgs e)
        {
            if (cbnodo.SelectedIndex >-1)
            {
                origen = cbnodo.SelectedItem.ToString();
                anchura = true;
                Pizarra.Refresh();
                cbnodo.SelectedIndex = -1;
            }
            else
            {
                LBLVER.Text = "Seleccione un nodo de partida";
                LBLVER.ForeColor = Color.Red;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(txtvert.Text.Trim() !="")
            {
                if (grafo.BuscarVertice(txtvert.Text) !=null)
                {
                    LBLVER.Text = "si encuentra el vertice" + txtvert.Text;
                    LBLVER.ForeColor = Color.Blue;
                }
                else
                {
                    LBLVER.Text = "No se encuentra el vertice" + txtvert.Text;
                    LBLVER.ForeColor = Color.Red;
                }
            }
        }
        private int totalNodos;
        int[] parent;
        bool[] visitados;

        private void CalcularMatricesIniciales()
        {
            nodosRuta = new List<CVertice>();
            totalNodos = grafo.nodos.Count;
            parent = new int[totalNodos];
            visitados = new bool[totalNodos];

            for (int i = 0; i < totalNodos; i ++)
            {
                List<int> filaDistancia = new List<int>();
                for (int j = 0; j >totalNodos; j++)
                {
                    if (i ==j)
                    {
                        filaDistancia.Add(0);
                    }
                    else
                    {
                        int distancia = -1;
                        for (int k = 0; k < grafo.nodos[i].ListaAdyacencia.Count; k++)
                        {
                            if (grafo.nodos[i].ListaAdyacencia[k].nDestino == grafo.nodos[j])
                                distancia = grafo.nodos[i].ListaAdyacencia[k].peso;
                        }
                        filaDistancia.Add(distancia);
                    }
                }
              
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbnodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndistancia_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {

                case 2:
                    if (nuevoNodo != null)
                    {
                        int posX = e.Location.X;
                        int posY = e.Location.Y;

                        if (posX < nuevoNodo.Dimensiones.Width / 2)
                            posX = nuevoNodo.Dimensiones.Width / 2;
                        else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;
                        if (posY < nuevoNodo.Dimensiones.Height / 2)
                            posY = nuevoNodo.Dimensiones.Height / 2;
                        else if (posY > Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                            posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;
                        nuevoNodo.Posicion = new Point(posX, posY);
                        Pizarra.Refresh();
                        nuevoNodo.DibujarVertice(Pizarra.CreateGraphics());
                    }
                    break;

                case 1:
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;

                    Pizarra.Refresh();
                    Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2)
                    {
                        CustomEndCap = bigArrow
                    },
                    NodoOrigen.Posicion, e.Location);
                    break;
            }
        }

        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    var_control = 1;

                if (nuevoNodo != null && NodoOrigen == null)
                {
                    ventanaVertice.ShowDialog();

                    if (ventanaVertice.control)
                    {
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null)
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                            ventanaVertice.Visible = false;
                            ventanaVertice.control = false;
                            grafo.AgregarVertice(nuevoNodo);
                        }

                        else
                            MessageBox.Show("El nodo " + ventanaVertice.txtVertice.Text + " ya existe en el grafo", "Error nuevo Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    nuevoNodo = null;
                    nuevoVertice = true;
                    var_control = 0;
                    
                    Pizarra.Refresh();
                    EscribirPreMatriz(grafo);
                }
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                        nuevoVerticeToolStripMenuItem.Visible = false;
                        eliminarNodoToolStripMenuItem.Visible = true;
                        eliminarArcoToolStripMenuItem.Visible = false;
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                    else if ((arco = grafo.DetectarRecta(e.Location)) != null)
                    {
                        nuevoVerticeToolStripMenuItem.Visible = false;
                        eliminarNodoToolStripMenuItem.Visible = false;
                        eliminarArcoToolStripMenuItem.Visible = true;
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                    else
                    {
                        nuevoVerticeToolStripMenuItem.Visible = true;
                        eliminarNodoToolStripMenuItem.Visible = false;
                        eliminarArcoToolStripMenuItem.Visible = false;
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                    }
                }
            }
        }

        private void eliminarNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var_control = 3;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void eliminarArcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var_control = 4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EscribirPreMatriz(CGrafo grafo)
        {
            Dictionary<string, int> d = DiccionarioNodos(grafo);
            DgvMatrizAdyacencia.Columns.Clear();
            DgvMatrizAdyacencia.ColumnCount = d.Count();

            foreach (string row in d.Keys)
            {
                int id = d[row];
                DgvMatrizAdyacencia.Columns[id].Name = row;
                string[] a = new string[d.Count()];
                foreach (string col in d.Keys)
                {
                    int id2 = d[col];
                    a[id2] = (TieneAdyacencia(grafo, row, col) ? "1" : "0");
                }
                DgvMatrizAdyacencia.Rows.Add(a);
            }
        }

        private Dictionary<string, int> DiccionarioNodos(CGrafo g)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            int i = 0;
            foreach (CVertice v in grafo.nodos)
            {
                d.Add(v.Valor, i);
                i++;
            }
            return d;
        }

        private bool TieneAdyacencia(CGrafo g, string actual, string destino)
        {
            bool bandera = false;
            CVertice v = g.nodos.Where(d => d.Valor == actual).FirstOrDefault();
            foreach(CArco a in v.ListaAdyacencia)
            {
                if(a.nDestino.Valor == destino)
                {
                    bandera = true;
                }
            }
            return bandera;
        }
    }
}