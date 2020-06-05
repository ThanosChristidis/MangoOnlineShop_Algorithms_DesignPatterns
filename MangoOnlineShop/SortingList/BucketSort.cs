using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoOnlineShop
{
    static class BucketSort
    {
        public static List<TShirt> SizeColorFabricAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;

            List<TShirt>[] ColorBuckets = new List<TShirt>[numOfColors];

            for (int i = 0; i < numOfColors; i++)
            {
                ColorBuckets[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                ColorBuckets[bucket].Add(shirts[i]);

            }

            for (int i = 0; i < numOfColors; i++)
            {
                ColorBuckets[i] = SizeAsc(ColorBuckets[i]);
            }

            //Add shorted items in Array
            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(ColorBuckets[i]);
            }
            return sortedArray;

        }

        public static List<TShirt> SizeColorFabricDesc(List<TShirt> shirts)
        {
            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;


            List<TShirt>[] ColorBuckets = new List<TShirt>[numOfColors];


            for (int i = 0; i < numOfColors; i++)
            {
                ColorBuckets[i] = new List<TShirt>();
            }



            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                ColorBuckets[bucket].Add(shirts[i]);

            }

            for (int i = 0; i < numOfColors; i++)
            {
                ColorBuckets[i] = SizeDesc(ColorBuckets[i]);
            }


            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(ColorBuckets[(numOfColors - 1) - i]);
            }
            return sortedArray;

        }

        public static List<TShirt> FabricAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfFabrics = Enum.GetValues(typeof(Fabric)).Length;


            List<TShirt>[] buckets = new List<TShirt>[numOfFabrics];
            for (int i = 0; i < numOfFabrics; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Fabric;
                buckets[bucket].Add(shirts[i]);

            }


            for (int i = 0; i < numOfFabrics; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;


        }

        public static List<TShirt> FabricDesc(List<TShirt> shirts)
        {
            List<TShirt> sortedArray = new List<TShirt>();
            int numOfFabrics = Enum.GetValues(typeof(Fabric)).Length;

            List<TShirt>[] buckets = new List<TShirt>[numOfFabrics];
            for (int i = 0; i < numOfFabrics; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Fabric;
                buckets[bucket].Add(shirts[i]);
            }


            for (int i = 0; i < numOfFabrics; i++)
            {

                sortedArray.AddRange(buckets[(numOfFabrics - 1) - i]);
            }
            return sortedArray;

        }

        public static List<TShirt> ColorAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;


            List<TShirt>[] buckets = new List<TShirt>[numOfColors];
            for (int i = 0; i < numOfColors; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                buckets[bucket].Add(shirts[i]);

            }


            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;
        }

        public static List<TShirt> ColorDesc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();

            int numOfColors = Enum.GetValues(typeof(Color)).Length;


            List<TShirt>[] buckets = new List<TShirt>[numOfColors];
            for (int i = 0; i < numOfColors; i++)
            {
                buckets[i] = new List<TShirt>();
            }


            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Color;
                buckets[bucket].Add(shirts[i]);
            }


            for (int i = 0; i < numOfColors; i++)
            {

                sortedArray.AddRange(buckets[(numOfColors - 1) - i]);
            }
            return sortedArray;


        }

        public static List<TShirt> SizeAsc(List<TShirt> shirts)
        {

            List<TShirt> sortedArray = new List<TShirt>();
            int numOfSizes = Enum.GetValues(typeof(Size)).Length;

            List<TShirt>[] buckets = new List<TShirt>[numOfSizes];
            for (int i = 0; i < numOfSizes; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Size;
                buckets[bucket].Add(shirts[i]);
            }

            for (int i = 0; i < numOfSizes; i++)
            {
                buckets[i] = FabricAsc(buckets[i]);
            }

            for (int i = 0; i < numOfSizes; i++)
            {

                sortedArray.AddRange(buckets[i]);
            }
            return sortedArray;

        }

        public static List<TShirt> SizeDesc(List<TShirt> shirts)
        {
            List<TShirt> sortedArray = new List<TShirt>();
            int numOfSizes = Enum.GetValues(typeof(Size)).Length;

            List<TShirt>[] buckets = new List<TShirt>[numOfSizes];
            for (int i = 0; i < numOfSizes; i++)
            {
                buckets[i] = new List<TShirt>();
            }

            for (int i = 0; i < shirts.Count() - 1; i++)
            {
                int bucket = (int)shirts[i].Size;
                buckets[bucket].Add(shirts[i]);
            }

            for (int i = 0; i < numOfSizes; i++)
            {
                buckets[i] = FabricDesc(buckets[i]);
            }

            for (int i = 0; i < numOfSizes; i++)
            {

                sortedArray.AddRange(buckets[(numOfSizes - 1) - i]);
            }
            return sortedArray;

        }


    }
}
