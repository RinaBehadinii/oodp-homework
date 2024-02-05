using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PaymentMethods
{
    public class PayPal : PaymentMethod
    {
        public override void Pay()
        {
            Console.WriteLine("You are using 'PayPal' as a payment method.");

        }
    }
}
