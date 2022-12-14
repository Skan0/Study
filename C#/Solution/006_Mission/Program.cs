using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수의 합을 구해요");
            Console.Write("첫번째 수를 넣어 주세요.");
            var first = Console.ReadLine();
            Console.Write("두번째 수를 넣어 주세요.");
            var second = Console.ReadLine();
            var sum = int.Parse(first) + int.Parse(second);

            Console.WriteLine($"입력한 수는 {first} + {second} = {sum}");
        }
    }
}
