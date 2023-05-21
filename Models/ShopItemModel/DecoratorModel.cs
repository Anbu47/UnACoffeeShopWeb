using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.ShopItemModel
{
    public class DecoratorModel
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("Type")] public string Type { get; set; }
        [JsonPropertyName("Name")] public string Name { get; set; }
        [JsonPropertyName("Price")] public float Price { get; set; }
        [JsonPropertyName("GroupID")] public int GroupID { get; set; }
    }
}
