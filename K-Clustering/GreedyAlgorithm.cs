using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Clustering.Models;
using MedianMaintenance.Models;

namespace K_Clustering
{
    class GreedyAlgorithm
    {
        private int[] id;
        private int CountClusters = 4;
        public double MaxSpasing { get; set; }
        public GreedyAlgorithm(Graph graph)
        {
            var pq = new MinHeap(graph.E);
            for (int i = 0; i < graph.Edges.Count; i++)
            {
                pq.Insert(new Key(graph.Edges[i].Weight,i));
            }
            UF uf = new UF(graph.V);

            while (!pq.IsEmpty() && uf.Count!= CountClusters)
            {
                Key key = pq.DelMin();
                EdgeWeigth e = graph.Edges[key.Index];
                if(uf.connected(e.Node1,e.Node2)) continue;
                uf.union(e.Node1,e.Node2);
            }

            while (true)
            {
                Key key = pq.DelMin();
                EdgeWeigth e = graph.Edges[key.Index];
                if (!uf.connected(e.Node1, e.Node2))
                {
                    MaxSpasing = key.KeyValue;
                    break;
                }
            }
        }
    }
}
