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
                        string username = "BobAdmin", password = "Y0uG0tMe#Unlock!";

                        if (string.IsNullOrEmpty(loginRequest.login) || string.IsNullOrEmpty(loginRequest.password))
                                return BadRequest("Empty Field");

                        if (username == loginRequest.login)
                        {
                                if (password == loginRequest.password)
                                {
                                        return Ok("https://cdn.discordapp.com/avatars/773259384095768657/1e34825a81c63857aacf7a395e87e579.png");
                                }

                                return BadRequest("Paswword error");
                        }

                        return BadRequest("User not found");
                }
        }
}
