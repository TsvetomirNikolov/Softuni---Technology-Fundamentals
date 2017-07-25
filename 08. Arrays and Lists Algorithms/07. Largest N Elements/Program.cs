using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var digit = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < input.Length-1; i++)
            {
                var g = i + 1;
                while (g > 0 )
                {
                    if (input[g] > input[g-1])
                    {
                        var temp = input[g - 1];
                        input[g - 1] = input[g];
                        input[g] = temp; 
                    }
                    g--;
                }
            }
            list = input.Take(digit).ToList();
            list.ForEach(x => { Console.Write(x + " "); });
        }
    }
}
