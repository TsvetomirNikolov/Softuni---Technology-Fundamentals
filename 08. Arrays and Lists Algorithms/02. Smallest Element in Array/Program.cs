using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var digit = int.MaxValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<digit)
                {
                    digit = input[i];
                }
            }
            Console.WriteLine(digit);
        }
    }
}
