using System;
using System.Collections.Generic;


namespace DSA_4
{
    public class BreadthFirstSearch
    {

        Graph G;

        public BreadthFirstSearch(Graph G)//
        {
            this.G = G;
        }

        /**
         * @return path which we found
         */
        public List<int> VisitAll()
        {
            List<List<int>> spisokincidentnosti = new List<List<int>>();

            for (var j = 0; j < G.Matrix.GetLength(0); j++)
            {
                spisokincidentnosti.Add(new List<int>());
                for (var i = 0; i < G.Matrix.GetLength(1); i++)
                {

                    var isOne = G.Matrix[j, i];
                    if (isOne == true)
                    {
                        spisokincidentnosti[j].Add(i);
                    }

                }
            }

            for (var i = 0; i < spisokincidentnosti.Count; ++i)
            {
                Console.Write(i + ": ");
                for (var j = 0; j < spisokincidentnosti[i].Count; ++j)
                {
                    Console.Write(spisokincidentnosti[i][j] + " ");
                }
                Console.WriteLine();
            }

            return BFS(spisokincidentnosti);
        }

        private static List<int> BFS(List<List<int>> spisokincidentnosti)
        {

            var path = new List<int>{0};

            var ResultIndex = 0;


            while (ResultIndex < path.Count)
            {
                var verticle = path[ResultIndex++];
                var row = spisokincidentnosti[verticle];
                foreach (var sosed in row)
                {
                    if (!path.Contains(sosed))
                    {
                        path.Add(sosed);
                    }
                }


            }

            return path;
        }


    }
}