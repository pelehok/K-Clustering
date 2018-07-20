using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class WeightData
    {
        private List<EdgeWeigth> Edges { get; set; }

        public WeightData(List<EdgeWeigth> edges)
        {
            Edges = edges;
        }
        public double GetWeigth(Node node1,Node node2)
        {
            return 0;
            //return Edges.First(x => (x.Node1 == node1 && x.Node2 == node2) ||
            //                        (x.Node1 == node2 && x.Node2 == node1)).Weight;
        }
    }
}
