using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var dict = new SortedDictionary<double, int>();
            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }else
                {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item} -> {dict[item]}");
            }
        }
    }
}
