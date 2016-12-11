using System;
using System.Collections.Generic;

namespace DSA_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var G = CreateGraph();
            G.Show();
            Console.WriteLine();

            // BFS
            BreadthFirstSearch bfs = new BreadthFirstSearch(G);
            var path = bfs.VisitAll();

            Dictionary<int, char> vertexValueDictionary = CreateDictionaty();
            PrintResults(path, vertexValueDictionary);

            Console.WriteLine("\n");
            Console.WriteLine("After modification... \n");
            ModifyDictionary(vertexValueDictionary, path);
            PrintResults(path, vertexValueDictionary);


            Console.ReadLine();
        }

        private static void ModifyDictionary(Dictionary<int, char> vertexValueDictionary, List<int> path)
        {
            vertexValueDictionary.Clear();
            String name = "DenissOrlovs";
            for (int i = 0; i < name.Length; i++) vertexValueDictionary.Add(path[i], name[i]);
        }

        private static void PrintResults(List<int> path, Dictionary<int, char> vertexValueDictionary)
        {
            Console.WriteLine("Path: ");
            foreach (var vertex in path) Console.Write(vertex + " ");
            Console.WriteLine();
            Console.WriteLine("Path in letters: ");
            foreach (var vertex in path) Console.Write(vertexValueDictionary[vertex] + " ");
        }

        private static Dictionary<int, char> CreateDictionaty()
        {
            Dictionary<int, char> vertexValues = new Dictionary<int, char>();
            AddVertexValues(vertexValues);
            return vertexValues;
        }

        private static Graph CreateGraph()
        {
            Graph G = new Graph(12, 12);
            ConnectNodes(G);
            return G;
        }

        private static void AddVertexValues(Dictionary<int, char> vertexValues)
        {
            String name = "DenissOrlovs";
            for (int i = 0; i < name.Length; i++) vertexValues.Add(i, name[i]);
        }


        private static void ConnectNodes(Graph G)
        {
            G.Connect(0, 1);
            G.Connect(0, 4);
            G.Connect(0, 5);
            G.Connect(1, 0);

            G.Connect(1, 6);
            G.Connect(2, 5);
            G.Connect(2, 3);
            G.Connect(2, 5);
            G.Connect(2, 7);
            G.Connect(3, 2);
            G.Connect(3, 7);
            G.Connect(4, 0);
            G.Connect(4, 9);
            G.Connect(5, 0);

            G.Connect(5, 2);
            G.Connect(5, 6);
            G.Connect(6, 1);
            G.Connect(6, 5);
            G.Connect(6, 9);
            G.Connect(6, 11);
            G.Connect(7, 2);
            G.Connect(7, 3);
            G.Connect(8, 9);
            G.Connect(9, 4);
            G.Connect(9, 6);
            G.Connect(9, 8);
            G.Connect(10, 11);
            G.Connect(11, 6);
            G.Connect(11, 10);
        }

    }
    }
