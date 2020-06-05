using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoOnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesOrNo, user_selection;

            Introduction();
            do
            {
                Console.Write("\tWhat number will you choose '1' or '2'?");
                user_selection = Console.ReadLine();
                if (user_selection == "1") { TshirtCreationAndPayment(); }
                else { MangoDatabase(); }

                Console.Write("\tDo you want to continue? If so, press any button," +
                    " otherwise press 'N' to stop ");
                yesOrNo = Console.ReadLine();

            } while (yesOrNo != "N");
            Console.WriteLine("\t Have a nice day!");
        }

        static void MangoDatabase()
        {
            var mangodata = new MangoDatabase();

            Menu.SortChoice(mangodata.TShirts);
        }

        static void TshirtCreationAndPayment()
        {
            TShirt shirt = new TShirt(
                Menu.ColorChoice(),
                Menu.SizeChoice(),
                Menu.FabricChoice()
                );

            var order = new Order();
            order.BuyTShirt(shirt);

        }

        static void Introduction()
        {
            string user_input;

            Console.WriteLine();
            Console.WriteLine("\tWelcome user to the Mango Online Shop!!");
            Console.WriteLine();
            Console.Write("\tTell me your name: ");
            user_input = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"\t{user_input}, you have two choices!");
            Console.WriteLine("\t1.Press '1' to create your own t-shirt and choose the payment method!");
            Console.WriteLine("\t2.Press '2' to sort t-shirts among three kinds of sorting.");
            Console.WriteLine();
        }
    }   
}
