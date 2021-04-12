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
    public class InvitacionesAplication : IInvitacionesAplication
    {
        private readonly IInvitacionesData _invitacionesData;
        public InvitacionesAplication(IInvitacionesData invitacionesData)
        {
            _invitacionesData = invitacionesData;
        }
        public void Delete(int id)
        {
            var contenido = _invitacionesData.Get(id);

            _invitacionesData.Delete(contenido);
        }

        public List<Invitaciones> Get()
        {
            return _invitacionesData.Get();
        }

        public Invitaciones Get(int id)
        {
            return _invitacionesData.Get(id);
        }

        public void Post(Invitaciones value)
        {
            _invitacionesData.Post(value);
        }

        public void Put(Invitaciones value)
        {
            _invitacionesData.Put(value);
        }
    }
}
