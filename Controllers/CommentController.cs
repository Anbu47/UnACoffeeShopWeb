using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using UnACoffeeShop.HelperScript;
using static UnACoffeeShop.Dataset.Routes;
using UnACoffeeShop.Models.ShopItemModel;

namespace UnACoffeeShop.Controllers
{
    [ApiController]
    [Route("api/data")]
    public class CommentController : ControllerBase
    {
        // Get all comment data
        [HttpGet("getCommentData")]
        public CommentModel[] GetAllData()
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Comment}");
            CommentModel[] data = JsonSerializer.Deserialize<CommentModel[]>(jsonString);
            return data;
        }

        // Get comment data by ID
        [HttpGet("getCommentData/{id:int}")]
        public CommentModel GetCommentData(int id)
        {
            string jsonString = System.IO.File.ReadAllText(@$"{Comment}");
            var data = JsonSerializer.Deserialize<CommentModel[]>(jsonString).ToList();
            return data.First(comment => comment.CommentID == id);
        }

        // Add new comment
        [HttpPost("addCommentData")]
        public void AddCommentData([FromBody] CommentModel comment)
        {
            ModifyCommentData.AddCommentData(comment.CommentID, comment.ProfileID, comment.OrderID, comment.Datetime, comment.Comment);
        }

        // Remove comment by ID
        [HttpPost("removeCommentData/{id:int}")]
        public void RemoveCommentData(int id)
        {
            ModifyCommentData.RemoveCommentData(id);
        }
    }
}
