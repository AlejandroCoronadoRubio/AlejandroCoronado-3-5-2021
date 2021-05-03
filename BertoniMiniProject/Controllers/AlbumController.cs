using BertoniMiniProject.Models;
using BertoniMiniProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniMiniProject.Controllers
{
    public class AlbumController : Controller
    {
        private IEnumerable<Album> _albums;
        public async Task<IActionResult> Index()
        {
            _albums = await AlbumService.GetAlbums();

            return View(_albums);
        }

    }
}
