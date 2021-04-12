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
    public class DeportistaClubData : IDeportistaClubData
    {
        
        private IContextDb _context;

        public DeportistaClubData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(DeportistaClub value)
        {
            _context.DeportistaClub.Remove(value);
            _context.SaveChanges();
        }

        public List<DeportistaClub> Get()
        {
            return _context.DeportistaClub.ToList();
        }

        public DeportistaClub Get(int id)
        {
            return _context.DeportistaClub.Where(x => x.ID == id).Single();
        }

        public void Post(DeportistaClub value)
        {
            _context.DeportistaClub.Add(value);
            _context.SaveChanges();
        }

        public void Put(DeportistaClub value)
        {
            _context.DeportistaClub.Update(value);
            _context.SaveChanges();
        }
        
    }
}
