using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class GraphNode
    {
        public List<Node> Edges { get; set; }
        public int V { get; set; }

        public int E
        {
            get { return V * V; }
        }

        public GraphNode(int v)
        {
            Edges = new List<Node>();
        }

        public void AddEdge(Node edge)
        {
            Edges.Add(edge);
            V++;
        }
    }
}
