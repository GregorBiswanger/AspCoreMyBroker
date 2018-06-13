using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyBroker.Data
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAsync(string query, CancellationToken cancellationToken);
    }
}