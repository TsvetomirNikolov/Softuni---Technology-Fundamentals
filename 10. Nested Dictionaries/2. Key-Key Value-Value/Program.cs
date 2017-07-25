using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var digitInput = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();
            while (digitInput != 0)
            {
                var input = Console.ReadLine().Split(new string[] { "=>", " "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var secInput = input[1].Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var keys = input[0];
                if (keys.Contains(key))
                {
                    if (!dict.ContainsKey(keys))
                    {
                        dict[keys] = new List<string>();
                    }
                    foreach (var item in secInput)
                    {
                        if (!value.Contains(item))
                        {
                            dict[keys].Add(item);
                        }
                    }
                }
                digitInput--;
            }
            foreach (var item in dict)
            {
                var keys = item.Key;
                var values = item.Value;
                Console.WriteLine($"{keys}:");
                foreach (var items in values)
                {
                    Console.WriteLine($"-{items}");
                }
            }
        }
    }
}
