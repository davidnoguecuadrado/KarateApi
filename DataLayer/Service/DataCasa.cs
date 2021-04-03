using Context;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Service
{
    public class DataCasa 
    {
        private IContextDb _context;

        public DataCasa(IContextDb context)
        {
            _context = context;
        }

        public bool GetCasa(int id)
        {
            return true;
            //return _context.Casa.Where(x => x.CompradorID == id).Single();
        }

        public bool GetCasa()
        {
            return true;
            //return _context.Casa.ToList();
        }


        public bool DeleteCasa( )//Casa casa)
        {
            return true;
               /*
            _context.Casa.Remove(casa);
            _context.SaveChanges();
            return casa;
               */
        }

        public bool UpdateCasa()//Casa casa)
         {
            return true;
            /*
            _context.Casa.Update(casa);
            _context.SaveChanges();
            return casa;
           */
        }

        public bool AddCasa()//Casa casa)
        {
            return true;
            /*
            _context.Casa.Add(casa);
            _context.SaveChanges();
            return casa;
            */
        }
    }
}
