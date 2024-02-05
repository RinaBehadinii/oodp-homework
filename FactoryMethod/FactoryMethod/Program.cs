using FactoryMethod;
using FactoryMethod.Factories;
using FactoryMethod.PaymentMethods;

PaymentMethodFactory visaFactory = new VisaFactory();
Visa visaPaymet = new Visa();
visaPaymet.Pay();

PaymentMethodFactory payPalFactory = new PayPalFactory();
PayPal payPalPaymet = new PayPal();
payPalPaymet.Pay();

PaymentMethodFactory cashOnDeliveryFactory = new CashOnDeliveryFactory();
CashOnDelivery cashOnDeliveryPaymet = new CashOnDelivery();
cashOnDeliveryPaymet.Pay();