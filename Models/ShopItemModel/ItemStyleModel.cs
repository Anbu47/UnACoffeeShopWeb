using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models.ShopItemModel
{
    public class ItemStyleModel
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("Name")] public string Name { get; set; }
        [JsonPropertyName("Price")] public float Price { get; set; }

    }
}
