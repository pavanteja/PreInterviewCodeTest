using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public sealed class PaymentService
    {
        private readonly NotificationService notificationService;
        private static readonly PaymentService instance = new PaymentService();
        private PaymentService() {
            notificationService = NotificationService.Instance;
        }
        public static PaymentService Instance
        {
            get
            {
                return instance;
            }
        }

        public bool ChargePayment(string creditCardNumber, decimal amount)
        {
            return notificationService.NotifyShippingInstruction();
        }
    }
}
