using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APi.Controllers
{
    public class AppointmentController : BaseController
    {
        [HttpPost("create-appointment")]
        [ProducesResponseType(typeof(bool),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateAppointMent()
        {
            return Ok(true);
        }

        [HttpPut("update-appointment")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateAppointMent()
        {
            return Ok(true);
        }

        [HttpGet("list-of-appointment/created")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AppointMentList()
        {
            return Ok(true);
        }

        [HttpGet("list-of-appointment/assigned")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AssignedAppointMentList()
        {
            return Ok(true);
        }

        [HttpDelete("Delete-appointment")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteAppointMent()
        {
            return Ok(true);
        }
    }
}
