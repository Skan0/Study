using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"sbyte\tMin: {ulong.MinValue}\t\t~ Max: {ulong.MaxValue}");
            Console.WriteLine($"byte\tMin: {byte.MinValue}\t\t~ Max: {byte.MaxValue}");
            Console.WriteLine($"short\tMin: {short.MinValue}\t~ Max: {short.MaxValue}");
            Console.WriteLine($"ushort\tMin: {ushort.MinValue}\t\t~ Max: {ushort.MaxValue}");
            Console.WriteLine($"int\tMin: {int.MinValue}~ Max: {int.MaxValue}");
            Console.WriteLine($"uint\tMin: {uint.MinValue}\t\t~ Max: {uint.MaxValue}");
            Console.WriteLine($"long\tMin: {long.MinValue}\t\t~ Max: {long.MaxValue}");
            Console.WriteLine($"ulong\tMin: {ulong.MinValue}\t\t~ Max: {ulong.MaxValue}");
        }

        static void professor()
        {
            sbyte minSbyte = sbyte.MinValue;
            sbyte maxSbyte = sbyte.MaxValue;

            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            short minShort = short.MinValue;
            short maxShort = short.MaxValue;

            ushort minUshort = ushort.MinValue;
            ushort maxUshort = ushort.MaxValue;

            int minint = int.MinValue;
            int maxint = int.MaxValue;

            long minLong = long.minvalue;
            long maxLong = long.maxvalue;

            ulong minUlong = ulong.minvalue;
            ulong maxUlong = ulong.maxvalue;

            Console.WriteLine($"sbyte\tMin: {ulong.MinValue}\t\t~ Max: {ulong.MaxValue}");
            Console.WriteLine($"byte\tMin: {byte.MinValue}\t\t~ Max: {byte.MaxValue}");
            Console.WriteLine($"short\tMin: {short.MinValue}\t~ Max: {short.MaxValue}");
            Console.WriteLine($"ushort\tMin: {ushort.MinValue}\t\t~ Max: {ushort.MaxValue}");
            Console.WriteLine($"int\tMin: {int.MinValue}~ Max: {int.MaxValue}");
            Console.WriteLine($"uint\tMin: {uint.MinValue}\t\t~ Max: {uint.MaxValue}");
            Console.WriteLine($"long\tMin: {long.MinValue}\t\t~ Max: {long.MaxValue}");
            Console.WriteLine($"ulong\tMin: {ulong.MinValue}\t\t~ Max: {ulong.MaxValue}");

            // 내가 한 방법과 다른것은 바로 값을 넣은것과 변수를 만들어서 넣은것의 차이
        }
    }
}
