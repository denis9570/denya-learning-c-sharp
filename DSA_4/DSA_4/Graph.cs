using System;
using System.Collections.Generic;

namespace DSA_4
{
    public class Graph
    {
        public int MaxEdges { get; private set; }
        public int MaxVertexes { get; private set; }

        public bool[,] Matrix { get; set; }



        /* Constructor */
        public Graph(int maxEdges, int maxVertexes)
        {
            MaxEdges = maxEdges;
            MaxVertexes = maxVertexes;

            Matrix = new bool[MaxVertexes, MaxEdges];
        }

        /* Misc methods */
        public void Connect(int vertex1, int vertex2)
        {
            Matrix[vertex1, vertex2] = true;

        }


        public void Show()
        {
            for (int vertexIndex = 0; vertexIndex < MaxVertexes; vertexIndex++)
            {
                for (int edgeIndex = 0; edgeIndex < MaxEdges; edgeIndex++)
                {
                    if (IsMarkedInMatrix(vertexIndex, edgeIndex)) Console.Write(" 1 ");
                    else Console.Write(" 0 ");
                }
                Console.WriteLine();
            }
        }

        /* Private helper methods */
        private bool IsMarkedInMatrix(int vertexIndex, int edgeIndex)
        {
            return Matrix[vertexIndex, edgeIndex];
        }
    }
}