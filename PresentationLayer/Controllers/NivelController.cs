using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
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
    public class NivelController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INivelAplication _nivelAplication;
        public NivelController(IMapper mapper, INivelAplication nivelAplication)
        {
            _mapper = mapper;
            _nivelAplication = nivelAplication;
        }

        public List<NivelDTO> Get()
        {

            var data = _nivelAplication.Get();
            var casas = data.Select(x => _mapper.Map<NivelDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public NivelDTO Get(int id)
        {
            var categoria = _nivelAplication.Get(id);

            return _mapper.Map<NivelDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] NivelDTO value)
        {
            var categoria = _mapper.Map<Nivel>(value);
            _nivelAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Nivel>(value);
            _nivelAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _nivelAplication.Delete(id);

        }
    }
}
