using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //!
            {
                bool isCheck = false;
                Console.WriteLine($"isCheck: {isCheck}");
                isCheck = !isCheck;
                Console.WriteLine($"isCheck: {isCheck}");
            }

            // && ||
            {
                Console.WriteLine("\n && ||");

                bool bTrue = true;
                bool bFalse = false;

                bool isResult = bTrue&& bFalse;// 둘이 동일해야함
                Console.WriteLine($"isResult: {isResult}");

                //둘다 true여야만 true
                Console.WriteLine($"bTrue && bTrue: \t{bTrue && bTrue}");
                Console.WriteLine($"bTrue && bFalse: \t{bTrue && bFalse} ");
                Console.WriteLine($"bFalse && bTrue: \t{bFalse && bTrue}");
                Console.WriteLine($"bFalse && bFalse: \t{bFalse && bFalse}");
                
                //어느 하나만 true여도 true
                Console.WriteLine($"bTrue && bTrue: \t{bTrue || bTrue}");
                Console.WriteLine($"bTrue && bFalse: \t{bTrue || bFalse} ");
                Console.WriteLine($"bFalse && bTrue: \t{bFalse || bTrue}");
                Console.WriteLine($"bFalse && bFalse: \t{bFalse || bFalse}");
            }

            // &, |, ^(XOR)
            {
                Console.WriteLine("\n &, |, ^(XOR)");

                bool bTrue = true;
                bool bFalse = false;
                Console.WriteLine($"bTrue ^ bTrue: \t\t{bTrue ^ bTrue}");
                Console.WriteLine($"bTrue ^ bFalse: \t{bTrue ^ bFalse}");
                Console.WriteLine($"bFalse ^ bTrue: \t{bFalse ^ bTrue}");
                Console.WriteLine($"bFalse ^ bFalse: \t{bFalse ^ bFalse}");
            }

            //Nullable(?)
            {
                Console.WriteLine("\n Nullable");

                //bool is = null;
                //? 가 붙으면 null을 가질 수 있게된다
                bool? test = null;
                Console.WriteLine($"!test: {!test}");//null
                Console.WriteLine($"!test ^ null: null");

                test = false;
                Console.WriteLine($"!test: {!test}");//true
            }

            //복합 할당 우선순위: !, &, |, &&, ||
            {
                Console.WriteLine("\n 복합 할당 우선순위: !, &, |, &&, ||");

                bool bTrue = true;
                bool bFalse = false;

                Console.WriteLine($"bTrue | bTrue & bFalse: {bTrue | bTrue & bFalse}");
                Console.WriteLine($"(bTrue | bTrue) & bFalse: {(bTrue | bTrue) & bFalse}");
                Console.WriteLine($"!bTrue | !bTrue & !bFalse: {!bTrue | !bTrue & !bFalse}");
            }
        }
    }
}
