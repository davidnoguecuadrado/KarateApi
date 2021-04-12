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
    public class NivelData : INivelData
    {
            private IContextDb _context;

            public NivelData(IContextDb context)
            {
                _context = context;
            }
            public void Delete(Nivel value)
            {
                _context.Nivel.Remove(value);
                _context.SaveChanges();
            }

            public List<Nivel> Get()
            {
                return _context.Nivel.ToList();
            }

            public Nivel Get(int id)
            {
                return _context.Nivel.Where(x => x.ID == id).Single();
            }

            public void Post(Nivel value)
            {
                _context.Nivel.Add(value);
                _context.SaveChanges();
            }

            public void Put(Nivel value)
            {
                _context.Nivel.Update(value);
                _context.SaveChanges();
            }
     }
}
