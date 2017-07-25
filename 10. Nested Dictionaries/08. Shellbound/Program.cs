using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<long>>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0].Equals("Aggregate"))
                {
                    break;
                }
                var name = input[0];
                var digits = long.Parse(input[1]);
                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<long>();
                }
                dict[name].Add(digits);
            }
            foreach (var item in dict)
            {
                var list = item.Value;
                var sum = item.Value.Sum() - (item.Value.Sum() / item.Value.Count());
                Console.WriteLine("{0} -> {1} ({2})", item.Key, string.Join(", ",list), sum);
            }
        }
    }
}
