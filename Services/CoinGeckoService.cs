using System.Net.Http.Json;
using AgentXDashboard.Models;

namespace AgentXDashboard.Services;

public sealed class CoinGeckoService
{
    private readonly HttpClient _http;

    public CoinGeckoService(HttpClient http)
    {
        _http = http;
    }

    public async Task<IReadOnlyList<CoinMarket>> GetMarketsAsync(CancellationToken cancellationToken)
    {
        var url = "coins/markets?vs_currency=usd&order=market_cap_desc&per_page=12&page=1&sparkline=false&price_change_percentage=1h,24h,7d";
        var result = await _http.GetFromJsonAsync<List<CoinMarket>>(url, cancellationToken);
        return result ?? new List<CoinMarket>();
    }
}
