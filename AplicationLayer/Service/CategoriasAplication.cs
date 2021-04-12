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
    public class CategoriasAplication : ICategoriasAplication
    {

        public ICategoriasData _categoriasData;
        public CategoriasAplication(ICategoriasData categoriasData)
        {
            _categoriasData = categoriasData;
        }
        public void Delete(int id)
        {
            var categoria = Get(id);
            _categoriasData.Delete(categoria);
        }

        public List<Categorias> Get()
        {

            return _categoriasData.Get(); ;
        }

        public Categorias Get(int id)
        {
            return _categoriasData.Get(id);
        }

        public void Post(Categorias value)
        {
            _categoriasData.Post(value);
        }

        public void Put(Categorias value)
        {
            _categoriasData.Put(value);
        }
    }
}
