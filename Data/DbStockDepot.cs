using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBroker.Data
{
    public class DbStockDepot : IStockDepot
    {
        private MyStocksDbContext _context;

        public DbStockDepot(MyStocksDbContext context)
        {
            _context = context;
        }

        public IList<string> GetUserStocknames()
        {
            return _context.Stocknames.Select(myStock => myStock.Name).ToList();
        }

        public void SaveStockname(string stockname)
        {
            _context.Add(new MyStock { Name = stockname });
            _context.SaveChanges();
        }
    }
}
