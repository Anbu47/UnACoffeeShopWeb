using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.ShopItemModelFirebase
{
    public class AdminModel
    {
        [JsonPropertyName("AccountID")] public string AccountID { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
    }
}
