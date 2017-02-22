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
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest_No_Product()
        {
            var order = new OrderService();
            var result=order.ProcessOrder("P00010",1,"2345678");
            Assert.AreEqual(result, "Product With Id P00010 Not Availlable!!");
        }

        [TestMethod()]
        public void OrderServiceTest_Product_P006_Quantity_Not_Availlable()
        {
            var order = new OrderService();
            var result = order.ProcessOrder("P006", 11, "2345678");
            Assert.AreEqual(result, "Required Quantity of 11 For Product With Id P006 Not Availlable!!");
        }

        [TestMethod()]
        public void OrderServiceTest_Product_P006_Order_Placed()
        {
            var order = new OrderService();
            var result = order.ProcessOrder("P006", 6, "2345678");
            Assert.AreEqual(result, "Order Placed Successfully!!");
        }

    }
}