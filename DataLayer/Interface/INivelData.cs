using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface INivelData
    {
        List<Nivel> Get();
        Nivel Get(int id);
        void Post(Nivel value);
        void Put(Nivel value);
        void Delete(Nivel id);
    }
}
