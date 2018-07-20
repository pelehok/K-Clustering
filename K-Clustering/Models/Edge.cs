using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class Edge
    {
        public INode node1 { get; set; } 
        public INode node2 { get; set; }

        public double Weight
        {
            get { return node1.GetWeith(node2); }
        }
    }
}
