using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering.Models
{
    interface INode
    {
        double GetWeith(INode node);
    }
}
