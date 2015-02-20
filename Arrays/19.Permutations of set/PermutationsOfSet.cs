using System;
using System.Collections.Generic;

//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

namespace _19.Permutations_of_set
{
    class PermutationsOfSet
    {
        static void Permutations(List<int> list, List<int> perm)
        {
            if (list.Count == 1)
            {
                perm.Add(list[0]);
                for (int i = 0; i < perm.Count; i++)
                {
                    Console.Write("{0} ", perm[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    List<int> copyList = new List<int>(list);
                    List<int> copyPerm = new List<int>(perm);
                    copyPerm.Add(copyList[i]);
                    copyList.RemoveAt(i);
                    Permutations(copyList, copyPerm);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            List<int> perm = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }

            Permutations(list, perm);
        }
    }
}
