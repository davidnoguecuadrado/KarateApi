using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IUsuarioData
    {
        List<Usuario> Get();
        Usuario Get(int id);
        List<Usuario> ifExist(Usuario value);
        void Post(Usuario value);
        void Put(Usuario value);
        void Delete(Usuario id);
    }
}
