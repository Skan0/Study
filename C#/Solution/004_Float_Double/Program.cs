using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                float fNum = 0.0001f;
                double dNum = 123456.9;
                Console.WriteLine($"fNum: {fNum}");
                Console.WriteLine($"dNum: {dNum}");
            }

            //수치 접미사
            {
                Console.WriteLine("\n 수치 접미사");

                float fNum = 0.00014F;
                double dNum = 231231.3d;

                Console.WriteLine($"fNum: {fNum}");
                Console.WriteLine($"dNum: {dNum}");
            }

            //타입 & 크기
            {
                Console.WriteLine("\n타입 & 크기");

                float fNum = 0.00034f;

                Console.WriteLine($"Type: {fNum.GetType()} sizeof: {sizeof(float)}byte");
                Console.WriteLine($"Type: {43425234.44.GetType()} sizeof: {sizeof(double)}byte");
            }
            //저장 가능 범위
            {
                Console.WriteLine("\n저장 가능 범위");
                float minFloat = float.MinValue;
                float maxFloat = float.MaxValue;
                Console.WriteLine($"minFloat: {minFloat}");
                Console.WriteLine($"maxFloat: {maxFloat}");

            }
            //1E-07 ==> 소수점을 부터 7번째 자리에 1이 있다

            //지수표현 방식
            {
                /*
                 * 1.2345f
                 * 12.345e-1f
                 * 123.45e-2f
                 * 1234.5e-3f
                 * 0.12345e1f
                 * 0.012345e2f
                 */
            }
        }
    }
}
