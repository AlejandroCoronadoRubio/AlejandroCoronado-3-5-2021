using BertoniMiniProject.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniMiniProject.Services
{
    public class AlbumService
    {
        public static async Task<IEnumerable<Album>> GetAlbums()
        {
            string response = await Json.GetJsonResponse("https://jsonplaceholder.typicode.com/albums");

            return JsonConvert.DeserializeObject<IEnumerable<Album>>(response);
        }
    }
}
