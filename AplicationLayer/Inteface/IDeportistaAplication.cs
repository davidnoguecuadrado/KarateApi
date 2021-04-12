using Domain;
using System.Collections.Generic;

namespace DataLayer.Service
{
    public interface IDeportistaAplication
    {
        List<Deportista> Get();
        Deportista Get(int id);
        void Post(Deportista value);
        void Put(Deportista value);
        void Delete(int id);
    }
}