using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IInvitacionesData
    {
        List<Invitaciones> Get();
        Invitaciones Get(int id);
        void Post(Invitaciones value);
        void Put(Invitaciones value);
        void Delete(Invitaciones id);
    }
}
