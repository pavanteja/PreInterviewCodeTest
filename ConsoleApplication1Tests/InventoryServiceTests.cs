using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class InventoryServiceTests
    {
        [TestMethod()]
        public void GetProductPrice_GetPrice_Product_Fount_ID_P006()
        {
            var inventoryService = InventoryService.Instance;
            var price = inventoryService.GetProductPrice("P006");
            Assert.AreEqual(price,5);
        }

        [TestMethod()]
        public void GetProductPrice_GetPrice_Product_Not_Fount_ID_P007()
        {
            var inventoryService = InventoryService.Instance;
            var price = inventoryService.GetProductPrice("P007");
            Assert.AreEqual(price, -1);
        }

        [TestMethod()]
        public void CheckProductInInventory_Product_Fount_ID_P006()
        {
            var inventoryService = InventoryService.Instance;
            var found = inventoryService.CheckProductInInventory("P006");
            Assert.IsTrue(found);
        }

        [TestMethod()]
        public void CheckProductInInventory_Product_Not_Fount_ID_P007()
        {
            var inventoryService = InventoryService.Instance;
            var found = inventoryService.CheckProductInInventory("P007");
            Assert.IsFalse(found);
        }

        [TestMethod()]
        public void CheckInventory_Product_Fount_ID_P006_Quantity_Availlable()
        {
            var inventoryService = InventoryService.Instance;
            var found = inventoryService.CheckInventory("P006",10);
            Assert.IsTrue(found);
        }

        [TestMethod()]
        public void CheckInventory_Product_Not_Fount_ID_P006_Quantity_Not_Availlable()
        {
            var inventoryService = InventoryService.Instance;
            var found = inventoryService.CheckInventory("P006",11);
            Assert.IsFalse(found);
        }
    }
}