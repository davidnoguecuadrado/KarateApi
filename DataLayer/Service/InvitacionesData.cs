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
    public class InvitacionesData : IInvitacionesData
    {
        private IContextDb _context;

        public InvitacionesData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Invitaciones value)
        {
            _context.Invitaciones.Remove(value);
            _context.SaveChanges();
        }

        public List<Invitaciones> Get()
        {
            return _context.Invitaciones.ToList();
        }

        public Invitaciones Get(int id)
        {
            return _context.Invitaciones.Where(x => x.ID == id).Single();
        }

        public void Post(Invitaciones value)
        {
            _context.Invitaciones.Add(value);
            _context.SaveChanges();
        }

        public void Put(Invitaciones value)
        {
            _context.Invitaciones.Update(value);
            _context.SaveChanges();
        }
    }
}
