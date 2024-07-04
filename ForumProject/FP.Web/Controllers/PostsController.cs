using Microsoft.AspNetCore.Mvc;

namespace FP.Web.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
