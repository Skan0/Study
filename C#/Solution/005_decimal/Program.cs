using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//수치접미사 m,M 이용
                decimal dcNum = 23123131313.01231023M;
                Console.WriteLine(dcNum);
            }
            //타입 & 크기
            {
                Console.WriteLine("\n타입 & 크기");

                decimal dcNum = 23123131313.01231023M;

                Console.WriteLine($"Type: {dcNum.GetType()} sizeof: {sizeof(decimal)}byte");
            }
            //저장 가능 범위
            {
                Console.WriteLine("\n저장 가능 범위");
                decimal minFloat = decimal.MinValue;
                decimal maxFloat = decimal.MaxValue;
                Console.WriteLine($"mindecimal: {minFloat}");
                Console.WriteLine($"maxdecimal: {maxFloat}");

            }
        }
    }
}
