using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class Node
    {
        public int NodeIndex { get; set; }
        public Byte24 _byte { get; set; }
        public double GetWeith(Node node)
        {
            int weight = 0;
            for (int i = 0; i < 24; i++)
            {
                if (this._byte.ValuesBytes[i] != node._byte.ValuesBytes[i])
                {
                    weight++;
                }
            }

            return weight;
        }
    }
}
