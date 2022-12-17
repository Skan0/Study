using System;
namespace _012_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < 7 - 2 * i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            {
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 3; i < j; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = -1; k < 2*i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
