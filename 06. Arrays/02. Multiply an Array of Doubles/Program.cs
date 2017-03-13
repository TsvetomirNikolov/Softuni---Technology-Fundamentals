using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var digit = double.Parse(Console.ReadLine());
            var temp = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = digit * arr[i];
                Console.Write($"{temp} ,");
            }
        }
    }
}
