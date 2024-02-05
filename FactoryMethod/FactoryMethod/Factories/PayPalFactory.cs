using FactoryMethod.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class PayPalFactory : PaymentMethodFactory
    {
        public override PaymentMethod CreatePaymentMethod()
        {
            return new PayPal();
        }
    }
}
