using System;

namespace _010_Mission
{
    enum Operate { A, B, C, D}
    internal class Program
    {
        static void Main(string[] args)
        {

            Operate operate = Operate.A;
            Console.WriteLine("심플 계산기");
            Console.Write("첫번째 수를 입력: ");
            int first_num = Convert.ToInt32(Console.ReadLine());

            Console.Write("덧셈(+), 뺄셈(-), 곱셈(*), 나눗셈(/) 중 하나 입력: ");
           // char oper = Console.ReadKey().KeyChar;
            string operStr = Console.ReadLine();
            Console.Write("\n두번째 수를 입력: ");
            int second_num = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            switch (operStr)
            {
                case "+": operate = Operate.A;break;
                case "-": operate = Operate.B;break;
                case "*": operate = Operate.C;break;
                case "/": operate = Operate.D;break;
                default:
                    break;
            }

            switch (operate)
            {
                case Operate.A: result = first_num + second_num; break;
                case Operate.B: result = first_num - second_num; break;
                case Operate.C: result = first_num * second_num; break;
                case Operate.D: result = first_num / second_num; break;
            }
            Console.WriteLine($"switch 계산결과 {result}");

            /*if (oper =='+'|| oper == '-'|| oper == '/'|| oper == '*')
            {
                switch (oper) {
                    case '+':
                        result = first_num + second_num;
                        break;
                    case '-':
                        result = first_num - second_num;
                        break;
                    case '*':
                        result = first_num * second_num;
                        break;
                    case '/':
                        result = first_num / second_num;
                        break;
                }
                Console.WriteLine($"연산 결과: {result}");
            
            }
            else
            {
                Console.WriteLine("연산자 입력 오류!");
            }*/
        }
    }
}
