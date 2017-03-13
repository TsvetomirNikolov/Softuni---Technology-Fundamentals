using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lab_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var mileToKm = input * 1.60934;
            Console.WriteLine("{0:f2}",mileToKm);
        }
    }
}
