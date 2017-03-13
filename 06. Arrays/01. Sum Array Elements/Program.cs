using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = int.Parse(Console.ReadLine());
            int[] array = new int[digit];
            var endResult = 0;
            for (int i = 0; i < digit; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                endResult += array[i];
            }
            Console.WriteLine(endResult);
        }
    }
}
