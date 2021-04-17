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

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class ClubController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClubAplication _clubAplication;
        public ClubController(IMapper mapper, IClubAplication clubAplication)
        {
            _mapper = mapper;
            _clubAplication = clubAplication;
        }
        // GET: api/<CategoriasController>
        [HttpGet]
        public List<ClubDTO> Get()
        {

            var data = _clubAplication.Get();
            var casas = data.Select(x => _mapper.Map<ClubDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ClubController>/5
        [HttpGet("{id}")]
        public ClubDTO Get(int id)
        {
            var categoria = _clubAplication.Get(id);

            return _mapper.Map<ClubDTO>(categoria);
        }

        // POST api/<ClubController>
        [HttpPost]
        public void Post([FromBody] ClubDTO value)
        {
            var categoria = _mapper.Map<Club>(value);
            _clubAplication.Post(categoria);
        }

        // PUT api/<ClubController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Club>(value);
            _clubAplication.Put(categoria);

        }

        // DELETE api/<ClubController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clubAplication.Delete(id);

        }
    }
}
