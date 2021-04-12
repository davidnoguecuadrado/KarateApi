using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IDeportistaData
    {
        List<Deportista> Get();
        Deportista Get(int id);
        void Post(Deportista value);
        void Put(Deportista value);
        void Delete(Deportista id);
    }
}
