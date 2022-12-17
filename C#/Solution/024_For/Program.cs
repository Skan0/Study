using System;

namespace _024_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //숫자의 자리수를 구하기
            {
                int num = 479;

                int DigitOfOne = 0;
                int DigitOfTen = 0;
                int DigitOfHundred = 0;
                
                Console.WriteLine($"num: {num}");

                DigitOfOne = num % 10;
                Console.WriteLine($"DigitOfOne: {DigitOfOne}");

                num /= 10;
                DigitOfTen = num % 10;
                Console.WriteLine($"DigitOfTen: {DigitOfTen}");

                num/= 10;
                DigitOfHundred = num % 10;
                Console.WriteLine($"DigitOfHundred: {DigitOfHundred}");

                num = 479;

                int temp;
                for (int i = 0; i < 3; i++)
                {
                    temp = num % 10;
                    
                    if(i==0)
                    {
                        DigitOfOne= temp;
                    }
                    else if(i==1)
                    {
                        DigitOfTen = temp;
                    }
                    else if(i==2)
                    {
                        DigitOfHundred = temp;
                    }

                    num /= 10;

                    Console.WriteLine($"DigitOfOne: {DigitOfOne}");
                    Console.WriteLine($"DigitOfTen: {DigitOfTen}");
                    Console.WriteLine($"DigitOfHundred: {DigitOfHundred}");
                }
            }
        }
    }
}
