using System;

namespace _021_switch
{
    internal class Program
    {
        public enum TEST { A,B,C,D}
        static void Main(string[] args)
        {
            {
                int n = 0;
                switch (n)
                {
                    case (1):
                        Console.WriteLine("이수는 1이다");
                        break;
                    default:
                        Console.WriteLine("이 수는 deafault다");
                        break;
                }
            }
            {
                TEST? test = null;
                //TEST test =TEST.A;
                switch (test)
                {
                    case TEST.A:
                        Console.WriteLine("test: A");
                        break;
                    case TEST.B:
                        break;
                    case TEST.C:
                        break;
                    case TEST.D:
                        break;
                    default:
                        break;
                }
                if(test == TEST.A || test == TEST.B)
                {
                    Console.WriteLine("test: A,B");
                }
            }
        }
    }
}
