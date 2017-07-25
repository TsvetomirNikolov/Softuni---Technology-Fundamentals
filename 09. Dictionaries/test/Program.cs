using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();
            dict["stock"] = 25.3456;
            dict["stock"] = stock(23);
            foreach(var item in dict){
                Console.WriteLine(" 324234 {0:f2}",item.Value);
            }
        }
        public static int stock(int value)
        {
            int next = 45;
            next += value;
            return next;
        }
    }
}
