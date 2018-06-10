using System.Collections.Generic;

namespace MyBroker.Models
{
    public interface IStockDepot
    {
        IList<string> GetUserStocknames();

        void SaveStockname(string stockname);
    }
}