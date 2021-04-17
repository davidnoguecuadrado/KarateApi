using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ContenidoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IContenidoAplication _contenidoAplication;
        public ContenidoController(IMapper mapper, IContenidoAplication contenidoAplication)
        {
            _mapper = mapper;
            _contenidoAplication = contenidoAplication;
        }

        [HttpGet]
        public List<ContenidoDTO> Get()
        {

            var data = _contenidoAplication.Get();
            var casas = data.Select(x => _mapper.Map<ContenidoDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public ContenidoDTO Get(int id)
        {
            var categoria = _contenidoAplication.Get(id);

            return _mapper.Map<ContenidoDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] ContenidoDTO value)
        {
            var categoria = _mapper.Map<Contenido>(value);
            _contenidoAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Contenido>(value);
            _contenidoAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contenidoAplication.Delete(id);

        }
    }
}
