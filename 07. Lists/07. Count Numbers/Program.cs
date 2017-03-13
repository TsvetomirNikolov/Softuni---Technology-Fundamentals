using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Sort();
            var pos = 0;
            while (pos < input.Count)
            {
                var num = input[pos];
                var count = 1;
                while (pos + count < input.Count &&
                  input[pos + count] == num)
                    count++;
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
