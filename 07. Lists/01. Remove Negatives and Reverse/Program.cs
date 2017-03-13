using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            foreach (var item in num)
            {
                if (item > 0)
                {
                    numbers.Add(item);
                }

            }
            foreach (var item in num)
            {
                if (item < 0)
                {
                    numbers.Remove(item);
                }
            }
            numbers.Reverse();

            if (numbers.Any())
            {
                Console.Write(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}

