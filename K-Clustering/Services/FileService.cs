using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Clustering.Models;

namespace K_Clustering.Services
{
    class FileService
    {
        private static string FileName = @"Clustering_big.txt"; 
        public static Graph ReadNode()
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);

            Graph graph = new Graph(Convert.ToInt32(lines[0]));

            for (int i = 2; i < lines.Length; i++)
            {
                string[] edge = lines[i].Split(' ');
                graph.AddEdge(new EdgeWeigth()
                {
                    Node1 = Convert.ToInt32(edge[0])-1,
                    Node2 = Convert.ToInt32(edge[1])-1,
                    Weight = Convert.ToDouble(edge[2])
                });
            }

            return graph;
        }
        public static Graph ReadNodeByte()
        {
            string[] lines = System.IO.File.ReadAllLines(FileName);
            string[] sizes = lines[0].Split(' ');
            Graph graph = new Graph(Convert.ToInt32(sizes[0]));
            List<Node> nodes = new List<Node>();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] edge = lines[i].Split(' ');
                byte[] bytes = new byte[24];
                for (int j = 0; j < 24; j++)
                {
                    bytes[j] = Convert.ToByte(edge[j]);
                }
                nodes.Add(new Node()
                {
                    _byte = new Byte24(){ ValuesBytes = bytes},
                    NodeIndex = i-1
                });
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = i+1; j < nodes.Count; j++)
                {
                    graph.AddEdge(new EdgeWeigth()
                    {
                        Node1 = nodes[i].NodeIndex,
                        Node2 = nodes[j].NodeIndex,
                        Weight = nodes[i].GetWeith(nodes[j])
                    });
                }
            }

            return graph;
        }
    }
}
