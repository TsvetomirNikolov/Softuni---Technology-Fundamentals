using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            while (input!=0)
            {
                var secInput = Console.ReadLine();
                set.Add(secInput);
                input--;
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
