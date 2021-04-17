using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

    public class ClubCategoriaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClubCategoriaAplication _clubCategoriaAplication;
        public ClubCategoriaController(IMapper mapper, IClubCategoriaAplication clubCategoriaAplication)
        {
            _mapper = mapper;
            _clubCategoriaAplication = clubCategoriaAplication;
        }
        // GET: api/<CategoriasController>
        [HttpGet]
        public List<ClubCategoriaDTO> Get()
        {

            var data = _clubCategoriaAplication.Get();
            var datos = data.Select(x => _mapper.Map<ClubCategoriaDTO>(x)).ToList();

            return datos;
        }

        // GET api/<ClubCategoriaController>/5
        [HttpGet("{id}")]
        public ClubCategoriaDTO Get(int id)
        {
            var categoria = _clubCategoriaAplication.Get(id);

            return _mapper.Map<ClubCategoriaDTO>(categoria);
        }

        // POST api/<ClubCategoriaController>
        [HttpPost]
        public void Post([FromBody] ClubCategoriaDTO value)
        {
            var categoria = _mapper.Map<ClubCategoria>(value);
            _clubCategoriaAplication.Post(categoria);
        }

        // PUT api/<ClubCategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<ClubCategoria>(value);
            _clubCategoriaAplication.Put(categoria);

        }

        // DELETE api/<ClubCategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clubCategoriaAplication.Delete(id);
        }
    }
}
