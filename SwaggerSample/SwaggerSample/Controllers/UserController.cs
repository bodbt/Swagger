using SwaggerSample.Models;
using System;
using System.Web;
using System.Web.Http;

namespace SwaggerSample.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/user/{userId}")]
        public IHttpActionResult FindUser(string userId)
        {
            var user = new FindUserResponseModel()
            {
                UserId = "0001",
                UserName = "Lei Wang",
                TelNo = "090-1234-5678"
            };
            
            return Ok(user);
        }


        [HttpPost]
        [Route("api/user")]
        public IHttpActionResult RegisterUser(RegisterUserRequestModel user)
        {
            //登録処理
            var response = new RegisterUserResponseModel()
            {
                Result = new ResultMessageModel
                {
                    Message = "Success."
                }
            };

            return InternalServerError();
        }

        [HttpGet]
        [Route("api/authority")]
        public IHttpActionResult Authority()
        {
            var user = HttpContext.Current.User;

            if (user.IsInRole("Administrators"))
                return Ok();
            else
                return BadRequest();
        }
    }
}
