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
    public class UsuarioData : IUsuarioData
    {
        private IContextDb _context;

        public UsuarioData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Usuario value)
        {
            _context.Usuario.Remove(value);
            _context.SaveChanges();
        }

        public List<Usuario> Get()
        {
            return _context.Usuario.ToList();
        }

        public Usuario Get(int id)
        {
            return _context.Usuario.Where(x => x.ID == id).Single();
        }

        public void Post(Usuario value)
        {
            _context.Usuario.Add(value);
            _context.SaveChanges();
        }

        public void Put(Usuario value)
        {
            _context.Usuario.Update(value);
            _context.SaveChanges();
        }
    }
}
