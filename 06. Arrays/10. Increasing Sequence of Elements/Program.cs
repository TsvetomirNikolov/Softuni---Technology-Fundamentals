using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isIncrease = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    isIncrease = false;
                    break;
                }
            }
            if (isIncrease)
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
