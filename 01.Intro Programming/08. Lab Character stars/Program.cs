using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lab_Character_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealt = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {new string('|',health)}");
            Console.WriteLine($"Energy: {new string('|',energy)}");
        }
    }
}
