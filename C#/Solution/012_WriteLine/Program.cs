using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            float fNum = 0.2341234f;
            double dNum = 12345555.0;

            Console.WriteLine("{0} {1} {2} {2} {1}", num, fNum, dNum);
            Console.WriteLine("{0:D}, {0:D8}", num);
            //Console.WriteLine("{0:D}, {0:D8}", num); 에서 D뒤의 수가 변수의 문자수보다 많으면 0으로 채워주고 적으면 변수를 다 출력한다
            Console.WriteLine("{0}, {0:F}, {0:F3}, {0:F10}", fNum);//0:F@ @가 소수점뒤의 숫자 수를 정한다
            Console.WriteLine("{0}, {0:E}, {0:E2}", dNum);//0:E@ 뒤에서 부터 @개의 수들을 E+0으로 바꾼다
            Console.WriteLine("0x{0:X}", num);//16진수의 값을 나타낸다.

            Console.WriteLine("{0:C3}, {1} ", num, num.ToString("C"));//각나라의 재화 값으로 나타낸다
            Console.WriteLine("{0:N}, {0:N1 }, {0:N3} ", num);//N은 기본적으로 소수점 2개 
            Console.WriteLine("{0:P}, {0:P1}, {0:P0}", num);//재화의 값을 변경할 때 

            double d1 = 12345.455567;
            Console.WriteLine($"{d1:#.####}");//#의 개수만큼 소수점뒤로 출력
            Console.WriteLine($"{d1:00.00000}");

            double d2 = 123456.9;
            Console.WriteLine($"{d2:#,##0.0}");//숫자 중간에 ,를 사용가능하다

            double d = 11111231321312;
            Console.WriteLine($"{d:(###) ###-####}");
        }
    }
}
