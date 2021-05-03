using BertoniMiniProject.Models;
using BertoniMiniProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniMiniProject.Controllers
{
    public class PhotoController : Controller
    {
        private IEnumerable<Photo> _photos;
        public async Task<IActionResult> Index(int id)
        {
            _photos = await PhotoService.GetPhotos(id);

            return View(_photos);
        }
    }
}
