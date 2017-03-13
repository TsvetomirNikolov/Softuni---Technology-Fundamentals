using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            char[] s = new char[100];
            int counter = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i].Any(char.IsUpper))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
