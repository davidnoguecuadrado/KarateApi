﻿using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
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
    public class UsuarioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioAplication _usuarioAplication;
        public UsuarioController(IMapper mapper, IUsuarioAplication usuarioAplication)
        {
            _mapper = mapper;
            _usuarioAplication = usuarioAplication;
        }

        public List<UsuarioDTO> Get()
        {

            var data = _usuarioAplication.Get();
            var casas = data.Select(x => _mapper.Map<UsuarioDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public UsuarioDTO Get(int id)
        {
            var categoria = _usuarioAplication.Get(id);

            return _mapper.Map<UsuarioDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] UsuarioDTO value)
        {
            var categoria = _mapper.Map<Usuario>(value);
            _usuarioAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Usuario>(value);
            _usuarioAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _usuarioAplication.Delete(id);

        }
    }
}
