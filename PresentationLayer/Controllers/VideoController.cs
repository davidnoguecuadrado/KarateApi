using AplicationLayer.Inteface;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class VideoController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IVideoAplication _videoAplication;
        public VideoController(IMapper mapper, IVideoAplication videoAplication)
        {
            _mapper = mapper;
            _videoAplication = videoAplication;
        }


        [HttpGet]
        public List<VideoDTO> Get()
        {

            var data = _videoAplication.Get();
            var casas = data.Select(x => _mapper.Map<VideoDTO>(x)).ToList();

            return casas;
        }

        // GET api/<ContenidoController>/5
        [HttpGet("{id}")]
        public VideoDTO Get(int id)
        {
            var categoria = _videoAplication.Get(id);

            return _mapper.Map<VideoDTO>(categoria);
        }

        // POST api/<ContenidoController>
        [HttpPost]
        public void Post([FromBody] VideoDTO value)
        {
            var categoria = _mapper.Map<Video>(value);
            _videoAplication.Post(categoria);
        }

        // PUT api/<ContenidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var categoria = _mapper.Map<Video>(value);
            _videoAplication.Put(categoria);

        }

        // DELETE api/<ContenidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _videoAplication.Delete(id);

        }
    }
}