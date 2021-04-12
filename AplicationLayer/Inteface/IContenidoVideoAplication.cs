using AplicationLayer.Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IContenidoVideoAplication
    {
        List<ContenidoVideo> Get();
        ContenidoVideo Get(int id);
        void Post(ContenidoVideo value);
        void Put(ContenidoVideo value);
        void Delete(int id);
    }
}
