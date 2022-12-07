using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"float\tMin: {float.MinValue}\t\t~ Max: {float.MaxValue}");
            Console.WriteLine($"double\tMin: {double.MinValue}\t\t~ Max: {double.MaxValue}");
            Console.WriteLine($"decimal\tMin: {decimal.MinValue}\t\t~ Max: {decimal.MaxValue}");
        }
    }
}
