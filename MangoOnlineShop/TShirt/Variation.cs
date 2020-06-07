using System;
using System.Collections.Generic;


namespace MangoOnlineShop
{
    abstract class Variation
    {
        public abstract decimal AddCost(TShirt shirt);
    }

    class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _colorCost;

        static ColorVariation()
        {
            _colorCost = new Dictionary<Color, decimal>()
            {
                {Color.RED, 3.4m },
                {Color.ORANGE, 5.44m },
                {Color.YELLOW, 2.66m },
                {Color.GREEN, 2m},
                {Color.BLUE, 0m },
                {Color.INDIGO, 5m },
                {Color.VIOLET,6.1m }
            };
        }

        public override decimal AddCost(TShirt shirt)
        {
            shirt.Price = _colorCost[shirt.Color];
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
                {Size.S, 1.55m },
                {Size.M, 2.23m },
                {Size.L, 3.83m },
                {Size.XL, 4.79m },
                {Size.XXL, 5.88m },
                {Size.XXXL, 7.25m }
            };
        }

        public override decimal AddCost(TShirt shirt)
        {
            shirt.Price = _sizeCost[shirt.Size];
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
                {Fabric.RAYON, 3.78m },
                {Fabric.LINEN, 5.81m},
                {Fabric.CASHMERE, 6.27m },
                {Fabric.SILK, 9.34m }
            };
        }
        public override decimal AddCost(TShirt shirt)
        {
            shirt.Price = _fabricCost[shirt.Fabric];
            return shirt.Price;
        }

    }
}
