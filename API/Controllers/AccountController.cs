using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APi.Controllers
{
    public class AccountController : BaseController
    {
        [HttpPost("register")]
        [ProducesResponseType(typeof(bool),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> Register()
        {
            return Ok(true);
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Login()
        {
            return Ok(true);
        }

        [HttpPost("logout")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Logout()
        {
            return Ok(true);
        }


    }
}
