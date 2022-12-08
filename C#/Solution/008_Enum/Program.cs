using System;

namespace _008_Enum
{
    internal class Program
    {
        enum COLOR_TYPE
        {
            WHITE,
            RED,
            BLUE,
            SIZE,
        }
        enum DAY: ushort
        {
            MON, TUE, WED, TUR, FRI, SAT, SUN
        }
        enum NUMBER
        {
            one,
            two,
            three,
            five = 5,
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"COLOR_TYPE.WHITE {COLOR_TYPE.WHITE }");
            Console.WriteLine($"COLOR_TYPE.BLUE {COLOR_TYPE.BLUE}");


            Console.WriteLine($"COLOR_TYPE.WHITE {(int)COLOR_TYPE.BLUE}");
            Console.WriteLine($"COLOR_TYPE.BLUE {(int)COLOR_TYPE.WHITE}");

            

            //변환
            {
                DAY day = DAY.MON;

                Console.WriteLine($"DAY.MON: {(short)DAY.MON} day = {day}");

                int total = (short)DAY.MON+ (short)DAY.SUN;

                Console.WriteLine($"total = {total}");
            }
        }
    }
}
