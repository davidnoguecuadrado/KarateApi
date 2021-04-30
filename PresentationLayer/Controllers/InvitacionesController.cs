using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class InvitacionesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IInvitacionesAplication _invitacionesAplication;
        public InvitacionesController(IMapper mapper, IInvitacionesAplication invitacionesAplication)
        {
            _mapper = mapper;
            _invitacionesAplication = invitacionesAplication;
        }

        [HttpGet]
        public List<InvitacionesDTO> Get()
        {

            var data = _invitacionesAplication.Get();
            var casas = data.Select(x => _mapper.Map<InvitacionesDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public InvitacionesDTO Get(int id)
        {
            var categoria = _invitacionesAplication.Get(id);

            return _mapper.Map<InvitacionesDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] InvitacionesDTO value)
        {
            var categoria = _mapper.Map<Invitaciones>(value);
            _invitacionesAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Invitaciones>(value);
            _invitacionesAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _invitacionesAplication.Delete(id);

        }
    }
}
