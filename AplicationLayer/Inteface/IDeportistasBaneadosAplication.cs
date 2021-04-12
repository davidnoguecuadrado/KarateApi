using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IDeportistasBaneadosAplication
    {
        List<DeportistasBaneados> Get();
        DeportistasBaneados Get(int id);
        void Post(DeportistasBaneados value);
        void Put(DeportistasBaneados value);
        void Delete(int id);
    }
}
