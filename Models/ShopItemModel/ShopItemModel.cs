using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models.ShopItemModel
{
    public class ShopItemModel
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("Type")] public string Type { get; set; }
        [JsonPropertyName("Name")] public string Name { get; set; }
        [JsonPropertyName("Description")] public string Description { get; set; }
        [JsonPropertyName("BasePrice")] public float BasePrice { get; set; }
        [JsonPropertyName("ImageURL")] public string ImageURL { get; set; }
        [JsonPropertyName("Decorators")] public DecoratorModel[] Decorators { get; set; }
    } 
}
