using System;
using System.Runtime.Versioning;

namespace _023_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기초 for(초기화; 조건; 증감) . .
            {
                for (int i = 0;i<5;i++)
                {
                    Console.Write("i: " + i,"    ");
                }
            }

            {
                Console.WriteLine("0 ~ 10까지의 합, 짝수의 합");
                int totalEven = 0;
                int total = 0;
                
                for(int i = 0; i <=10;i++)
                {
                    if (i % 2 == 0)
                    {
                        totalEven+=i;
                    }
                    total+=i;
                }

                Console.WriteLine($"totalEven: {totalEven}");
                Console.WriteLine($"total: {total}");
            }
            //중첩되는 for문
            {
                Console.WriteLine("\n중첩되는 for 문");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("i: "+i,"    ");
                    for (int f = 0; f < 5; f++)
                    {
                        Console.Write(" f: " + f,"   ");
                    }
                    Console.WriteLine();
                }
            }
            //구구단 출력
            {
                Console.WriteLine("\n구구단 출력");
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1;  j < 10 ;  j++)
                    {
                        Console.Write($"{i} * {j} = {i*j}\t");
                    }
                    Console.WriteLine() ;
                }
            }

        }
    }
}
