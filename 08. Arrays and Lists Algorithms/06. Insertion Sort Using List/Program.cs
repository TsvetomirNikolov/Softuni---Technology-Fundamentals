using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Insertion_Sort_Using_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var resultList = new List<int>();
            for (int arrIndex = 0; arrIndex < arr.Length; arrIndex++)
            {
                var inserted = false;
                var currentElement = arr[arrIndex];
                for (int listIndex = 0; listIndex < resultList.Count; listIndex++)
                {
                    var currentListElement = resultList[listIndex];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        resultList.Insert(Math.Max(0, listIndex), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
