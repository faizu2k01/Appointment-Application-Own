using Microsoft.AspNetCore.Mvc;

namespace APi.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
