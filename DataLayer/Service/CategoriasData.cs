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
    public class CategoriasData : ICategoriasData
    {
        private IContextDb _context;

        public CategoriasData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Categorias value)
        {
            _context.Categorias.Remove(value);
            _context.SaveChanges();
        }

        public List<Categorias> Get()
        {
            return _context.Categorias.ToList();
        }

        public Categorias Get(int id)
        {
            return _context.Categorias.Where(x => x.ID == id).Single();
        }

        public void Post(Categorias value)
        {
            _context.Categorias.Add(value);
            _context.SaveChanges();
        }

        public void Put(Categorias value)
        {
            _context.Categorias.Update(value);
            _context.SaveChanges();
        }
    }
}
