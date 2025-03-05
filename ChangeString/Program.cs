using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input_string;
            string input_caracter;
            string response_string = "";

            Console.Write("Insere um string: ");
            input_string = Console.ReadLine();
            Console.Write("Insere um caracter: ");
            input_caracter = Console.ReadLine();
            char char_caracter = char.Parse(input_caracter);
            foreach (char letter in input_string)
            {
                if (letter == char_caracter)
                {
                    response_string += "x";
                }
                else
                {
                    response_string += letter;
                }
            }
            Console.WriteLine(response_string);
        }
    }
}
