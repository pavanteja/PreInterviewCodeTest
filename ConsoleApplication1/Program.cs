using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Product Id :");
                var productId = Console.ReadLine();
                Console.Write("Enter Product Quantity :");
                var productQuantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Card Number :");
                var cardNumber = Console.ReadLine();
                var orderService = new OrderService();
                var responseCode = orderService.ProcessOrder(productId, productQuantity, cardNumber);
                Console.WriteLine(responseCode);
                Console.WriteLine("Continue Shopping?(y/n)");
                var key = Console.ReadLine();
                if (key.ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
