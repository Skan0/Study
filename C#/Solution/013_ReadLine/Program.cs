using System;
namespace _013_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기초
            {
                Console.Write("문장을 입력하세요: ");
                var inputData = Console.ReadLine();
                Console.WriteLine("입력한값은 {0}", inputData);
                Console.WriteLine($"Type: {inputData.GetType()}");
                    
            }
            {
                Console.Write("정수를 입력하세요:");
                var strNum1 = Console.ReadLine();
                Console.Write("정수를 입력하세요:");
                var strNum2 = Console.ReadLine();
                Console.WriteLine($"입력 문자 {strNum1} { strNum2}");

                //strNum1 = int.Parse(strNum1);
                var num1 = int.Parse(strNum1);  
                var num2 = Convert.ToInt32(strNum2);
                Console.WriteLine($"num1: {num1}, Type: {num1.GetType()}");
                Console.WriteLine($"num2: {num2}, Type: {num2.GetType()}");
            }
            //read는 앞의 한개만 읽어내고 아스키코드 값으로 저장한다
            {
                Console.Write("문자 입력");
                var read = Console.Read();
                Console.WriteLine("입력문자: {0} TYPE: {0}", read,read.GetType());


            }
            //키보드 입력 읽기
            {
                ConsoleKeyInfo info;

                Console.Write("키를 누르세요");
                info = Console.ReadKey();
                Console.WriteLine($"입력한 키는: {info.Key}");

                Console.Write("키를 누르세요");
                info = Console.ReadKey(false);
                Console.WriteLine($"입력한 키는: {info.Key}");

                Console.Write("키를 누르세요");
                info = Console.ReadKey(true);
                Console.WriteLine($"입력한 키는: {info.Key}");
                //readkey에 true값을 넣으면 입력한 문자가 보이지 않는다
                Console.WriteLine($"\n{info.KeyChar}");
                Console.WriteLine($"\n{info.Modifiers}");
            }
        }
    }
}
