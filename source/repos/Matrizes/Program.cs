using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat = "";
            var menor = 0;
            int numsorteado = 0;
            int[] numeros = new int[9];
            int[,] array = new int[3, 5];
            for (int i = 0; i <= 2; i++)
            {
                for (int y = 0; y <= 4; y++)
                {
                    Random randNum = new Random();
                    randNum.Next();
                    numsorteado = randNum.Next(8);
                    numeros[numsorteado] = numeros[numsorteado] + 1;
                    while (numeros[numsorteado] > 2)
                    {
                        numsorteado = randNum.Next(8);
                        numeros[numsorteado] = numeros[numsorteado] + 1;
                    }
                    array[i, y] = numsorteado;
                    if (numeros[numsorteado]==1)
                    {
                        menor = numsorteado;
                    }
                    mat += array[i, y] + "|";
                    if (y == 4)
                    {
                        Console.WriteLine(mat);
                        mat = "";
                    }
                }
            }
            Console.WriteLine("Número que menos vezes apareceu na matriz é: " + menor);
            Console.ReadLine();
        }
    }
}
