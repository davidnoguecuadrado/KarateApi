using AutoMapper;
using DataLayer.Service;
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

    public class DeportistaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeportistaAplication _deportistaAplication;
        public DeportistaController(IMapper mapper, IDeportistaAplication deportistaAplication)
        {
            _mapper = mapper;
            _deportistaAplication = deportistaAplication;
        }

        [HttpGet]
        public List<DeportistaDTO> Get()
        {

            var data = _deportistaAplication.Get();
            var casas = data.Select(x => _mapper.Map<DeportistaDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public DeportistaDTO Get(int id)
        {
            var categoria = _deportistaAplication.Get(id);

            return _mapper.Map<DeportistaDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] DeportistaDTO value)
        {
            var categoria = _mapper.Map<Deportista>(value);
            _deportistaAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Deportista>(value);
            _deportistaAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deportistaAplication.Delete(id);

        }
    }
}
