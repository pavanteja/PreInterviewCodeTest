using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class OrderService
    {
        private readonly InventoryService inventoryService;
        private readonly PaymentService paymentService;
        public OrderService()
        {
            inventoryService = InventoryService.Instance;
            paymentService = PaymentService.Instance;
        }
        public string ProcessOrder(string productId, int quantity,string cardNumber)
        {
            if (!inventoryService.CheckProductInInventory(productId))
            {
                return string.Format("Product With Id {0} Not Availlable!!", productId);
            }

            if (!inventoryService.CheckInventory(productId, quantity))
            {
                return string.Format("Required Quantity of {0} For Product With Id {1} Not Availlable!!", quantity, productId);
            }

            if(paymentService.ChargePayment(cardNumber, inventoryService.GetProductPrice(productId)))
            {
                inventoryService.RemoveFromInventory(productId, quantity);
                return "Order Placed Successfully!!";
            }
            else
            {
                return "Something Went Worng!! Try Again.";
            }
           
        }
    }
}
