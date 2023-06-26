using Microsoft.AspNetCore.Mvc;

namespace APi.Controllers
{
    public class AppointmentController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
