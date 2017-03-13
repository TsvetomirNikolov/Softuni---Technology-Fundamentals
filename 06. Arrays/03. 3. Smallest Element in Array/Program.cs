using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._3.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var min = array.Min();
            var smallest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<smallest)
                {
                    var tmp = smallest;
                    smallest = array[i];
                    array[i] = smallest;
                }
            }
            Console.WriteLine(smallest);
            Console.WriteLine(min);
        }
    }
}
