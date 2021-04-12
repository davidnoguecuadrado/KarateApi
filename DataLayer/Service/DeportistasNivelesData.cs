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
    public class DeportistasNivelesData : IDeportistasNivelesData
    {
        private IContextDb _context;

        public DeportistasNivelesData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(DeportistasNiveles value)
        {
            _context.DeportistasNiveles.Remove(value);
            _context.SaveChanges();
        }

        public List<DeportistasNiveles> Get()
        {
            return _context.DeportistasNiveles.ToList();
        }

        public DeportistasNiveles Get(int id)
        {
            return _context.DeportistasNiveles.Where(x => x.ID == id).Single();
        }

        public void Post(DeportistasNiveles value)
        {
            _context.DeportistasNiveles.Add(value);
            _context.SaveChanges();
        }

        public void Put(DeportistasNiveles value)
        {
            _context.DeportistasNiveles.Update(value);
            _context.SaveChanges();
        }
    }
}
