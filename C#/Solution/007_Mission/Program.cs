using System;

namespace _007_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20, total = 0;
            //num1--*2+ ++num2 - 10+ --num1 *(num2++ %2)
            total = num1--;
            total *= 2;
            total += ++num2;
            total -= 10;
            total += --num1;
            total *= num2++ % 2;
            Console.WriteLine(total);
        }
    }
}
