using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;   
using LoginAuthAPI.Models;

namespace LoginAuthAPI.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Generate a secure key for JWT signing
        string jwtKey = JwtKeyGenerator.GenerateKey(64); 
        // Generate a 64-byte key 
        // Store the key in configuration or another secure location
        Configuration["JwtKey"] = jwtKey;

        [Route("GetTestUnAuthorise")]
        [AllowAnonymous]
        [HttpGet]

        public async Task<IActionResult> GetTestUnAuthorise()
        {
            return Ok("Hello world from GetTestUnAuthorise");
        }

        [Route("GetTestAuthorise")]
        [Authorize]
        [HttpPost]

        public async Task<IActionResult> GetTestAuthorise()
        {
            return Ok("Hello world from GetTestAuthorise");
        }

        [Route("CheckLogin")]
        [AllowAnonymous]
        [HttpGet]

        public async Task<IActionResult> CheckLogin(LoginModel model)
        {
            if (model.Staff_ID == "user" && model.Password == "password")
            {
                var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guild.NewGuild().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("UserId", model.Staff_ID)
                };
                var key = new SymmetricSecurity(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]));
                var signIn = new SigningCredentials(key, SecurityAlogrithms.HmacSha256);
                var token = new JwtSecurityTokens(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires:DateTime.UtcNow.AddMinutes(10),
                    siginingCredentials:signIn);
                model.UserMessage = "Login Successful";
                model.UserMessage = new JwtSecurityTokenHandler().WriteToken(token);
            }
            else
            {
                model.UserMessage = "Login Failed";
            }
            return Ok(model);
        }



    }
}