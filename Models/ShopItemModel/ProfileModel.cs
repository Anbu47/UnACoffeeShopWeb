using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.ProfileModel
{
    public class ProfileModel
    {
        [JsonPropertyName("ProfileID")] public int ProfileID { get; set; }
        [JsonPropertyName("Type")] public string Type { get; set; }
        [JsonPropertyName("Name")] public string Name { get; set; }
        [JsonPropertyName("ImageURL")] public string ImageURL { get; set; }
        [JsonPropertyName("Password")] public string Password { get; set; }
        [JsonPropertyName("Address")] public string Address { get; set; }
        [JsonPropertyName("Rating")] public int Rating { get; set; }
    }
}
