using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_contains_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var digit = int.Parse(Console.ReadLine());
            var isInArray = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == digit)
                {
                    Console.WriteLine("yes");
                    isInArray = true;
                }
            }
            if (!isInArray)
            {
                Console.WriteLine("no");
            }
        }
    }
}
