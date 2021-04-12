using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IDeportistasNivelesAplication
    {
        List<DeportistasNiveles> Get();
        DeportistasNiveles Get(int id);
        void Post(DeportistasNiveles value);
        void Put(DeportistasNiveles value);
        void Delete(int id);
    }
}
