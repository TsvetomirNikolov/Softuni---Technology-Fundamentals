using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var reverse = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reverse[i] = input[input.Length - i - 1];
            }
            for (int i = input.Length-1; i > -1; i--)
            {
                Console.Write(input[i] + " ");
            }
           // Console.WriteLine(string.Join(" ",reverse));
        }
    }
}
