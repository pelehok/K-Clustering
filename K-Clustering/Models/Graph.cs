using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class Graph
    {
        public List<EdgeWeigth> Edges { get; set; }
        public int V { get; set; }
        public int E { get; set; }

        public Graph(int v)
        {
            V = v;
            Edges = new List<EdgeWeigth>();
        }

        public void AddEdge(EdgeWeigth edge)
        {
            Edges.Add(edge);
            E++;
        }

        public void SortEdge()
        {
            Edges.Sort(Comparer);
        }

        private int Comparer(EdgeWeigth edge1, EdgeWeigth edge2)
        {
            return edge1.Weight.CompareTo(edge2.Weight);
        }
    }
}
