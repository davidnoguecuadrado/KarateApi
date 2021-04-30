using AplicationLayer.Inteface;
using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Service
{
    public class UsuarioAplication : IUsuarioAplication
    {
        private readonly IUsuarioData _usuarioData;
        public UsuarioAplication(IUsuarioData usuarioData)
        {
            _usuarioData = usuarioData;
        }
        public void Delete(int id)
        {
            var contenido = _usuarioData.Get(id);

            _usuarioData.Delete(contenido);
        }

        public List<Usuario> Get()
        {
            return _usuarioData.Get();
        }

        public Usuario Get(int id)
        {
            return _usuarioData.Get(id);
        }

        public void Post(Usuario value)
        {
            byte[] encode = new byte[value.Password.Length];
            encode = Encoding.UTF8.GetBytes(value.Password);
            value.Password = Convert.ToBase64String(encode);
            _usuarioData.Post(value);
        }

        public bool ifExist(Usuario value)
        {

            byte[] encode = new byte[value.Password.Length];
            encode = Encoding.UTF8.GetBytes(value.Password);
            value.Password = Convert.ToBase64String(encode);
            var usr  = _usuarioData.ifExist(value);
            if (usr.ToArray().Length != 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void Put(Usuario value)
        {
            _usuarioData.Put(value);
        }
    }
}
