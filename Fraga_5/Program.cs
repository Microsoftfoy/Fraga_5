﻿using System;
namespace Fraga_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);                   
                }
            }
            Console.ReadKey();
        }
    }
}