using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("AllowOrigin")]
    public class AuthManagmentController : ControllerBase
    {
        private readonly JwtConfig _jwtConfig;

        private readonly IMapper _mapper;
        private readonly IUsuarioAplication _usuarioAplication;
        private JWT key;
        public AuthManagmentController( 
                IOptionsMonitor<JwtConfig> optionsMonitor,
                IMapper mapper, 
                IUsuarioAplication usuarioAplication
        ) {
            _jwtConfig = optionsMonitor.CurrentValue;
            _mapper = mapper;
            _usuarioAplication = usuarioAplication;
            this.key = new JWT();
        }

        [HttpPost]
        public JWT Login([FromBody] UsuarioDTO user) 
        {
            if (ModelState.IsValid)
            {
                var existingUser = true;
                if (!existingUser) {
                    return this.key;
                }
                //WE CAN utilse the model

                this.key.jwt = GenerateJwtToken(user);
                return this.key;

            }


            return this.key;
        }

        private string GenerateJwtToken(UsuarioDTO user) 
        {
            var categoria = _mapper.Map<Usuario>(user);

            if (_usuarioAplication.ifExist(categoria))
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
            else {
                return "";
            }
        }
    }
}
