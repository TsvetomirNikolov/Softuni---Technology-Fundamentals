using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lab_BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume} ml {name}");
            Console.WriteLine($"{(volume/100)*energyContent}, {(volume/100)*sugarContent}");
        }
    }
}
