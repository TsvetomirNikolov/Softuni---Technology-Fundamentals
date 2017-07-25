using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,long>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var countryName = input[0];
                  if (input[0].Equals("ready"))
                {
                    break;
                }
                var secInput = input[1].Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < secInput.Length; i++)
                {
                    var splitt = secInput[i].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var digit = splitt[1];
                    if (!dict.ContainsKey(countryName))
                    {
                        dict.Add(countryName, 0);
                    }
                    dict[countryName] += long.Parse(digit);
                }

            }
            while (true)
            {
                var secondInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (secondInput[0].Equals("travel"))
                {
                    break;
                }
                var currKms = long.Parse(secondInput[1]);
                foreach (var item in dict)
                {
                    var name = item.Key;
                    var digit = item.Value;
                    if (currKms > digit)
                    {
                       Console.WriteLine($"{item.Key} -> all {currKms} accommodated");
                    }else if (currKms < digit)
                    {
                        Console.WriteLine($"{item.Key} -> all except {digit-currKms} accommodated");
                    }
                }
              
            }
            
        }
        public static Dictionary<string,long> splitt(string[] arr, Dictionary<string,long> dict, string name)
        {
            var digit = 0l;
            for (int i = 0; i < arr.Length; i++)
            {
                var parse = long.TryParse(arr[i], out digit);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, 0);
                }
                dict[name] += digit;
            }
            return dict;
        }
    }
}
