using Microsoft.AspNetCore.Mvc;

namespace FP.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
