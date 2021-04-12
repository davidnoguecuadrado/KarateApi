using Context;
using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service
{
    public class DeportistasBaneadosData : IDeportistasBaneadosData
    {
        private IContextDb _context;

        public DeportistasBaneadosData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(DeportistasBaneados value)
        {
            _context.DeportistasBaneados.Remove(value);
            _context.SaveChanges();
        }

        public List<DeportistasBaneados> Get()
        {
            return _context.DeportistasBaneados.ToList();
        }

        public DeportistasBaneados Get(int id)
        {
            return _context.DeportistasBaneados.Where(x => x.ID == id).Single();
        }

        public void Post(DeportistasBaneados value)
        {
            _context.DeportistasBaneados.Add(value);
            _context.SaveChanges();
        }

        public void Put(DeportistasBaneados value)
        {
            _context.DeportistasBaneados.Update(value);
            _context.SaveChanges();
        }
    }
}
