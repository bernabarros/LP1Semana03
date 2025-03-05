using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int argsize_num;

            foreach (string argument in args)
            {
                argsize_num = argument.Length;
                if (argsize_num >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    break;
                }
                else if (argsize_num > 3)
                {
                    Console.WriteLine(argument);
                }
            }
        }
    }
}
