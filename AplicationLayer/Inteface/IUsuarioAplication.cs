using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IUsuarioAplication
    {
        List<Usuario> Get();
        Usuario Get(int id);
        void Post(Usuario value);
        void Put(Usuario value);
        void Delete(int id);
    }
}

