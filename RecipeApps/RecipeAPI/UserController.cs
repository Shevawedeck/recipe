using CPUFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(BizUser userobj)
        {
            try
            {
                userobj.Login();
                return Ok(userobj);
            }
            catch (Exception ex)
            {
                userobj.ErrorMessage = ex.Message;
                return BadRequest(userobj);
            }

        }
        [HttpPost("logout")]
        public IActionResult Logout(BizUser userobj)
        {
            try
            {
                userobj.Logout();
                return Ok(userobj);
            }
            catch (Exception ex)
            {
                userobj.ErrorMessage = ex.Message;
                return BadRequest(userobj);
            }

        }
    }
}
