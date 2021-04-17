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

    public class DeportistasNivelesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeportistasNivelesAplication _deportistaNivelesAplication;
        public DeportistasNivelesController(IMapper mapper, IDeportistasNivelesAplication deportistaNivelesAplication)
        {
            _mapper = mapper;
            _deportistaNivelesAplication = deportistaNivelesAplication;
        }

        [HttpGet]
        public List<DeportistasNivelesDTO> Get()
        {

            var data = _deportistaNivelesAplication.Get();
            var casas = data.Select(x => _mapper.Map<DeportistasNivelesDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public DeportistasNivelesDTO Get(int id)
        {
            var categoria = _deportistaNivelesAplication.Get(id);

            return _mapper.Map<DeportistasNivelesDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] DeportistasNivelesDTO value)
        {
            var categoria = _mapper.Map<DeportistasNiveles>(value);
            _deportistaNivelesAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<DeportistasNiveles>(value);
            _deportistaNivelesAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deportistaNivelesAplication.Delete(id);

        }
    }
}
