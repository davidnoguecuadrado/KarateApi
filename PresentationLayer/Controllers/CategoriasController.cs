using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ICategoriasAplication _categoriasAplication;

        public CategoriasController(IMapper mapper, ICategoriasAplication categoriasAplication)
        {
            _mapper = mapper;
            _categoriasAplication = categoriasAplication;
        }
        // GET: api/<CategoriasController>
        [HttpGet]
        public List<CategoriasDTO> Get()
        {
            var data = _categoriasAplication.Get();
  
            var casas = data.Select(x => _mapper.Map<CategoriasDTO>(x)).ToList();

            return casas;
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id}")]
        public CategoriasDTO Get(int id)
        {
            var categoria = _categoriasAplication.Get(id);

            return _mapper.Map<CategoriasDTO>(categoria);
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public void Post([FromBody] CategoriasDTO value)
        {
            var categoria = _mapper.Map<Categorias>(value);
            _categoriasAplication.Post(categoria);
        }

        // PUT api/<CategoriasController>/5
        [HttpPut()]
        public void Put([FromBody] Categorias value)
        {
            var categoria = _mapper.Map<Categorias>(value);
            _categoriasAplication.Put(categoria);
        }

        // DELETE api/<CategoriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoriasAplication.Delete(id);
        }
    }
}
