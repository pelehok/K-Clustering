using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Clustering.Models;
using K_Clustering.Services;

namespace K_Clustering
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = FileService.ReadNode();
            GreedyAlgorithm greedy = new GreedyAlgorithm(graph);

            Console.WriteLine(greedy.MaxSpasing);
            Console.ReadKey();
        }
    }
}
