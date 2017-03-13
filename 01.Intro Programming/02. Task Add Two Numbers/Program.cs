using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Task_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit1 = int.Parse(Console.ReadLine());
            var digit2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{digit1} + {digit2} = {digit1+digit2}");
        }
    }
}
