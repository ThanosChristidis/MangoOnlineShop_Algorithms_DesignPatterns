using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoOnlineShop
{
    class MangoDatabase
    {
        public List<TShirt> TShirts { get; set; }

        public MangoDatabase()
        {
            TShirt ts1 = new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            TShirt ts2 = new  TShirt(Color.BLUE, Size.M, Fabric.COTTON);
            TShirt ts3 = new  TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt ts4 = new  TShirt(Color.BLUE, Size.M, Fabric.POLYESTER);
            TShirt ts5 = new  TShirt(Color.GREEN, Size.XS, Fabric.COTTON);
            TShirt ts6 = new  TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts7 = new  TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt ts8 = new  TShirt(Color.BLUE, Size.S, Fabric.LINEN);
            TShirt ts9 = new  TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts10 = new TShirt(Color.RED, Size.L, Fabric.COTTON);
            TShirt ts11 = new TShirt(Color.RED, Size.M, Fabric.CASHMERE);
            TShirt ts12 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirt ts13 = new TShirt(Color.INDIGO, Size.L, Fabric.COTTON);
            TShirt ts14 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt ts15 = new TShirt(Color.BLUE, Size.S, Fabric.COTTON);
            TShirt ts16 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts17 = new TShirt(Color.RED, Size.XS, Fabric.LINEN);
            TShirt ts18 = new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            TShirt ts19 = new TShirt(Color.RED, Size.L, Fabric.POLYESTER);
            TShirt ts20 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirt ts21 = new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            TShirt ts22 = new TShirt(Color.BLUE, Size.M, Fabric.COTTON);
            TShirt ts23 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt ts24 = new TShirt(Color.BLUE, Size.M, Fabric.POLYESTER);
            TShirt ts25 = new TShirt(Color.GREEN, Size.XS, Fabric.COTTON);
            TShirt ts26 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts27 = new TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt ts28 = new TShirt(Color.BLUE, Size.S, Fabric.LINEN);
            TShirt ts29 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts30 = new TShirt(Color.RED, Size.L, Fabric.COTTON);
            TShirt ts31 = new TShirt(Color.GREEN, Size.M, Fabric.CASHMERE);
            TShirt ts32 = new TShirt(Color.VIOLET, Size.L, Fabric.CASHMERE);
            TShirt ts33 = new TShirt(Color.INDIGO, Size.L, Fabric.COTTON);
            TShirt ts34 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt ts35 = new TShirt(Color.BLUE, Size.S, Fabric.COTTON);
            TShirt ts36 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt ts37 = new TShirt(Color.RED, Size.XS, Fabric.LINEN);
            TShirt ts38 = new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            TShirt ts39 = new TShirt(Color.RED, Size.L, Fabric.POLYESTER);
            TShirt ts40 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);

            TShirts = new List<TShirt>() { ts1, ts2, ts3, ts4, ts5, ts6, ts7, ts8, ts9, ts10, ts11, ts12, ts13, ts14, ts15, ts16, ts17, ts18, ts19, ts20, ts21, ts22, ts23, ts24, ts25, ts26, ts27, ts28, ts29, ts30, ts31, ts32, ts33, ts34, ts35, ts36, ts37, ts38, ts39, ts40 };

        }
        
    }
}
