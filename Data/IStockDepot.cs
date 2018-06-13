using System.Collections.Generic;

namespace MyBroker.Data
{
    public interface IStockDepot
    {
        IList<string> GetUserStocknames();

        void SaveStockname(string stockname);
    }
}