using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IContenidoVideoData
    {
        void Delete(ContenidoVideo id);
        List<ContenidoVideo> Get();
        ContenidoVideo Get(int id);
        void Post(ContenidoVideo value);
        void Put(ContenidoVideo value);
    }
}