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
            _usuarioData.Post(value);
        }

        public void Put(Usuario value)
        {
            _usuarioData.Put(value);
        }
    }
}
