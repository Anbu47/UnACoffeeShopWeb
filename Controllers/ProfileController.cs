using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using UnACoffeeShop.Models.ShopItemModel;
using UnACoffeeShop.HelperScript;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class ProfileController : ControllerBase
    {
        // Respond to Profile.json data
        [HttpGet("getProfileData")]
        public ProfileModel[]? GetAllData()
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Profile}");
            ProfileModel[]? data = JsonSerializer.Deserialize<ProfileModel[]>(jsonString);
            return data;
        }

        // Receive Profile ID to respond data 
        [HttpGet("getProfileData{id:int}")]
        public ProfileModel GetProfileData(int id)
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Profile}");
            var data = JsonSerializer.Deserialize<ProfileModel[]>(jsonString).ToList();
            return data.First(profile => profile.ProfileID == id);
        }

        // Receive new Profile Data
        [HttpPost("addProfileData{profileID}/{type}/{name}/{imageURL}/{password}/{address}/{rating}")]
        public void AddProfileData(int profileID, string type, string name, string imageURL, string password, string address, int rating)
        {
            ModifyProfileData.AddProfileData(profileID, type, name, imageURL, password, address, rating);
        }

        // Remove Profile Data
        [HttpPost("removeProfileData{profileID}")]
        public void RemoveProfileData(int profileID)
        {
            ModifyProfileData.RemoveProfileData(profileID);
        }
    }
}

