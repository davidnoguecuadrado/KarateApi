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
    public class VideoData : IVideoData
    {
        private IContextDb _context;

        public VideoData(IContextDb context)
        {
            _context = context;
        }
        public void Delete(Video value)
        {
            _context.Video.Remove(value);
            _context.SaveChanges();
        }

        public List<Video> Get()
        {
            return _context.Video.ToList();
        }

        public Video Get(int id)
        {
            return _context.Video.Where(x => x.ID == id).Single();
        }

        public void Post(Video value)
        {
            _context.Video.Add(value);
            _context.SaveChanges();
        }

        public void Put(Video value)
        {
            _context.Video.Update(value);
            _context.SaveChanges();
        }
    }
}
