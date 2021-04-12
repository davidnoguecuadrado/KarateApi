using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IDeportistaClubData
    {
        List<DeportistaClub> Get();
        DeportistaClub Get(int id);
        void Post(DeportistaClub value);
        void Put(DeportistaClub value);
        void Delete(DeportistaClub id);
    }
}
