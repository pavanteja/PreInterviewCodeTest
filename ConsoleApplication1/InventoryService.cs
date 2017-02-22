using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public sealed class InventoryService
    {

        private static readonly InventoryService instance = new InventoryService();
        private InventoryService() {
            BuildInventory();
        }
        public static InventoryService Instance
        {
            get
            {
                return instance;
            }
        }


        Dictionary<string, int> Inventory = new Dictionary<string, int>();
        Dictionary<string, int> ProductPrice = new Dictionary<string, int>();
        public void BuildInventory()
        {
            Inventory.Add("P001", 0);
            Inventory.Add("P002", 2);
            Inventory.Add("P003", 4);
            Inventory.Add("P004", 7);
            Inventory.Add("P005", 9);
            Inventory.Add("P006", 10);

            ProductPrice.Add("P001", 50);
            ProductPrice.Add("P002", 100);
            ProductPrice.Add("P003", 75);
            ProductPrice.Add("P004", 80);
            ProductPrice.Add("P005", 10);
            ProductPrice.Add("P006", 5);
        }

        public int GetProductPrice(string productId)
        {
            return ProductPrice.ContainsKey(productId) ? Inventory[productId] : -1;

        }
        public bool CheckProductInInventory(string productId)
        {
            return Inventory.ContainsKey(productId) ? true : false;
        }

        public bool CheckInventory(string productId, int qty)
        {
            return qty <= Inventory[productId] ? true : false;
        }

        public int RemoveFromInventory(string productId, int qty)
        {
            Inventory[productId] -= qty;
            return Inventory[productId];
        }
    }
}
