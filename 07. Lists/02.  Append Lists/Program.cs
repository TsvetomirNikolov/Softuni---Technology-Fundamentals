using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input.Reverse();
            var list = new List<int>();
            foreach (var lisst in input)
            {
                var secondList = lisst.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in secondList)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        list.Add(int.Parse(item));
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
