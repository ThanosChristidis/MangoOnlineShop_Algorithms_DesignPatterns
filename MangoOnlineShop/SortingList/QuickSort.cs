using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoOnlineShop
{
    static class QuickSort
    {
        public static int ColorAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                
                if (arr[j].Color < pivot.Color) 
                {
                    i++;
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }

            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;

        }

        public static int SizeAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                  
                if (arr[j].Size < pivot.Size)  
                {
                    i++;

                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }

            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static int FabricAscPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                 
                if (arr[j].Fabric < pivot.Fabric) 
                {
                    i++;

                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }

            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static int ColorDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
               
                if (arr[j].Color > pivot.Color)  
                {
                    i++;
  
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }

            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static int SizeDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                
                if (arr[j].Size > pivot.Size) 
                {
                    i++;

                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
 
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static int FabricDescPartition(TShirt[] arr, int low, int high)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                
                if (arr[j].Fabric > pivot.Fabric)  
                {
                    i++;
  
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

            }

            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void ColorAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = ColorAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorAscRecursive(arr, low, pi - 1);
                ColorAscRecursive(arr, pi + 1, high);
            }
        }

        public static void SizeAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = SizeAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeAscRecursive(arr, low, pi - 1);
                SizeAscRecursive(arr, pi + 1, high);
            }
        }

        public static void ColorDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = ColorDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorDescRecursive(arr, low, pi - 1);
                ColorDescRecursive(arr, pi + 1, high);
            }
        }

        public static void SizeDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = SizeDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeDescRecursive(arr, low, pi - 1);
                SizeDescRecursive(arr, pi + 1, high);
            }
        }

        public static void FabricAscRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = FabricAscPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricAscRecursive(arr, low, pi - 1);
                FabricAscRecursive(arr, pi + 1, high);
            }
        }

        public static void FabricDescRecursive(TShirt[] arr, int low, int high)
        {

            if (low < high)
            {


                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = FabricDescPartition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricDescRecursive(arr, low, pi - 1);
                FabricDescRecursive(arr, pi + 1, high);
            }
        }

        public static void FabricAsc(TShirt[] shirts)
        {
            FabricAscRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void FabricDesc(TShirt[] shirts)
        {
            FabricDescRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void ColorAsc(TShirt[] shirts)
        {
            ColorAscRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void ColorDesc(TShirt[] shirts)
        {
            ColorDescRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void SizeAsc(TShirt[] shirts)
        {
            SizeAscRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void SizeDesc(TShirt[] shirts)
        {
            SizeDescRecursive(shirts, 0, shirts.Length - 1);
        }

        public static void SizeColorFabricAsc(TShirt[] shirts)
        {
            ColorAsc(shirts);
            SizeAsc(shirts);
        }

        public static void SizeColorFabricDesc(TShirt[] shirts)
        {
            //Under Construction
            ColorDesc(shirts);
            SizeDesc(shirts);
            FabricDesc(shirts);

            Console.WriteLine("Under Construction...");
        }

    }
}
