using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IContenidoData
    {
        List<Contenido> Get();
        Contenido Get(int id);
        void Post(Contenido value);
        void Put(Contenido value);
        void Delete(Contenido id);
    }
}
