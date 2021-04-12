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
    public class NivelAplication : INivelAplication
    {
        private readonly INivelData _nivelData;
        public NivelAplication(INivelData nivelData)
        {
            _nivelData = nivelData;
        }
        public void Delete(int id)
        {
            var contenido = _nivelData.Get(id);

            _nivelData.Delete(contenido);
        }

        public List<Nivel> Get()
        {
            return _nivelData.Get();
        }

        public Nivel Get(int id)
        {
            return _nivelData.Get(id);
        }

        public void Post(Nivel value)
        {
            _nivelData.Post(value);
        }

        public void Put(Nivel value)
        {
            _nivelData.Put(value);
        }
    }
}
