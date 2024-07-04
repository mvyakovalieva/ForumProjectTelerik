using Microsoft.AspNetCore.Mvc;

namespace FP.Web.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
