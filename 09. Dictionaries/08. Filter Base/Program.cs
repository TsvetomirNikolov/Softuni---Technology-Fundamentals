using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<string, Dictionary<string, string>>();
            var inputLine = Console.ReadLine();
            while (inputLine != "filter base")
            {
                var inputParams = inputLine
                    .Split(new[] { ' ', '-', '>' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var nameEmployee = inputParams[0];
                var paramEmployee = inputParams[1];

                if (!employees.ContainsKey(nameEmployee))
                {
                    employees[nameEmployee] = new Dictionary<string, string>();
                }

                var age = 0;
                var salary = 0.0;
                if (int.TryParse(paramEmployee, out age))
                {
                    employees[nameEmployee]["Age"] = paramEmployee;
                }
                else if (double.TryParse(paramEmployee, out salary))
                {
                    employees[nameEmployee]["Salary"] = paramEmployee;
                }
                else
                {
                    employees[nameEmployee]["Position"] = paramEmployee;
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            foreach (var item in employees)
            {
                if (employees[item.Key].ContainsKey(inputLine))
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"{inputLine}: {employees[item.Key][inputLine]}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}