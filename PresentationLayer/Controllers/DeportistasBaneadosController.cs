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
    public class DeportistasBaneadosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeportistasBaneadosAplication _deportistaBaneadosAplication;
        public DeportistasBaneadosController(IMapper mapper, DeportistasBaneadosAplication deportistaBaneadosAplication)
        {
            _mapper = mapper;
            _deportistaBaneadosAplication = deportistaBaneadosAplication;
        }

        public List<DeportistasBaneadosDTO> Get()
        {

            var data = _deportistaBaneadosAplication.Get();
            var casas = data.Select(x => _mapper.Map<DeportistasBaneadosDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public DeportistasBaneadosDTO Get(int id)
        {
            var categoria = _deportistaBaneadosAplication.Get(id);

            return _mapper.Map<DeportistasBaneadosDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] DeportistasBaneadosDTO value)
        {
            var categoria = _mapper.Map<DeportistasBaneados>(value);
            _deportistaBaneadosAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<DeportistasBaneados>(value);
            _deportistaBaneadosAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deportistaBaneadosAplication.Delete(id);

        }
    }
}
