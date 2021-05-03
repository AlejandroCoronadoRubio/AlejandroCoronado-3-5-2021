using BertoniMiniProject.Models;
using BertoniMiniProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BertoniMiniProject.Controllers
{
    public class CommentController : Controller
    {
        private IEnumerable<Comment> _comments;
        public async Task<IActionResult> Index(int id)
        {
            _comments = await CommentService.GetComments(id);

            return View(_comments);
        }
    }
}
