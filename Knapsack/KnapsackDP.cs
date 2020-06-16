using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    static class KnapsackDP
    {
        static int[][] M { get; set; } //ma tra ket qua
        static int[][] P { get; set; } //item duoc chon
        static Item[] I { get; set; } 
        public static int MaxValue { get; private set; }
        static int W { get; set; } //khoi luong toi da

        public static void Init(List<Item> items, int maxWeight)
        {
            I = items.ToArray();
            W = maxWeight;

            var n = I.Length;
            M = new int[n][];
            P = new int[n][];
            for (var i = 0; i < M.Length; i++) { M[i] = new int[W + 1]; }
            for (var i = 0; i < P.Length; i++) { P[i] = new int[W + 1]; }
        }

        public static void Run()
        {
            MaxValue = Recursive(I.Length - 1, W, 1);
        }

        static int Recursive(int i, int w, int depth)
        {
            var take = 0;
            if (M[i][w] != 0) { return M[i][w]; }

            if (i == 0)
            {
                if (I[i].w <= w)
                {
                    P[i][w] = 1;
                    M[i][w] = I[0].v;
                    return I[i].v;
                }

                P[i][w] = -1;
                M[i][w] = 0;
                return 0;
            }

            if (I[i].w <= w)
            {
                take = I[i].v + Recursive(i - 1, w - I[i].w, depth + 1);
            }

            var dontTake = Recursive(i - 1, w, depth + 1);

            M[i][w] = Max(take, dontTake);

            if (take > dontTake) { P[i][w] = 1; }
            else { P[i][w] = -1; }

            return M[i][w];
        }

        public static string Print()
        {
            string result = "";
            var list = new List<Item>();
            list.AddRange(I);
            var w = W;
            var i = list.Count - 1;
            var valueSum = 0;
            var weightSum = 0;
            while (i >= 0 && w >= 0)
            {
                if (P[i][w] == 1)
                {
                    valueSum += list[i].v;
                    weightSum += list[i].w;
                    result += (i+1) + " ";
                    w -= list[i].w;
                }
                i--;
            }
            return result;
        }

        public static void SavePicksMatrix(string path)
        {
            StreamWriter sw = new StreamWriter(path);          
            foreach (var i in P)
            {
                foreach (var j in i)
                {
                    var s = j.ToString();
                    sw.Write(s + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
