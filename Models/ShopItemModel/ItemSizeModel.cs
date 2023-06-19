using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace UnACoffeeShop.Models.ShopItemModel
{
    public class ItemSizeModel
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("Name")] public string Name { get; set; }
        [JsonPropertyName("Price")] public float Price { get; set; }
    }
}
