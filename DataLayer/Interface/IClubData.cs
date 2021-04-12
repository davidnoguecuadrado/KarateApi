using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IClubData
    {
        List<Club> Get();
        Club Get(int id);
        void Post(Club value);
        void Put(Club value);
        void Delete(Club id);
    }
}
