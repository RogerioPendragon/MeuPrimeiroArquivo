using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite os códigos dos alunos do curso A: ");
            string[] values = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                A.Add(int.Parse(values[i]));
            }
            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Digite os códigos dos alunos do curso B: ");
            values = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                B.Add(int.Parse(values[i]));
            }
            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Digite os códigos dos alunos do curso C: ");
            values = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                C.Add(int.Parse(values[i]));
            }

            A.UnionWith(B);
            A.UnionWith(C);
            int cont = 0;
            foreach (int x in A)
            {
                cont++;
            }
            Console.WriteLine("Total de alunos:" + cont);
            Console.ReadLine();

        }
    }
}
