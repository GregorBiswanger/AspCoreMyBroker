using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBroker.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyBroker.Pages
{
    public class IndexModel : PageModel
    {
        public List<Stock> Stocks { get; set; } = new List<Stock>();

        private IStockDepot _stockDepot;
        private IStockRepository _stockRepository;

        public IndexModel(IStockDepot stockDepot, IStockRepository stockRepository)
        {
            _stockDepot = stockDepot;
            _stockRepository = stockRepository;
        }

        public async Task OnGet()
        {
            string stocknames = string.Join('/', _stockDepot.GetUserStocknames());

            if (!string.IsNullOrEmpty(stocknames))
            {
                Stocks = await _stockRepository.GetAsync(stocknames, CancellationToken.None);
            }
        }
    }
}
