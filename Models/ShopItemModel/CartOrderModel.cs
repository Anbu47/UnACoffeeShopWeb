using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.CartOrderModel
{
    public class CartOrderModel
    {
        [JsonPropertyName("OrderID")] public int OrderID { get; set; }
        [JsonPropertyName("ProfileID")] public int ProfileID { get; set; }
        [JsonPropertyName("Description")] public string Description { get; set; }
        [JsonPropertyName("Cost")] public double Cost { get; set; }
        [JsonPropertyName("Status")] public int Status { get; set; }
    }
}
