using System;

namespace MangoOnlineShop
{
    class Basket
    {
        private PaymentMethod _paymentMethod;
        private decimal _dueAmount;

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void SetDueAmount(decimal amount)
        {
            _dueAmount = amount;
            Console.WriteLine("\tThe price of this product is: {0} euros", amount);
        }

        public bool Pay()
        {
            return _paymentMethod.Pay(_dueAmount);
        }
    }

    class Order
    {
        public void BuyTShirt(TShirt shirt)
        {
            var amount = Convert.ToDecimal(new ColorVariation().AddCost(shirt));
            amount += Convert.ToDecimal(new SizeVariation().AddCost(shirt));
            amount += Convert.ToDecimal(new FabricVariation().AddCost(shirt));

            var basket = new Basket();
            basket.SetDueAmount(amount);

            var pay = new PaymentChoice();
            pay.PayBasket(basket);


            if (basket.Pay())
            {
                Console.WriteLine("\tPurchase completed!");
            }
            else
            {
                Console.WriteLine("\tPurchase cancelled!");
                Console.WriteLine("\tPlease try again.");
            }
        }
    }
}
