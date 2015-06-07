using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OKCoinAPI
{
    public enum MarketType 
    { 
        BTC, 
        LTC 
    }

    public class Market
    {
        public decimal High;
        public decimal Low;
        public decimal Buy;
        public decimal Sell;
        public decimal Last;
        public decimal Volume;
    }

}
