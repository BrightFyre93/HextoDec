using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HextoDecConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Hexadecimal Number");
            int output_dec = 0;
            string input_hexa = Console.ReadLine();
            char[] char_hexa = input_hexa.ToCharArray();
            int length_char_hexa = char_hexa.Length;
            for (int i = 0; i < length_char_hexa; i++)
            {
                if (char_hexa[i].Equals('F'))
                {
                    output_dec += 15 * Convert.ToInt32(Math.Pow(16, (length_char_hexa - i - 1)));
                }
                else if (char_hexa[i].Equals('E'))
                {
                    output_dec += 14* Convert.ToInt32(Math.Pow(16, (length_char_hexa - i - 1)));
                }
                else if (char_hexa[i].Equals('D'))
                {
                    output_dec += 13 * Convert.ToInt32(Math.Pow(16, (length_char_hexa - i - 1)));
                }
                else if (char_hexa[i].Equals('C'))
                {
                    output_dec += 12 * Convert.ToInt32(Math.Pow(16, (length_char_hexa - i - 1)));
                }
                else if (char_hexa[i].Equals('B'))
                {
                    output_dec += 11*Convert.ToInt32(Math.Pow(16, (length_char_hexa - i - 1)));
                }
                else if (char_hexa[i].Equals('A'))
                {
                    output_dec += 10 * Convert.ToInt32(Math.Pow(16, (length_char_hexa - i- 1)));
                }
                else
                {
                    output_dec += Convert.ToInt32(Char.GetNumericValue(char_hexa[i])*Math.Pow(16, (length_char_hexa - i - 1)));
                }
            }
            Console.WriteLine($"Converted Decimal Number is {output_dec}");
            Console.ReadKey();
        }
    }
}
