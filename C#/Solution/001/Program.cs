using System;
//using MyConsole = System.Console;

namespace _001_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            if(args.Length > 0)
                Console.WriteLine("arg: " + args[0]);
        }
    }
}
