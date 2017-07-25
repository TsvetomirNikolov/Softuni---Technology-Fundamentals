using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortDict = new SortedDictionary<string, long>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0].Equals("Over"))
                {
                    break;
                }
                var num = 0;
                var name = input[0];
                var phone = input[1];
                if (int.TryParse(name,out num))
                {
                    sortDict[phone] = long.Parse(name);
                }
                else
                {
                        sortDict[name] = long.Parse(phone);
                }
            }
            foreach (var item in sortDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
