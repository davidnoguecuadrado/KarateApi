using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IClubCategoriaAplication
    {
        List<ClubCategoria> Get();
        ClubCategoria Get(int id);
        void Post(ClubCategoria value);
        void Put(ClubCategoria value);
        void Delete(int id);
    }
}
