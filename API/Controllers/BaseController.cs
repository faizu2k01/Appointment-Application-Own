using Microsoft.AspNetCore.Mvc;

namespace APi.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
