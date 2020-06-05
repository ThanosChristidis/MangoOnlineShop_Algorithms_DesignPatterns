using System;


namespace MangoOnlineShop
{
    abstract class PaymentMethod
    {
        public abstract bool Pay(decimal amount);
    }

    class CreditAndDebitCard : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount < 0 || amount > 1000)
            {
                Console.WriteLine($"Cannot pay the amount of the {amount} euros using Card!");
                return false;
            }
            else
            {
                Console.WriteLine($"Pay the amount of the {amount} euros using Card!");
                return true;
            } 
        }
    }

    class BankTransfer : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount < 0 || amount > 1000)
            {
                Console.WriteLine($"Cannot pay the amount of the {amount}euros using Bank Tranfer!");
                return false;
            }
            else
            {
                Console.WriteLine($"Pay the amount of the {amount}euros using Bank Transfer!");
                return true;
            }
        }
    }

    class Cash : PaymentMethod
    {
        public override bool Pay(decimal amount)
        {
            if (amount < 0 || amount > 1000)
            {
                Console.WriteLine($"Cannot pay the amount of the {amount}euros using Cash!");
                return false;
            }
            else
            {
                Console.WriteLine($"Pay the amount of the {amount}euros using Cash!");
                return true;
            }
        }
    }

    class PaymentChoice
    {
        public void PayBasket(Basket basket)
        {

            switch (Menu.PaymentMethod())
            {
                    case 1:
                        basket.SelectPaymentMethod(new CreditAndDebitCard());
                        break;

                    case 2:
                        basket.SelectPaymentMethod(new BankTransfer());
                        break;

                    case 3:
                        basket.SelectPaymentMethod(new Cash());
                        break;

            }
            
        }
    }



}
