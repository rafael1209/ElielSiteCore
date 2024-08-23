using ElielSiteCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElielSiteCore.Controllers
{
        [Route("api/auth")]
        [ApiController]
        public class AuthorizeController : Controller
        {
                public AuthorizeController()
                { 

                }

                [HttpPost]
                public IActionResult Login(LoginRequest loginRequest)
                {
                        string username = "bob2012", password = "12345679012";

                        if (string.IsNullOrEmpty(loginRequest.login) || string.IsNullOrEmpty(loginRequest.password))
                                return BadRequest("Empty Field");

                        if (username == loginRequest.login)
                        {
                                if (password == loginRequest.password)
                                {
                                        return Ok("Login succses!");
                                }

                                return BadRequest("Paswword error");
                        }

                        return BadRequest("User not found");
                }
        }
}
