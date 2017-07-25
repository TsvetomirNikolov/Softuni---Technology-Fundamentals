using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length-1; i++)
            {
                var e = i + 1;
                while (e > 0)
                {
                    if (input[e] < input[e - 1])
                    {
                        var temp = input[e - 1];
                        input[e - 1] = input[e];
                        input[e] = temp;
                    }
                    e--;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
     }
  }

