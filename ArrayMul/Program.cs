using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            float result;
            float [][] matrixes = new float [2][];
            matrixes[0] = new float [4] {float.Parse(args[0]), 
            float.Parse(args[1]), float.Parse(args[2]), float.Parse(args[3])};
            matrixes[1] = new float [2] {float.Parse(args[4]), 
            float.Parse(args[5])};

            for(int i = 0 ; i < matrixes[0].Length; i += 2)
            {
                for(int j = 0; j < matrixes[1].Length; j++)
                {
                    result = matrixes[0][i] * matrixes[1][0] + matrixes[0][i+1]*
                    matrixes[1][1];
                    Console.WriteLine($"| {result,7:f2} |");
                    j++;
                }
            }
        }
    }
}
