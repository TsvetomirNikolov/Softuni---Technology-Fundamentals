using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var squareNums = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (Math.Sqrt(input[i]) == (int)(Math.Sqrt(input[i])))
                {
                    squareNums.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(" ",squareNums.OrderByDescending(i => i)));
        }
    }
}
