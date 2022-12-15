using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015______
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("전치증가, 후치증가");
                int num = 0;
                Console.WriteLine($"++num: {++num}");
                Console.WriteLine($"num++: {num++}");
                Console.WriteLine($"num: {num}");//num=2

                int total = num++ + 10;
                Console.WriteLine($"total: {total}");
                //num=3
                total = ++num + 10;//num=4
                Console.WriteLine($"total: {total}");
            }

            {
                Console.WriteLine("전치감소, 후치감소");
                float fNum = 10.5f;
                Console.WriteLine($"--fNum: {--fNum}");//9.5
                Console.WriteLine($"fNum--: {fNum--}");//9.5
                Console.WriteLine($"fNum: {fNum}");//8.5

                float fTotal = 10.0f + fNum--;
                Console.WriteLine(fTotal);
            }
            //복합 할당 연산자 (-= += /= *= %=)
            {
                //A = A + b     A += B
                //A = A - B     A -= B
                //A = A / B     A /= B 몫
                //A = A * B     A *= B
                //A = A % B     A %= B 나머지 

                int num = 0;
                num += 10;
                num *= 10;
                Console.WriteLine(num);
            }
        }
    }
}
