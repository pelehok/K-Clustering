using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering
{
    class Clusters
    {
        private int[] id;
        public int Count { get; set; }
        public Clusters(int n)
        {
            id = new int[n];
            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public void Add(int p, int q)
        {

        }
    }
}
