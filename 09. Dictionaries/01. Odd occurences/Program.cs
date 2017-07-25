using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }else
                {
                    dict[item]= 1;
                }
            }
            var list = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    list.Add(item.Key);
                }

            }
            Console.WriteLine(String.Join(", ",list));
        }
    }
}
