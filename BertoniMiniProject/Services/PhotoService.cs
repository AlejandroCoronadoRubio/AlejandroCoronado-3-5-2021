using BertoniMiniProject.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniMiniProject.Services
{
    public class PhotoService
    {
        public static async Task<IEnumerable<Photo>> GetPhotos(int albumId)
        {
            string response = await Json.GetJsonResponse($"https://jsonplaceholder.typicode.com/photos?albumId={albumId}");

            return JsonConvert.DeserializeObject<IEnumerable<Photo>>(response);
        }
    }
}
