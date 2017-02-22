using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public sealed class NotificationService
    {
        private static readonly NotificationService instance = new NotificationService();
        private NotificationService() { }
        public static NotificationService Instance
        {
            get
            {
                return instance;
            }
        }

        public bool NotifyShippingInstruction()
        {
            return true;
        }
    }
}
