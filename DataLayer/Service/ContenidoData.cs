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
    public class ContenidoData : IContenidoData
    {
        private IContextDb _context;

        public ContenidoData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Contenido value)
        {
            _context.Contenido.Remove(value);
            _context.SaveChanges();
        }

        public List<Contenido> Get()
        {
            return _context.Contenido.ToList();
        }

        public Contenido Get(int id)
        {
            return _context.Contenido.Where(x => x.ID == id).Single();
        }

        public void Post(Contenido value)
        {
            _context.Contenido.Add(value);
            _context.SaveChanges();
        }

        public void Put(Contenido value)
        {
            _context.Contenido.Update(value);
            _context.SaveChanges();
        }
    }
}
