using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            while (input!=0)
            {
                var inputString = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var continent = inputString[0];
                var country = inputString[1];
                var city = inputString[2];
                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }
                if (!dict[continent].ContainsKey(country)) {
                    dict[continent][country] = new List<string>();
                }
                dict[continent][country].Add(city);
                input--;
            }
            foreach (var item in dict)
            {
                var continentName = item.Key;
                var secondDict = item.Value;
                Console.WriteLine($"{continentName}:");
                foreach (var items in secondDict)
                {
                    var countryName = items.Key;
                    var towns = items.Value;
                    Console.WriteLine("{0} -> {1}",countryName,string.Join(", ",towns));
                }
            }
        }
    }
}
