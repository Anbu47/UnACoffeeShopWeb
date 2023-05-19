using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models.ShopItemModel
{
    public class ShopItemModel
    {
        [JsonPropertyName("id")] public int ID { get; set; }
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("basePrice")] public float BasePrice { get; set; }
        [JsonPropertyName("imageUrl")] public string ImageURL { get; set; }
    } 
}
