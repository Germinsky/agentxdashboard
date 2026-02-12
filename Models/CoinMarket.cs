using System.Text.Json.Serialization;

namespace AgentXDashboard.Models;

public sealed class CoinMarket
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("current_price")]
    public decimal CurrentPrice { get; set; }

    [JsonPropertyName("market_cap")]
    public decimal MarketCap { get; set; }

    [JsonPropertyName("market_cap_rank")]
    public int MarketCapRank { get; set; }

    [JsonPropertyName("total_volume")]
    public decimal TotalVolume { get; set; }

    [JsonPropertyName("high_24h")]
    public decimal High24h { get; set; }

    [JsonPropertyName("low_24h")]
    public decimal Low24h { get; set; }

    [JsonPropertyName("price_change_percentage_1h_in_currency")]
    public decimal? Change1h { get; set; }

    [JsonPropertyName("price_change_percentage_24h")]
    public decimal? Change24h { get; set; }

    [JsonPropertyName("price_change_percentage_7d_in_currency")]
    public decimal? Change7d { get; set; }
}
