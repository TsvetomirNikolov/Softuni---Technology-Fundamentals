using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { '=', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0].Equals("end"))
                {
                    break;
                }
                var number = 0;
                var name = input[0];
                var value = input[1];
                if (int.TryParse(value, out number))
                {
                    dict[name] = int.Parse(value);
                }
                else
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[name] = dict[value];
                    }
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{ item } === {dict[item]}");
            }
        }
    }
}
