using Google.Cloud.Firestore;
using System.Text.Json.Serialization;

namespace UnACoffeeShop.Models.ShopItemModelFirebase
{
    [FirestoreData] // this attribute is require for array of documents in firestore
    public class ShopItemModelFirebase
    {
        [FirestoreDocumentId] public string DocumentID { get; set; }
        [FirestoreProperty("Type")] public string Type { get; set; }
        [FirestoreProperty("Name")] public string Name { get; set; }
        [FirestoreProperty("Description")] public string Description { get; set; }
        [FirestoreProperty("BasePrice")] public float BasePrice { get; set; }
        [FirestoreProperty("ImageURL")] public string ImageURL { get; set; }
        [FirestoreProperty("Decorators")] public List<int> Decorators { get; set; }
    } 
}
