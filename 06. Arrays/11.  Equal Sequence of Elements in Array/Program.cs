using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isEqual = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i+1])
                {
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
