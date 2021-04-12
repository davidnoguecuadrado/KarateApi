using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service
{
    public class DeportistaAplication : IDeportistaAplication
    {
        private readonly IDeportistaData _deportistaData;
        public DeportistaAplication(IDeportistaData deportistaData)
        {
            _deportistaData = deportistaData;
        }

        public void Delete(int id)
        {
            var contenido = _deportistaData.Get(id);

            _deportistaData.Delete(contenido);
        }

        public List<Deportista> Get()
        {
            return _deportistaData.Get();
        }

        public Deportista Get(int id)
        {
            return _deportistaData.Get(id);
        }

        public void Post(Deportista value)
        {
            _deportistaData.Post(value);
        }

        public void Put(Deportista value)
        {
            _deportistaData.Put(value);
        }
    }
}
