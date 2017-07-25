using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_countries_and_cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, Dictionary<string, HashSet<string>>>();
            while (input!=0)
            {
                var inputStr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var continent = inputStr[0];
                var country = inputStr[1];
                var city = inputStr[2];
                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, HashSet<string>>(); 
                }
                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new HashSet<string>();
                }
                dict[continent][country].Add(city);
                input--;
            }
            foreach (var item in dict)
            {
                var continents = item.Key;
                var country = item.Value;
                foreach (var items in country)
                {
                    Console.WriteLine($"{continents}:");
                    Console.WriteLine("{0} -> {1}", items.Key, string.Join(", ", items.Value));
                }
            }
        }
    }
}
