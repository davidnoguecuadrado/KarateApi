using Domain;
using System.Collections.Generic;


namespace DataLayer.Interface
{
    public interface IClubCategoriaData
    {
        List<ClubCategoria> Get();
        ClubCategoria Get(int id);
        void Post(ClubCategoria value);
        void Put(ClubCategoria value);
        void Delete(ClubCategoria value);
    }
}
