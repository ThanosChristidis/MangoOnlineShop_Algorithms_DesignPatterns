using System;

namespace MangoOnlineShop
{
        
    class TShirt
    {
         public readonly Color Color;
         public readonly Size Size;
         public readonly Fabric Fabric;

         public decimal Price { get; set; }

         public TShirt(Color color, Size size, Fabric fabric)
         {
                Color = color;
                Size = size;
                Fabric = fabric;
         }

        public void Print()
        {
            Console.WriteLine("{0} TShirt with size {1} and made by {2}", Color, Size, Fabric);
        }
    }


    enum Color { RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET }
    enum Size { XS, S, M, L, XL, XXL, XXXL }
    enum Fabric { WOOL, COTTON, POLYESTER, RAYON, LINEN, CASHMERE, SILK }
    
}
