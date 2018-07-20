using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    class Node:INode
    {
        public int NodeIndex { get; set; }
        public double GetWeith(INode node)
        {
            throw new NotImplementedException();
        }
    }
}
