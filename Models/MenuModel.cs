using System.Text.Json.Serialization;

namespace Blistro.Models;

public sealed class MenuModel
{
    [JsonPropertyName("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("categories")]
    public List<MenuCategory> Categories { get; set; } = [];
}

public sealed class MenuCategory
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("items")]
    public List<MenuItemModel> Items { get; set; } = [];
}

public sealed class MenuItemModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; } = [];

    [JsonPropertyName("allergens")]
    public List<string> Allergens { get; set; } = [];
}
