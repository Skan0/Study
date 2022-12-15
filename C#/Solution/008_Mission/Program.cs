using System;
namespace _008_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.Write("정수를 입력하세요: ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"num1: {num1} , num2: {num2}");
            bool isReal = num2 < num1;
            Console.WriteLine($"num1이 더 큰가요? {isReal}");
            isReal = num2 > num1;
            Console.WriteLine($"num2가 더 큰가요? {isReal}");
            //Console.WriteLine($"num1이 더 큰가요? {num2 < num1}");
            
            isReal = num2 >= num1;
            Console.WriteLine($"num1이 작거나 같은가? {isReal}");
            isReal = num2 <= num1;
            Console.WriteLine($"num2가 작거나 같은가? {isReal}");
            //Console.WriteLine($"{num1 <= num2}");
            
            isReal = num1 == num2;
            Console.WriteLine($"두수가 같은가? {isReal}");
            isReal = num1 != num2;
            Console.WriteLine($"두수가 다른가? {isReal}");
        }
    }
}
