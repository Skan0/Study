using System;

namespace _014_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int num1 = 10, num2 = 100;
                int sum = num1 + num2;
                Console.WriteLine(sum);
                Console.WriteLine(num1 - num2);
                Console.WriteLine(num2 * num1);
                Console.WriteLine(num2 / num1);
                Console.WriteLine(num1 % num2);

                //byte
                byte b = 100;
                Console.WriteLine(b.GetType());
                Console.WriteLine((b + 10).GetType());
                b = (byte)(b + 10);
                var result = (b + 10);
                Console.WriteLine(result.GetType());
                Console.WriteLine();
            }

            //복합연산
            {
                int num = 1 - 2 * 3 + 4;
                Console.WriteLine(num);

                num = (1 - 2) * (3 + 4);
                Console.WriteLine(num);

                num = 4 * 6 / 4 * 2;
                Console.WriteLine(num);
            }
        }

    }
}
