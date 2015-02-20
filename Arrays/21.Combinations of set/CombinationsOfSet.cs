using System;
using System.Collections.Generic;

//Write a program that reads two numbers N and K and generates all
//the combinations of K distinct elements from the set [1..N].

namespace _21.Combinations_of_set
{
    class CombinationsOfSet
    {
        static void Combinations(List<int> list, List<int> comb, int k)
        {
            if (k > 0)
            {
                List<int> copyComb = new List<int>(comb);
                List<int> copyList = new List<int>(list);
                copyComb.Add(copyList[0]);
                copyList.RemoveAt(0);
                Combinations(copyList, copyComb, k - 1);
                if (k <= copyList.Count)
                {
                    Combinations(copyList, comb, k);
                }
            }
            else
            {
                for (int i = 0; i < comb.Count; i++)
                {
                    Console.Write("{0} ", comb[i]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Input k:");
            int k = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            List<int> comb = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }

            Combinations(list, comb, k);
        }
    }
}
