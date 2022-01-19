using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class AuthenticationController : ControllerBase
    {
        public AuthenticationController()
        {

        }

        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpPost("SignIn")]
        [SwaggerResponse((int)HttpStatusCode.OK, HttpStatusCodeDescription.Ok, typeof(SuccessResponse))]
        public async Task<IActionResult> SignInAsync()
        {
            await Task.CompletedTask;
            return Ok();
        }

        /// <summary>
        /// 회원 가입
        /// </summary>
        /// <returns></returns>
        [HttpPost("SignUp")]
        [SwaggerResponse((int)HttpStatusCode.OK, HttpStatusCodeDescription.Ok, typeof(SuccessResponse))]
        public async Task<IActionResult> SignUpAsync()
        {
            await Task.CompletedTask;
            return Ok();
        }

        /// <summary>
        /// 로그아웃 : 결과 기다리지말고 오류발생시에도 무시한채 호출후 즉시 화면이동및 쿠키삭제할것.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpPost("SignOut")]
        [SwaggerResponse((int)HttpStatusCode.OK, HttpStatusCodeDescription.Ok, typeof(SuccessResponse))]
        public async Task<IActionResult> SignOutAsync()
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
