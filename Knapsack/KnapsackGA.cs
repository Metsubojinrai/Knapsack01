using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    static class KnapsackGA
    {
        static Random rand = new Random();
        static Item[] I { get; set; }
        static int W { get; set; }
        static List<int> best = new List<int>();

        public static void Init(List<Item> items, int maxWeight)
        {
            I = items.ToArray();
            W = maxWeight;
        }

        //Hàm khởi tạo quần thể
        public static List<string> generate(int popSize)
        {
            List<string> pop = new List<string>();

            for (int i = 0; i < popSize; i++)
            {
                string gene = "";
                for (int j = 0; j < I.Length; j++)
                {
                    if (rand.NextDouble() > 0.5) gene += 1;
                    else gene += 0;
                }
                pop.Add(gene);
            }
            return pop;
        }

        //Hàm tính độ thích nghi
        public static List<int> getFitness(List<string> pop)
        {
            List<int> fitness = new List<int>();
            for (int i = 0; i < pop.Count; i++)
            {
                int value = 0;
                int weight = W + 1;
                while (weight > W)
                {
                    weight = 0;
                    value = 0;
                    List<int> ones = new List<int>();
                    for (int j = 0; j < pop[i].Length; j++)
                    {
                        if (pop[i][j] == '1')
                        {
                            weight += I[j].w;
                            value += I[j].v;
                            ones.Add(j);
                        }
                    }
                    if (weight > W)
                    {
                        StringBuilder newGene = new StringBuilder(pop[i]);
                        newGene[ones[rand.Next(0, ones.Count - 1)]] = '0';
                        pop[i] = newGene.ToString();
                    }
                }
                fitness.Add(value);
            }
            return fitness;
        }

        //Hàm khởi tạo quần thể mới
        public static List<string> newPopulation(List<string> pop, List<int> fit, double mut, double cross)
        {
            int popSize = pop.Count;
            List<string> newPop = new List<string>();
            newPop.Add(selectElite(pop, fit));
            while (newPop.Count < popSize)
            {
                newPop.Add(mutate(crossover(pop, fit, cross), mut));
            }
            return newPop;
        }

        //Hàm chọn cá thể tốt nhất
        public static string selectElite(List<string> pop, List<int> fit)
        {
            int elite = 0;
            for (int i = 0; i < fit.Count; i++)
            {
                if (fit[i] > fit[elite])
                    elite = i;
            }
            return pop[elite];
        }

        //Hàm lai ghép
        public static string crossover(List<string> pop, List<int> fit, double crossoverProb)
        {
            int totalfit = fit.Sum();
            int lucky = rand.Next(0, totalfit);
            int tempSum = 0;
            string mate1 = "";
            string mate2 = "";

            for (int i = 0; i < pop.Count; i++)
            {
                tempSum += fit[i];
                if (tempSum >= lucky)
                {
                    mate1 = pop[i];
                    break;
                }
            }
            tempSum = 0;
            lucky = rand.Next(0, totalfit);
            for (int i = 0; i < pop.Count; i++)
            {
                tempSum += fit[i];
                if (tempSum >= lucky)
                {
                    mate2 = pop[i];
                    break;
                }
            }
            if (rand.NextDouble() < crossoverProb)
            {
                lucky = rand.Next(0, mate1.Length - 1);
                return mate1.Substring(0, lucky) + mate2.Substring(lucky);
            }
            else return mate1;
        }

        //Hàm đột biến
        public static string mutate(string gene, double mut)
        {
            for (int i = 0; i < gene.Length; i++)
            {
                if (rand.NextDouble() < mut)
                {
                    StringBuilder tempGene = new StringBuilder(gene);
                    tempGene[i] = '0';
                    gene = tempGene.ToString();
                }
            }
            return gene;
        }

        //Kiểm tra độ hội tụ của quần thể
        public static bool test(List<int> fit, double rate)
        {
            int maxCount = mode(fit);
            if ((double)(maxCount) / (double)(fit.Count) >= rate)
                return true;
            else return false;
        }

        //Đếm số lượng gen tốt nhất
        public static int mode(List<int> fit)
        {
            int maxCount = 0;
            foreach (int f in fit)
            {
                if (maxCount < fit.Where(x => x.Equals(f)).Count())
                    maxCount = fit.Where(x => x.Equals(f)).Count();
            }
            return maxCount;
        }

        public static List<int> BestFit(List<int> fitness)
        {
            int fit = fitness.Max();
            best.Add(fit);
            return best;
        }
    }
}
