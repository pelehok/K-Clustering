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
        private static string FileName = @"Clustering.txt"; 
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

            Graph graph = new Graph(Convert.ToInt32(lines[0]));

            for (int i = 2; i < lines.Length; i++)
            {
                string[] edge = lines[i].Split(' ');
                graph.AddEdge(new EdgeWeigth()
                {
                    Node1 = Convert.ToInt32(edge[0]) - 1,
                    Node2 = Convert.ToInt32(edge[1]) - 1,
                    Weight = Convert.ToDouble(edge[2])
                });
            }

            return graph;
        }
    }
}
