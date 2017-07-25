using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var dict = new Dictionary<char, int>();
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
