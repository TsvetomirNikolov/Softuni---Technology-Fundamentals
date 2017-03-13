using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var input = double.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (input  <= array[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
