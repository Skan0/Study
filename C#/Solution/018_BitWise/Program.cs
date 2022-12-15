using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_BitWise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                sbyte byteNum1 = 0b00001111;
                sbyte byteNum2 = 0b_0000_0011;

                var resultValue = byteNum1 & byteNum2;

                Console.WriteLine($"byteNum1 & byteNum2: {byteNum1 & byteNum2}");
                Console.WriteLine($"Type: {resultValue.GetType()}");
                Console.WriteLine(Convert.ToString(resultValue, 2));//2진수로 찍어보라는 의미


                resultValue = byteNum1 | byteNum2;
                Console.WriteLine($"byteNum1 | byteNum2: {byteNum1 | byteNum2}");
                Console.WriteLine(Convert.ToString(resultValue, 2));
            }

            //>>, <<
            {
                Console.WriteLine("\n >>, <<");//shift 연산자
                uint uintOption = 0x01;
                Console.WriteLine(Convert.ToString(uintOption, 2));
                Console.WriteLine(Convert.ToString(uintOption << 1, 2));
                Console.WriteLine(Convert.ToString(uintOption<< 2, 2));

                uintOption = 0b0000_1000;
                Console.WriteLine(Convert.ToString(uintOption >> 1, 2));
                Console.WriteLine(Convert.ToString(uintOption >> 2, 2));
            }

            //^, ~
            {
                uint a = 0b_1111_1000;
                uint b = 0b_1001_1010;
                uint c = 0b_1111_1111;
                //a의 값을 거꾸로 출력한다
                Console.WriteLine(Convert.ToString(~a, 2));
                Console.WriteLine(Convert.ToString(~~a, 2));
                
                //두개가 같으면 0 다르면 1
                Console.WriteLine(Convert.ToString(b^c, 2));
            }
        }
    }
}
