using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IDeportistasBaneadosData
    {
        List<DeportistasBaneados> Get();
        DeportistasBaneados Get(int id);
        void Post(DeportistasBaneados value);
        void Put(DeportistasBaneados value);
        void Delete(DeportistasBaneados id);
    }
}
