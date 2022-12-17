﻿using System;

namespace _022_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { 
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"count: {count}");
                count++;
            }
            Random rnd = new Random();

            int randNum = rnd.Next();
            Console.WriteLine($"randNum: {randNum}");

            while (randNum != 9)
            {
                randNum = rnd.Next(0, 10);
                Console.WriteLine($"randNum: {randNum}");
            }
        }
            //중첩
            {
                int count = 0;
                while (++count<10)
                {
                    Console.WriteLine("첫번째 while문 count: " + count);
                    while (++count < 5)
                    {
                        Console.WriteLine("두번째 while문 count: " + count);
                    }
                }
            }

            //do~while
            {
                Console.WriteLine("\n do ~ while");
                
                Random rnd = new Random();
                int randNum = rnd.Next(0, 10);
                int inputNum = 0;
                do
                {
                    Console.WriteLine("\n 0 ~ 9 사이 숫자중 어떤 숫자 일까요: ");
                    inputNum= int.Parse( Console.ReadLine() );

                    if (inputNum > randNum)
                    {
                        Console.WriteLine($"입력값 {inputNum}이 커요");
                    }
                    else if(inputNum < randNum)
                    {
                        Console.WriteLine($"입력값 {inputNum}이 작아요");
                    }
                    else
                    {
                        Console.WriteLine("정답입니다");
                    }
                }while (inputNum!=randNum);
            }

        }
    }
}
