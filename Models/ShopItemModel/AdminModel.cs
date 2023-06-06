using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.ShopItemModel
{
    public class AdminModel
    {
        [JsonPropertyName("AccountID")] public string AccountID { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
    }
}
