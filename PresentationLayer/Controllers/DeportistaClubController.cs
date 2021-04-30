using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
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

    public class DeportistaClubController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IDeportistaClubAplication _deportistaClubAplication;
        public DeportistaClubController(IMapper mapper, IDeportistaClubAplication deportistaClubAplication)
        {
            _mapper = mapper;
            _deportistaClubAplication = deportistaClubAplication;
        }

        [HttpGet]
        public List<DeportistaClubDTO> Get()
        {

            var data = _deportistaClubAplication.Get();
            var casas = data.Select(x => _mapper.Map<DeportistaClubDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public DeportistaClubDTO Get(int id)
        {
            var categoria = _deportistaClubAplication.Get(id);

            return _mapper.Map<DeportistaClubDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] DeportistaClubDTO value)
        {
            var categoria = _mapper.Map<DeportistaClub>(value);
            _deportistaClubAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<DeportistaClub>(value);
            _deportistaClubAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deportistaClubAplication.Delete(id);

        }
    }
}
