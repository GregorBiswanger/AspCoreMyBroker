using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace MyBroker.Data
{
    public class StockRepository : IStockRepository
    {
        private HttpClient _httpClient;

        public StockRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://stockplaceholder.herokuapp.com/api/stocks/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Stock>> GetAsync(string query, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(query, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<Stock>>();
            }

            return new List<Stock>();
        }
    }
}
