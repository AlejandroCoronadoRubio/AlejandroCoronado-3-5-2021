using BertoniMiniProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniMiniProject.Services
{
    public class CommentService
    {
        public static async Task<IEnumerable<Comment>> GetComments(int postId)
        {
            string response = await Json.GetJsonResponse($"https://jsonplaceholder.typicode.com/comments?postId={postId}");

            return JsonConvert.DeserializeObject<IEnumerable<Comment>>(response);
        }
    }
}
