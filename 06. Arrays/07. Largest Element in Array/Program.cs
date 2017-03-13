using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var array = new int[input];
            var max = int.MinValue;
            for (int i = 0; i < input; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (max<array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
