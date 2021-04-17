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

    public class ContenidoVideoController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IContenidoVideoAplication _contenidoVideoAplication;
        public ContenidoVideoController(IMapper mapper, IContenidoVideoAplication contenidoVideoAplication)
        {
            _mapper = mapper;
            _contenidoVideoAplication = contenidoVideoAplication;
        }

        [HttpGet]
        public List<ContenidoVideoDTO> Get()
        {

            var data = _contenidoVideoAplication.Get();
            var casas = data.Select(x => _mapper.Map<ContenidoVideoDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public ContenidoVideoDTO Get(int id)
        {
            var categoria = _contenidoVideoAplication.Get(id);

            return _mapper.Map<ContenidoVideoDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] ContenidoVideoDTO value)
        {
            var categoria = _mapper.Map<ContenidoVideo>(value);
            _contenidoVideoAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<ContenidoVideo>(value);
            _contenidoVideoAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contenidoVideoAplication.Delete(id);

        }
    }
}
