using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models
{
    public class AdminModel
    {
        [JsonPropertyName("AccountID")] public string AccountID { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
    }
}
