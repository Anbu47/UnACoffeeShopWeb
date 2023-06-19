using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnACoffeeShop.Models;
using static UnACoffeeShop.Dataset.Routes;

namespace UnACoffeeShop.HelperScript
{
    public class ModifyCommentData
    {
        public static void AddCommentData(int commentID, int profileID, int orderID, string datetime, string comment)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{Comment}");

            // Deserialize JSON into an object
            CommentModel[] commentData = JsonConvert.DeserializeObject<CommentModel[]>(json);
            List<CommentModel> commentDataList = commentData != null ? new List<CommentModel>(commentData) : new List<CommentModel>();

            // Create a new comment
            CommentModel newCommentData = new CommentModel
            {
                CommentID = commentID,
                ProfileID = profileID,
                OrderID = orderID,
                Datetime = datetime,
                Comment = comment
            };

            // Add the new comment to the list
            commentDataList.Add(newCommentData);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(commentDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Comment}", updatedJson);
        }

        public static void RemoveCommentData(int commentID)
        {
            // Read the JSON file content
            string json = File.ReadAllText(@$"{Comment}");

            // Deserialize JSON into an object
            CommentModel[] commentData = JsonConvert.DeserializeObject<CommentModel[]>(json);
            List<CommentModel> commentDataList = commentData != null ? new List<CommentModel>(commentData) : new List<CommentModel>();

            CommentModel comment = commentDataList.Find(c => c.CommentID == commentID);

            // Remove the comment from the list
            commentDataList.Remove(comment);

            // Serialize the updated list back to JSON
            string updatedJson = JsonConvert.SerializeObject(commentDataList, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(@$"{Comment}", updatedJson);
        }
    }
}
