using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Newtonsoft.Json;
using UnACoffeeShop.Models.ShopItemModel;
using static UnACoffeeShop.Dataset.Routes;
namespace UnACoffeeShop.HelperScript
{
    public class ModifyProfileData
    {
        public static void AddProfileData(int profileID, string type, string name, string imageURL, string password, string address, int rating)
        {
            // Read the JSON file content
            string json = System.IO.File.ReadAllText(@$"{Profile}");

            // Deserialize JSON into an object
            ProfileModel[] profileData = JsonConvert.DeserializeObject<ProfileModel[]>(json);
            List<ProfileModel> profileDataList = profileData.ToList();

            // Create a new profile
            ProfileModel newProfileData = new ProfileModel
            {
                ProfileID = profileID,
                Type = type,
                Name = name,
                ImageURL = imageURL,
                Password = password,
                Address = address,
                Rating = rating
            };

            // Add the new profile to the list
            profileDataList.Add(newProfileData);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(profileDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Profile}", updatedJson);
        }

        public static void RemoveProfileData(int profileID)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{Profile}");

            // Deserialize JSON into an object
            ProfileModel[] profileData = JsonConvert.DeserializeObject<ProfileModel[]>(json);
            List<ProfileModel> profileDataList = profileData.ToList();

            ProfileModel profile = profileDataList.First(p => p.ProfileID == profileID);

            // Remove the profile from the list
            profileDataList.Remove(profile);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(profileDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Profile}", updatedJson);
        }
    }
}
