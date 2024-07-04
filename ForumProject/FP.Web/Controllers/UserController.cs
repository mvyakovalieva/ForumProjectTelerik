using Microsoft.AspNetCore.Mvc;

namespace FP.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
