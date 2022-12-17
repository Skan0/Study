using System;

namespace _009_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //큰값을 찾아서 출력하느냐 상황별로 변수를 만들어 참인 값을 넣느냐

            Console.Write("정수를 입력하세요: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("정수를 입력하세요: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("정수를 입력하세요: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int big = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

            Console.WriteLine($"{num1}, {num2}, {num3}중에서 입력 값이 가장 큰것은 {big}이다");
        }
    }
}
