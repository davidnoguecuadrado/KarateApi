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
    public class ContenidoVideoData : IContenidoVideoData
    {
        private IContextDb _context;

        public ContenidoVideoData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(ContenidoVideo value)
        {
            _context.ContenidoVideo.Remove(value);
            _context.SaveChanges();
        }

        public List<ContenidoVideo> Get()
        {
            return _context.ContenidoVideo.ToList();
        }

        public ContenidoVideo Get(int id)
        {
            return _context.ContenidoVideo.Where(x => x.ID == id).Single();
        }

        public void Post(ContenidoVideo value)
        {
            _context.ContenidoVideo.Add(value);
            _context.SaveChanges();
        }

        public void Put(ContenidoVideo value)
        {
            _context.ContenidoVideo.Update(value);
            _context.SaveChanges();
        }
    }
}
