

using AplicationLayer.Inteface;
using DataLayer.Interface;
using Domain;
using System.Collections.Generic;

namespace AplicationLayer.Service
{
    public class ContenidoVideoAplication : IContenidoVideoAplication
    {
        private readonly IContenidoVideoData _contenidoVideoData;
        public ContenidoVideoAplication(IContenidoVideoData contenidoVideoData)
        {
            _contenidoVideoData = contenidoVideoData;
        }

        public void Delete(int id)
        {
            var contenido = _contenidoVideoData.Get(id);

            _contenidoVideoData.Delete(contenido);
        }

        public List<ContenidoVideo> Get()
        {
            return _contenidoVideoData.Get();
        }

        public ContenidoVideo Get(int id)
        {
            return _contenidoVideoData.Get(id);
        }

        public void Post(ContenidoVideo value)
        {
            _contenidoVideoData.Post(value);
        }

        public void Put(ContenidoVideo value)
        {
            _contenidoVideoData.Put(value);
        }

   
    }
}
