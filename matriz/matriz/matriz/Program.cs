﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] matriz = new int[3, 5];
            int[,] matriz2 = new int[3, 3];
            int[,] matriz3 = new int[3, 3];
            int l, c;
            Console.WriteLine("\n Informe os valores da primeira matriz: \n");
            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 5; c++)
                {
                    Console.Write("Digite o valor {0}X{1}: ",l + 1, c + 1);
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
         
          
            Console.WriteLine("\n Soma das matrizes: \n");
            for (l = 0; l < 3; l++)
            {
                for (c = 0; c < 5; c++)
                {
                
                        Console.Write(" {0}X{1}: {2} ", l + 1, c + 1,  matriz[l, c]);
                  
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
