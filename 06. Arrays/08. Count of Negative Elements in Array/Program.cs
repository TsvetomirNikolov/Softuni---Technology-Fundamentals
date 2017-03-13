using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var digit = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==digit)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
