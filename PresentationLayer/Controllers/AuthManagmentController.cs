using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Web.Services3.Referral;
using PresentationLayer.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagmentController : ControllerBase
    {
        private readonly JwtConfig _jwtConfig;

        public AuthManagmentController( 
                IOptionsMonitor<JwtConfig> optionsMonitor
        ) {
            _jwtConfig = optionsMonitor.CurrentValue;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UsuarioDTO user) 
        {
            if (ModelState.IsValid)
            {
                var existingUser = true;
                if (!existingUser) {
                    return BadRequest("User no exist");
                }
                //WE CAN utilse the model

                var  jwtToken = GenerateJwtToken(user);
                return Ok(jwtToken);

            }


            return BadRequest("Invalid request");
        }

        private string GenerateJwtToken(UsuarioDTO user) 
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDsecription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("ID", user.ID.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Correo),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Correo),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDsecription);
            var jwtToken = jwtTokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}
