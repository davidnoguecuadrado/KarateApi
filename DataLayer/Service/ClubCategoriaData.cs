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
    public class ClubCategoriaData : IClubCategoriaData
    {
        private IContextDb _context;

        public ClubCategoriaData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(ClubCategoria value)
        {
            _context.ClubCategoria.Remove(value);
            _context.SaveChanges();
        }

        public List<ClubCategoria> Get()
        {
            return _context.ClubCategoria.ToList();
        }

        public ClubCategoria Get(int id)
        {
            return _context.ClubCategoria.Where(x => x.ID == id).Single();
        }

        public void Post(ClubCategoria value)
        {
            _context.ClubCategoria.Add(value);
            _context.SaveChanges();
        }

        public void Put(ClubCategoria value)
        {
            _context.ClubCategoria.Update(value);
            _context.SaveChanges();
        }
    }
}
