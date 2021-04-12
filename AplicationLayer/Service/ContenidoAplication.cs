using AplicationLayer.Inteface;
using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Service
{
    public class ContenidoAplication : IContenidoAplication
    {
        private readonly IContenidoData _contenidoData;
        public ContenidoAplication(IContenidoData contenidoData)
        {
            _contenidoData = contenidoData;
        }
        public void Delete(int id)
        {
            var contenido = _contenidoData.Get(id);

            _contenidoData.Delete(contenido);
        }

        public List<Contenido> Get()
        {
            return _contenidoData.Get();
        }

        public Contenido Get(int id)
        {
            return _contenidoData.Get(id);
        }

        public void Post(Contenido value)
        {
            _contenidoData.Post(value);
        }

        public void Put(Contenido value)
        {
            _contenidoData.Put(value);
        }
    }
}
