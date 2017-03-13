using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Array_symetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            bool isEquals = true;
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i]!=input[input.Length-i-1])
                {
                    isEquals = false;
                    break;
                }
            }
            Console.WriteLine(isEquals);
            //Second way
            var reverse = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reverse[i] = input[input.Length - i - 1];
            }
            bool isEqual = input.SequenceEqual(reverse);
            if (isEqual)
            {
                Console.WriteLine("Yes");
            }else
            {
                Console.WriteLine("No");
            }
        }
    }
}
