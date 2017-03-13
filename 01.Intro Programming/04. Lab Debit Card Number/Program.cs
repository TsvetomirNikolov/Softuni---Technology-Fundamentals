using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Lab_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var input1 = int.Parse(Console.ReadLine());
            var input2 = int.Parse(Console.ReadLine());
            var input3 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}",input,input1,input2,input3);
        }
    }
}
