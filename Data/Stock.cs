using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBroker.Data
{
    public class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Change { get; set; }
        public string Currency { get; set; }
        public string LastTradeDate { get; set; }
        public string LastTradePriceOnly { get; set; }
        public string ChangeinPercent { get; set; }
        public string LastTradeTime { get; set; }
    }
}
