using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.User_logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();var counter = 0;
            while (true)
            {
                var inputs = Console.ReadLine().Split(new string[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputs[0].Equals("login"))
                {
                    break;
                }
                var username = inputs[0];
                var password = inputs[1];
                dict[username] = password;
            }
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { "->", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0].Equals("end"))
                {
                    break;
                }
                var username = input[0];
                var passwords = input[1];
                if (!dict.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    counter++;
                }else if(dict.ContainsKey(username))
                {
                    if (passwords == dict[username])
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else {
                        Console.WriteLine($"{username}: login failed");
                        counter++;
                    }
                }
            }
            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
