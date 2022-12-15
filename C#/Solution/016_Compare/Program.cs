using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // < >
            {
                bool isResult1 = 5 < 3;
                bool isResult2 = 5 > 3;

                Console.WriteLine($"isResult1: " + isResult1);
                Console.WriteLine($"isResult2: " + isResult2);

                bool isResult3 = 0.14f < 0.2345f;
                bool isResult4 = 0.14f > 0.2345f;

                Console.WriteLine($"isResult3: " + isResult3);
                Console.WriteLine($"isResult4: " + isResult4);
            }
            //== !=
            {
                bool isEqual1 = (5 == 5);
                bool isEqual2 = (5 == 6);
                Console.WriteLine($"(5==5): {isEqual1}");
                Console.WriteLine($"(5==6): {isEqual2}");

                bool isEqual3 = (50 != 50);
                bool isEqual4 = (50 != 60);
                Console.WriteLine($"(50 != 50): {isEqual3}");
                Console.WriteLine($"(50 != 60): {isEqual4}");
            }

            //<= >=
            {
                bool isResult1 = (5 >= 6);
                bool isResult2 = (6 >= 6);
                bool isResult3 = (10 >= 6);
                bool isResult4 = (6 <= 5);

                Console.WriteLine($"(5 >= 6): {isResult1}");
                Console.WriteLine($"(6 >= 6): {isResult2}");
                Console.WriteLine($"(10 >= 6): {isResult3}");
                Console.WriteLine($"(6 <= 5): {isResult4}");
            }
        }
    }
}
