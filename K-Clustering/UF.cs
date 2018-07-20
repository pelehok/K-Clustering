using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace K_Clustering
{
    class UF
    {
        private int[] _id;
        public int Count { get; private set; }

        public UF(int N)
        {
            Count = N;
            _id = new int[N];
            for (int i = 0; i < N; i++)
            {
                _id[i] = i;
            }
        }

        public bool connected(int p, int q)
        {
            return Find(p) == Find(q);
        }

        public int Find(int p)
        {
            return _id[p];
        }
        public void union(int p, int q)
        { 
            int pID = Find(p);
            int qID = Find(q);
            if (pID == qID) return;
            for (int i = 0; i < _id.Length; i++)
                if (_id[i] == pID) _id[i] = qID;
            Count--;
        }

        public int GetMaxSpasing()
        {
            List<int> ids = _id.ToList();

            ids.Sort();
            int maxValue = 0;
            int tempValue = 0;
            for (int i = 0; i < ids.Count-1; i++)
            {
                if (ids[i] != ids[i + 1])
                {
                    if (tempValue > maxValue)
                    {
                        maxValue = tempValue;
                        tempValue = 0;
                    }
                }

                tempValue++;
            }

            return maxValue;
        }
    }
}
