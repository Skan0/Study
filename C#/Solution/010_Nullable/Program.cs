using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = 100;
            double? dNum = 32123123.123123d;

            Console.WriteLine($"num: {num}");
            Console.WriteLine($"num: {num.Value}");
            Console.WriteLine($"num: {num.HasValue}");
            Console.WriteLine($"num: {num.GetType()}");
            

            Console.WriteLine($"dNum: {dNum}");
            Console.WriteLine($"dNum: {dNum.Value}");
            Console.WriteLine($"dNum: {dNum.HasValue}");
            Console.WriteLine($"dNum: {dNum.GetType()}");


            num = null;
            num = num.GetValueOrDefault();
            Console.WriteLine($"{num.HasValue}");
            //if(num.HasValue)
            //Console.WriteLine($"num: {num.GetType()}");

            //변환
            {// 명시적으로 형변환을 해줘야만 값이 들어가진다
                int? nullNum = 100;
                int numCast = (int)nullNum;
            }
        }
    }
}
