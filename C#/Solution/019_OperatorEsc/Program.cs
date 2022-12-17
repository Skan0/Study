using System;

namespace _019_OperatorEsc
{
    internal class Program
    {
        public class AA { }
        static void Main(string[] args)
        {
            //삼항연산자 
            {
                int num = 10;
                bool isNum = (num == 10) ? true : false;
                //(조건식) ? 참 : 거짓
                int selectNum = (num!=10) ? 10 : 0;

                Console.WriteLine($"isNum: {isNum}");
                Console.WriteLine($"selectNum: {selectNum}");
            }

            //null 병합연산자(??)
            {
                Console.WriteLine("\n병합연산자 (?)");
                    
                int? nullNum1 = null;
                int num1 = 100;
                int? nullNum2 = null;
                int num2 = 1000;
                int? nullNum3 = 999;
                
                //물음표 앞에있는게 null인가 확인해보고 null이라면 뒤의 값을 가져오고 그렇지 않다면 자기 자신을 갖는다
                int result1 = nullNum1 ?? num1;
                Console.WriteLine($"result1: {result1}");

                int result2 = nullNum1 ?? nullNum2 ?? num2;
                Console.WriteLine($"result2: {result2}");

                int result3 = nullNum3 ?? nullNum2 ?? num2;
                Console.WriteLine($"result3: {result3}");
            }
            
            //typeof
            {
                Console.WriteLine($"{typeof(int)}");

                AA aa = new AA();

                Console.WriteLine($"{typeof(AA)}");
                Console.WriteLine(aa.GetType() == typeof(AA) ?"AA의 객체 입니다" : "AA의 객체가 아닙니다  ");
            }
        }
    }
}
