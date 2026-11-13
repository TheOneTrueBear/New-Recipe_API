using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace New_Recipe_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            if (login.Email == "admin" && login.Password == "adaisthebest")
            {

            }
        }
    }
}
