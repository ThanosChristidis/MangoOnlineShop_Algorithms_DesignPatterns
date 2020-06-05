using System;

namespace MangoOnlineShop
{
    class Basket
    {
        private PaymentMethod _paymentMethod;
        private decimal _amount;

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void SetDueAmount(decimal amount)
        {
            _amount = amount;
            Console.WriteLine("The price of this product is: {0} euros", amount);
        }

        public bool Pay()
        {
            return _paymentMethod.Pay(_amount);
        }
    }

    class Order
    {
        public void BuyTShirt(TShirt shirt)
        {
            var amount = Convert.ToDecimal(new ColorVariation().Cost(shirt));
            amount += Convert.ToDecimal(new SizeVariation().Cost(shirt));
            amount += Convert.ToDecimal(new FabricVariation().Cost(shirt));

            var basket = new Basket();
            basket.SetDueAmount(amount);

            var pay = new PaymentChoice();
            pay.PayBasket(basket);


            if (basket.Pay())
            {
                Console.WriteLine("Purchase completed!");
            }
            else
            {
                Console.WriteLine("Purchase cancelled!");
                Console.WriteLine("Pleaae try again.");
            }
        }
    }
}
