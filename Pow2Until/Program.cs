﻿using System;

namespace Pow2Until
{
    public class Program
    {
        private static void PowersOf2Until5()
        {
            for(int i = 1; i <= (1 <<5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        private static void Main(string[] args)
        {
            PowersOf2Until5();
            PowersOf2Until5();
        }
    }
}
