using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IContenidoAplication
    {
        List<Contenido> Get();
        Contenido Get(int id);
        void Post(Contenido value);
        void Put(Contenido value);
        void Delete(int id);
    }
}
