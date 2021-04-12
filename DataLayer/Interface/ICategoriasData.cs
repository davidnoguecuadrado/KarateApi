using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface ICategoriasData
    {
        List<Categorias> Get();
        Categorias Get(int id);
        void Post(Categorias value);
        void Put(Categorias value);
        void Delete(Categorias id);
    }
}
