using System;
using System.Collections.Generic;


namespace MangoOnlineShop
{
    abstract class Variation
    {
        public abstract decimal Cost(TShirt shirt);
    }

    class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _colorCost;

        static ColorVariation()
        {
            _colorCost = new Dictionary<Color, decimal>()
            {
                {Color.RED, 1.9m },
                {Color.ORANGE,1.44m },
                {Color.YELLOW, 1.66m },
                {Color.GREEN, 2m},
                {Color.BLUE, 0m },
                {Color.INDIGO, 3m },
                {Color.VIOLET,4.1m }
            };
        }

        public override decimal Cost(TShirt shirt)
        {
            shirt.Price += _colorCost[shirt.Color];
            return shirt.Price;
        }

    }

    class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _sizeCost;

        static SizeVariation()
        {
            _sizeCost = new Dictionary<Size, decimal>()
            {
                {Size.XS, 0m },
                {Size.S, 0.55m },
                {Size.M, 1.23m },
                {Size.L, 1.83m },
                {Size.XL, 2.79m },
                {Size.XXL, 3.88m },
                {Size.XXXL, 5.25m }
            };
        }

        public override decimal Cost(TShirt shirt)
        {
            shirt.Price += _sizeCost[shirt.Size];
            return shirt.Price;
        }
    }
    class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _fabricCost;

        static FabricVariation()
        {
            _fabricCost = new Dictionary<Fabric, decimal>()
            {
                {Fabric.WOOL, 2.49m },
                {Fabric.COTTON, 0m },
                {Fabric.POLYESTER, 1.55m },
                {Fabric.RAYON, 2.78m },
                {Fabric.LINEN, 3.81m},
                {Fabric.CASHMERE, 6.27m },
                {Fabric.SILK, 9.34m }
            };
        }
        public override decimal Cost(TShirt shirt)
        {
            shirt.Price += _fabricCost[shirt.Fabric];
            return shirt.Price;
        }

    }
}
