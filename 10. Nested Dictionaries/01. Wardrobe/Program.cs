using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string,int>>();
            var set = new HashSet<string>();
            while (input!= 0 )
            {
                var inputArr = Console.ReadLine().Split(new string[] { " ", "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var secInputs = inputArr[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var colour = inputArr[0];
                if (!dict.ContainsKey(colour))
                {
                    dict[colour] = new Dictionary<string, int>();
                }
                foreach (var item in secInputs)
                {
                    var clothes = dict[colour];
                    if (!clothes.ContainsKey(item))
                    {
                        clothes.Add(item, 0);
                    }
                    clothes[item]++;
                }
                input--;
            }
            var secInput = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in dict)
            {
                var colors = item.Key;
                var dress = item.Value;
                Console.WriteLine($"{colors} clothes:");
                foreach (var items in dress)
                {
                    var clothe = items.Key;
                    var times = items.Value;
                    Console.WriteLine($"* {clothe} - {times}");
                    if (secInput[0] == clothe && secInput[1]==colors)
                    {
                        Console.WriteLine(" (found!)");
                        Console.WriteLine();
                    }
                }
               
            }
        }
    }
}
