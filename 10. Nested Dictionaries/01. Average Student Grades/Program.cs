using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var average = 0.0;
            var dict = new Dictionary<string, List<double>>();
            while (input != 0)
            {
                var inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputs[0];
                var grades = double.Parse(inputs[1]);
                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }
                dict[name].Add(grades);
                input--;
            }
            foreach (var dic in dict)
            {
                var name = dic.Key;
                var grades = dic.Value;
                var avergae = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var item in grades)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine("(avg: {0:f2})",avergae);
            }
        }
    }
}
