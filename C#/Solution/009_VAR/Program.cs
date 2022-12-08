using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_VAR
{
    internal class Program
    {
        //var umVar = 100;                   사용불가(멤버변수 사용불가)
        //static var Func() { }              함수의 반환형으로 사용 불가
        //static void Func(var a, var b)     함수의 파라미터로 사용불가
        static void Main(string[] args)
        {
            var num = 0;
            var numFVar = 0.0001f;

            Console.WriteLine(num);
            Console.WriteLine(numFVar);
            
            //var numNull = null;            null초기값은 사용불가


        }
    }
}
