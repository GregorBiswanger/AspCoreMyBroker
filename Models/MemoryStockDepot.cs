using System.Collections.Generic;

namespace MyBroker.Models
{
    public class MemoryStockDepot : IStockDepot
    {
        private IList<string> _stocknames = new List<string>();

        public IList<string> GetUserStocknames()
        {
            return _stocknames;
        }

        public void SaveStockname(string stockname)
        {
            _stocknames.Add(stockname);
        }
    }
}
