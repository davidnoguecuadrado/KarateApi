using Domain;
using System;
using System.Collections.Generic;

namespace AplicationLayer.Inteface
{
    public interface IClubAplication
    {
        List<Club> Get();
        Club Get(int id);
        void Post(Club value);
        void Put(Club value);
        void Delete(int id);
    }
}
