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
    public class DeportistasNivelesAplication : IDeportistasNivelesAplication
    {
        private readonly IDeportistasNivelesData _deportistasNivelesData;
        public DeportistasNivelesAplication(IDeportistasNivelesData deportistasNivelesData)
        {
            _deportistasNivelesData = deportistasNivelesData;
        }
        public void Delete(int id)
        {
            var contenido = _deportistasNivelesData.Get(id);

            _deportistasNivelesData.Delete(contenido);
        }

        public List<DeportistasNiveles> Get()
        {
            return _deportistasNivelesData.Get();
        }

        public DeportistasNiveles Get(int id)
        {
            return _deportistasNivelesData.Get(id);
        }

        public void Post(DeportistasNiveles value)
        {
            _deportistasNivelesData.Post(value);
        }

        public void Put(DeportistasNiveles value)
        {
            _deportistasNivelesData.Put(value);
        }
    }
}
