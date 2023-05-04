using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Grafoos
{
    class CGrafo
    {
        public List<CVertice> nodos;

        public CGrafo()
        {
            nodos = new List<CVertice>();
        }




        public CVertice AgregarVertice(string valor)
        {


            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;
        }


        public void AgregarVertice(CVertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }


        public int EliminarVertice(CVertice VerticeEliminar)
        {
            CVertice verticeEncontrado;

            if (nodos != null)
            {
                if ((verticeEncontrado = nodos.Find(v => v.Equals(VerticeEliminar))) != null)
                {
                    if (BuscarEnlaceConVertice(VerticeEliminar))
                        EliminarArco(VerticeEliminar);
                    nodos.Remove(verticeEncontrado);

                    return 1;
                }
                return 0;
            }
            return 0;
        }

        public int EliminarArco(CVertice VerticeDestino)
        {
            CArco arcoEliminar;
            if (nodos != null)
            {
                foreach (CVertice vertice in nodos)
                    if ((arcoEliminar = vertice.ListaAdyacencia.Find(v => v.nDestino.Equals(VerticeDestino))) != null)
                    {
                        vertice.ListaAdyacencia.Remove(arcoEliminar);
                        return 1;
                    }
            }
            return 0;
        }

        public bool BuscarEnlaceConVertice(CVertice VerticeDestino)
        {
            if (nodos != null)
            {
                foreach (CVertice vertice in nodos)
                    return vertice.ListaAdyacencia.Find(v => v.nDestino.Equals(VerticeDestino)) != null;
            }
            return false;
        }


        public CVertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        public bool AgregarArco(string origen, string nDestino, int peso = 1)
        {
            CVertice vOrigen, vnDestino;


            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + " no existe dentro del grafo.");

            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + nDestino + " no existe dentro del grafo.");

            return AgregarArco(vOrigen, vnDestino);
        }

        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso = 1)
        {

            if ((origen.ListaAdyacencia.Find(v => v.nDestino == nDestino)) == null)
            {
                origen.ListaAdyacencia.Add(new CArco(nDestino, peso));
                return true;
            }
            return false;
        }

        public void DibujarGrafo(Graphics g)
        {

            foreach (CVertice nodo in nodos)
                nodo.DibujarArco(g);

            foreach (CVertice nodo in nodos)
                nodo.DibujarVertice(g);
        }


        public CVertice DetectarPunto(Point posicionMouse)
        {
            foreach (CVertice nodoActual in nodos)
                if (nodoActual.DetectarPunto(posicionMouse)) return nodoActual;
            return null;
        }

        public CArco DetectarRecta(Point posicionMouse)
        {
            foreach (CVertice vertice in nodos)
            {
                foreach (CArco arco in vertice.ListaAdyacencia)
                {
                    if (vertice.DetectarRecta(posicionMouse)) return arco;
                }
            }
            return null;
        }

        public void ReestablecerGrafo(Graphics g)
        {
            foreach (CVertice nodo in nodos)
            {
                nodo.Color = Color.White;
                nodo.FontColor = Color.Black;
                foreach (CArco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 1;
                    arco.color = Color.Black;
                }
            }

            DibujarGrafo(g);
        }
        public void ColoArista(string o, string d)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo.Valor == o && a.nDestino.Valor == d)
                    {
                        a.color = Color.Red;
                        a.grosor_flecha = 4;
                    }
                }
            }
        }
        public void Colorear(CVertice nodo)
        {
            nodo.Color = Color.AliceBlue;
            nodo.FontColor = Color.Black;
        }

        public CVertice nododistanciaminima()
        {
            int min = int.MaxValue;
            CVertice temp = null;
            foreach (CVertice origen in nodos)
            {
                if (origen.Visitado)
                {
                    foreach (CVertice destino in nodos)
                    {
                        if (!destino.Visitado)
                        {
                            foreach (CArco a in origen.ListaAdyacencia)
                            {
                                if (a.nDestino == destino && min > a.peso)
                                {
                                    min = a.peso;
                                    temp = destino;
                                }
                            }
                        }
                    }
                }
            }
            return temp;
        }

        public int posicionNodo(string Nodo)
        {
            for (int i = 0; i < nodos.Count; i++)
            {
                if (String.Compare(nodos[i].Valor, Nodo) == 0)
                    return i;
            }
            return -1;
        }

        public void DibujarEntrantes(CVertice nDestino)
        {
            foreach (CVertice nodo in nodos)
            {
                foreach (CArco a in nodo.ListaAdyacencia)
                {
                    if (nodo.ListaAdyacencia != null && nodo != nDestino)
                    {
                        a.color = Color.Black;
                        a.grosor_flecha = 2;
                        break;
                    }
                }
            }
        } 

        public void Desmarcar()
        {
            foreach (CVertice n in nodos)
            {
                n.Visitado = false;
                n.Padre = null;
                n.distancianodo = int.MaxValue;
                n.pesoasignado = false;
            }
        }

        internal object BuscarVertice(object text)
        {
            throw new NotImplementedException();
        }

    }
}