using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기초 
            {
                char chA = 'A';
                char chHan = '한';

                Console.WriteLine($"chA: {chA}\nchHan: {chHan}");
            }

            //타입크기
            {
                Console.WriteLine("\n타입 크기");

                char chA = 'A';
                Console.WriteLine($"Size of {sizeof(char)}byte\nType: {typeof(char)}");
                Console.WriteLine($"Type: {chA.GetType()}");
            }

            //저장 범위
            {
                Console.WriteLine("\n저장 범위");

                int minValue= char.MinValue;
                int maxValue=char.MaxValue;
                Console.WriteLine($"char: {minValue} ~ {maxValue}");
            }

            //리터럴
            {
                Console.WriteLine("\n리터럴");
                char ch0 = 'ㅓ';
                char ch1 = '\u006a';
                char ch2 = '\x6A';//u를 붙인 16진수는 00을 붙여야한다
                char ch3 = (char)106;//아스키크드 값으로 나온것

                Console.WriteLine($"ch0: {ch0}\nch1: {ch1}\nch2: {ch2}\nch3: {ch3}");
            }
            //변환
            {
                Console.WriteLine("\n변환");

                char chVar = 'A';
                int numCh = chVar;
                Console.WriteLine($"numCh: {numCh}");//65 A의 아스키코드 값
                
                numCh = 66;
                chVar = (char)numCh;
                Console.WriteLine($"chVar: {chVar}");

                int result = chVar + 'B';
                Console.WriteLine($"result: {result}");
                Console.WriteLine($"result: {(char)result}");
            }
        }
    }
}
