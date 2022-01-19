using Microsoft.AspNetCore.Mvc;
using SharedModels.Models.Requests;
using SharedModels.Models.Responses;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using WebApiApp.Constants;

namespace WebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    [SwaggerResponse((int)HttpStatusCode.NoContent, HttpStatusCodeDescription.NoContent)]
    [SwaggerResponse((int)HttpStatusCode.BadRequest, HttpStatusCodeDescription.BadRequest, typeof(ApiErrorResponse))]
    [SwaggerResponse((int)HttpStatusCode.Unauthorized, HttpStatusCodeDescription.Unauthorized)]
    [SwaggerResponse((int)HttpStatusCode.Forbidden, HttpStatusCodeDescription.Forbidden)]
    public class RegisterController : ControllerBase
    {
        public RegisterController()
        {

        }

        [HttpPost("RegisterUser")]
        [SwaggerResponse((int)HttpStatusCode.OK, HttpStatusCodeDescription.Ok, typeof(RegisterUserResponse))]
        public async Task<IActionResult> RegisterService([FromBody] RegisterUserRequest registerUserRequest)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
