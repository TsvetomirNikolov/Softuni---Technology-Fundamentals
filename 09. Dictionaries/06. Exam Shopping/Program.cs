using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Exam_Shopping
{
    class Program
    {
        public static void Main()
        {
            var quantities = new Dictionary<string, long>();
            while (true)
            {
                var inputStock = Console.ReadLine();

                if (inputStock == "shopping time")
                {
                    break;
                }

                var inputStockList = inputStock.Split((new[] { ' ' }), StringSplitOptions.RemoveEmptyEntries).ToList();
                var currProduct = inputStockList[1];
                long currQuantity = 0;
                var parsed = long.TryParse(inputStockList[2], out currQuantity);

                if (inputStockList[0] != "stock" && !parsed)
                {
                    continue;
                }

                AddCurrentInputToQuantities(currProduct, currQuantity, quantities);
            }

            while (true)
            {
                var inputBuy = Console.ReadLine();

                if (inputBuy == "exam time")
                {
                    foreach (var kvp in quantities)
                    {
                        if (kvp.Value > 0)
                        {
                            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                        }
                    }
                    return;
                }

                var inputBuyList = inputBuy.Split((new[] { ' ' }), StringSplitOptions.RemoveEmptyEntries).ToList();
                var productBuy = inputBuyList[1];
                long quantityBuy = 0;
                var parsed = long.TryParse(inputBuyList[2], out quantityBuy);
                if (inputBuyList[0] != "buy" && !parsed)
                {
                    continue;
                }

                RemoveBuysInputFromQuantities(productBuy, quantityBuy, quantities);
            }
        }

        public static void AddCurrentInputToQuantities(string currProduct, long currQuantity, Dictionary<string, long> quantities)
        {
            if (!quantities.ContainsKey(currProduct))
            {
                quantities.Add(currProduct, 0);
            }

            quantities[currProduct] += currQuantity;
        }

        public static void RemoveBuysInputFromQuantities(string productBuy, long quantityBuy, Dictionary<string, long> quantities)
        {
            if (!quantities.ContainsKey(productBuy))
            {
                Console.WriteLine($"{productBuy} doesn't exist");
            }

            else
            {
                if (quantities[productBuy] <= 0)
                {

                    Console.WriteLine($"{productBuy} out of stock");
                }

                else
                {
                    quantities[productBuy] -= quantityBuy;
                }
            }
        }
    }
}