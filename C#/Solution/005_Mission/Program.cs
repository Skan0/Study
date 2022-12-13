using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("당신의 이름은? ");
            var name = Console.ReadLine();
            Console.Write("당신의 나이는? ");
            var age = Console.ReadLine();
            Console.Write("당신의 성별은? ");
            var gender = Console.ReadLine();
            Console.WriteLine($"이름: {name}, 나이: {age}, 성별: {gender}");
        }
    }
}
