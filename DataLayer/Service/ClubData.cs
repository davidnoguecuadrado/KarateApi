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
    public class ClubData : IClubData
    {
        private IContextDb _context;

        public ClubData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Club value)
        {
            _context.Club.Remove(value);
            _context.SaveChanges();
        }

        public List<Club> Get()
        {
            return _context.Club.ToList();
        }

        public Club Get(int id)
        {
            return _context.Club.Where(x => x.ID == id).Single();
        }

        public void Post(Club value)
        {
            _context.Club.Add(value);
            _context.SaveChanges();
        }

        public void Put(Club value)
        {
            _context.Club.Update(value);
            _context.SaveChanges();
        }
    }
}
