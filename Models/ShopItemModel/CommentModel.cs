using System;
using System.Text.Json.Serialization;
namespace UnACoffeeShop.Models.ShopItemModel
{
    public class CommentModel
    {
        [JsonPropertyName("ProfileID")] public int ProfileID { get; set; }
        [JsonPropertyName("OrderID")] public int OrderID { get; set; }
        [JsonPropertyName("Datetime")] public string Datetime { get; set; }
        [JsonPropertyName("Comment")] public string Comment { get; set; }
        [JsonPropertyName("CommentID")] public int CommentID { get; set; }

    }
}
