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
    public class DeportistaData : IDeportistaData
    {
        private IContextDb _context;

        public DeportistaData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Deportista value)
        {
            _context.Deportista.Remove(value);
            _context.SaveChanges();
        }

        public List<Deportista> Get()
        {
            return _context.Deportista.ToList();
        }

        public Deportista Get(int id)
        {
            return _context.Deportista.Where(x => x.ID == id).Single();
        }

        public void Post(Deportista value)
        {
            _context.Deportista.Add(value);
            _context.SaveChanges();
        }

        public void Put(Deportista value)
        {
            _context.Deportista.Update(value);
            _context.SaveChanges();
        }
    }
}
