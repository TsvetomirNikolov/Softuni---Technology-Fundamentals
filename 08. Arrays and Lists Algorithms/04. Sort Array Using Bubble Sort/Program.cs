using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var isSort = false;
            do
            {
                isSort = false;
                for (int i = 0; i < input.Length-1; i++)
                {
                    var first = input[i];
                    var next = input[i + 1];
                    if (first > next)
                    {
                        input[i + 1] = first;
                        input[i] = next;
                        isSort = true; 
                    }
                }

            } while (isSort);
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
