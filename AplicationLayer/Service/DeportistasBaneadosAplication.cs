using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public class DeportistasBaneadosAplication : IDeportistasBaneadosAplication
    {
        private readonly IDeportistasBaneadosData _deportistaBaneadosData;
        public DeportistasBaneadosAplication(IDeportistasBaneadosData deportistaBaneadosData)
        {
            _deportistaBaneadosData = deportistaBaneadosData;
        }
        public void Delete(int id)
        {
            var contenido = _deportistaBaneadosData.Get(id);

            _deportistaBaneadosData.Delete(contenido);
        }

        public List<DeportistasBaneados> Get()
        {
            return _deportistaBaneadosData.Get();
        }

        public DeportistasBaneados Get(int id)
        {
            return _deportistaBaneadosData.Get(id);
        }

        public void Post(DeportistasBaneados value)
        {
            _deportistaBaneadosData.Post(value);
        }

        public void Put(DeportistasBaneados value)
        {
            _deportistaBaneadosData.Put(value);
        }
    }
}
