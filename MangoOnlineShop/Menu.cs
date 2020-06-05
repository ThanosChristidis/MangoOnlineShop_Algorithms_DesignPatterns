using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoOnlineShop
{
    static class Menu
    {
        public static Color ColorChoice()
        {
            int input;

            do
            {
                Console.WriteLine("Enter the number for the preferrable color: ");
                Console.WriteLine("1: VIOLET");
                Console.WriteLine("2: RED");
                Console.WriteLine("3: ORANGE");
                Console.WriteLine("4: INDIGO");
                Console.WriteLine("5: BLUE");
                Console.WriteLine("6: YELLOW");
                Console.WriteLine("7: GREEN");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 7);

            switch (input)
            {
                case 1:
                    return Color.VIOLET;
                case 2:
                    return Color.RED;
                case 3:
                    return Color.ORANGE;
                case 4:
                    return Color.INDIGO;
                case 5:
                    return Color.BLUE;
                case 6:
                    return Color.YELLOW;
                case 7:
                    return Color.GREEN;
                default:
                    return Color.YELLOW;
            }
        }

        public static Size SizeChoice()
        {
            int input;

            do
            {
                Console.WriteLine("Enter the number for the preferrable size: ");
                Console.WriteLine("1: XS");
                Console.WriteLine("2: S");
                Console.WriteLine("3: M");
                Console.WriteLine("4: L");
                Console.WriteLine("5: XL");
                Console.WriteLine("6: XXL");
                Console.WriteLine("7: XXXL");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 7);

            switch (input)
            {
                case 1:
                    return Size.XS;
                case 2:
                    return Size.S;
                case 3:
                    return Size.M;
                case 4:
                    return Size.L;
                case 5:
                    return Size.XL;
                case 6:
                    return Size.XXL;
                case 7:
                    return Size.XXXL;
                default:
                    return Size.L;

            }

        }

        public static Fabric FabricChoice()
        {
            int input;

            do
            {
                Console.WriteLine("Enter the related number for the preffered material: ");
                Console.WriteLine("1: WOOL");
                Console.WriteLine("2: SILK");
                Console.WriteLine("3: POLYESTER");
                Console.WriteLine("4: CASHMERE");
                Console.WriteLine("5: LINEN");
                Console.WriteLine("6: RAYON");
                Console.WriteLine("7: COTTON");

                input = Convert.ToInt32(Console.ReadLine());


            } while (input < 1 || input > 7);

            switch (input)
            {
                case 1:
                    return Fabric.WOOL;
                case 2:
                    return Fabric.SILK;
                case 3:
                    return Fabric.POLYESTER;
                case 4:
                    return Fabric.CASHMERE;
                case 5:
                    return Fabric.LINEN;
                case 6:
                    return Fabric.RAYON;
                case 7:
                    return Fabric.COTTON;
                default:
                    return Fabric.WOOL;
            }
        }

        public static int PaymentMethod()
        {
            int input;

            do
            {
                Console.WriteLine("How do you want to pay? ");
                Console.WriteLine("1: Credit Card");
                Console.WriteLine("2: Bank Transfer");
                Console.WriteLine("3: Cash");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 3);

            return input;

        }

        public static void SortChoice(List<TShirt> shirts)
        {
            int input;

            do
            {
                Console.WriteLine("Which type of sorting do you want to use?");
                Console.WriteLine("1: Bubble Sort");
                Console.WriteLine("2: Quick Sort");
                Console.WriteLine("3: Bucket Sort");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 3);

            switch (input)
            {
                case 1:
                    BubbleSortChoice(shirts);
                    break;
                case 2:
                    QuickSortChoice(shirts.ToArray());
                    break;
                case 3:
                    BucketSortChoice(shirts);
                    break;

            }

        }

        public static void BubbleSortChoice(List<TShirt> shirts)
        {

            int input;

            do
            {
                Console.WriteLine("Enter the number for the prefferable sorting: ");
                Console.WriteLine("1. Size in ascending");
                Console.WriteLine("2. Size in descending");
                Console.WriteLine("3. Color in ascending");
                Console.WriteLine("4. Color in descending");
                Console.WriteLine("5. Fabric in ascending");
                Console.WriteLine("6. Fabric in descending");
                Console.WriteLine("7. Size and Color and Fabric in ascending");
                Console.WriteLine("8. Size and Color and Fabric in descending");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 8);

            switch (input)
            {
                case 1:
                    BubbleSort.SizeAsc(shirts);
                    break;

                case 2:
                    BubbleSort.SizeDesc(shirts);
                    break;

                case 3:
                    BubbleSort.ColorAsc(shirts);
                    break;

                case 4:
                    BubbleSort.ColorDesc(shirts);
                    break;

                case 5:
                    BubbleSort.FabricAsc(shirts);
                    break;

                case 6:
                    BubbleSort.FabricDesc(shirts);
                    break;

                case 7:
                    BubbleSort.SizeColorFabricAsc(shirts);
                    break;

                case 8:
                    BubbleSort.SizeColorFabricDesc(shirts);
                    break;

                default:
                    break;
            }

            foreach (var item in shirts)
            {
                item.Print();
            }

        }


        public static void QuickSortChoice(TShirt[] shirts)
        {
            int input;

            do
            {
                Console.WriteLine("Enter the related number for the preffered shorting: ");
                Console.WriteLine("1. Size in ascending");
                Console.WriteLine("2. Size in descending");
                Console.WriteLine("3. Color in ascending");
                Console.WriteLine("4. Color in descending");
                Console.WriteLine("5. Fabric in ascending");
                Console.WriteLine("6. Fabric in descending");
                Console.WriteLine("7. Size and Color and Fabric in ascending");
                Console.WriteLine("8. Size and Color and Fabric in descending");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 8);

            switch (input)
            {
                case 1:
                    QuickSort.FabricAsc(shirts);
                    break;

                case 2:
                    QuickSort.SizeDesc(shirts);
                    break;

                case 3:
                    QuickSort.ColorAsc(shirts);
                    break;

                case 4:
                    QuickSort.ColorDesc(shirts);
                    break;

                case 5:
                    QuickSort.FabricAsc(shirts);
                    break;

                case 6:
                    QuickSort.FabricDesc(shirts);
                    break;

                case 7:
                    QuickSort.SizeColorFabricAsc(shirts);
                    break;

                case 8:
                    QuickSort.SizeColorFabricDesc(shirts);
                    break;

                default:
                    break;
            }

            foreach (var item in shirts)
            {
                item.Print();
            }

        }

        public static void BucketSortChoice(List<TShirt> shirts)
        {
            int input;

            do
            {
                Console.WriteLine("Enter the related number for the preffered shorting: ");
                Console.WriteLine("1. Size in ascending");
                Console.WriteLine("2. Size in descending");
                Console.WriteLine("3. Color in ascending");
                Console.WriteLine("4. Color in descending");
                Console.WriteLine("5. Fabric in ascending");
                Console.WriteLine("6. Fabric in descending");
                Console.WriteLine("7. Size and Color and Fabric in ascending");
                Console.WriteLine("8. Size and Color and Fabric in descending");

                input = Convert.ToInt32(Console.ReadLine());

            } while (input < 1 || input > 8);

            switch (input)
            {
                case 1:
                    shirts = BucketSort.SizeAsc(shirts);
                    break;

                case 2:
                    shirts = BucketSort.SizeDesc(shirts);
                    break;

                case 3:
                    shirts = BucketSort.ColorAsc(shirts);
                    break;

                case 4:
                    shirts = BucketSort.ColorDesc(shirts);
                    break;

                case 5:
                    shirts = BucketSort.FabricAsc(shirts);
                    break;

                case 6:
                    shirts = BucketSort.FabricDesc(shirts);
                    break;

                case 7:
                    shirts = BucketSort.SizeColorFabricAsc(shirts);
                    break;

                case 8:
                    shirts = BucketSort.SizeColorFabricDesc(shirts);
                    break;

                default:
                    break;
            }
            foreach (var item in shirts)
            {
                item.Print();
            }

        }

    }
}
