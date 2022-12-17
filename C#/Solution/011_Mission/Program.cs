using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Mission
{
    enum OPERATOR { A, B, C, D }
    internal class Program
    {
        static void Main(string[] args)
        {
            int first_num = 10, second_num = 0, result = 0;
            string operStr;
            while (true)
            {
                OPERATOR operate = OPERATOR.A;

                Console.WriteLine("심플 계산기");
                Console.Write("첫번째 수를 입력: ");
                first_num = Convert.ToInt32(Console.ReadLine());
                if (first_num == 0) break;
                
                Console.Write("덧셈(+), 뺄셈(-), 곱셈(*), 나눗셈(/) 중 하나 입력: ");
                operStr = Console.ReadLine();

                Console.Write("\n두번째 수를 입력: ");
                second_num = Convert.ToInt32(Console.ReadLine());

                if (operStr == "+" || operStr == "-" || operStr == "*" || operStr == "/")
                {
                    if (operStr == "+") result = first_num + second_num;
                    else if (operStr == "-")result = first_num - second_num;
                    else if (operStr == "*")result = first_num * second_num;
                    else result = first_num / second_num;

                }
                else
                    Console.WriteLine("연산식 입력오류!");

                Console.WriteLine($"IF결과값: {first_num} {operStr} {second_num} = {result}");

                switch (operStr)
                {
                    case "+": operate = OPERATOR.A; break;
                    case "-": operate = OPERATOR.B; break;
                    case "*": operate = OPERATOR.C; break;
                    case "/": operate = OPERATOR.D; break;
                    default: break;
                }
                switch (operate)
                {
                    case OPERATOR.A: result = first_num + second_num; break;
                    case OPERATOR.B: result = first_num - second_num; break;
                    case OPERATOR.C: result = first_num * second_num; break;
                    case OPERATOR.D: result = first_num / second_num; break;
                }
                Console.WriteLine($"SWITCH 결과값: {first_num} {operate} {second_num} = {result}"); ;
            }
        }
    }
}
