using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IInvitacionesAplication
    {
        List<Invitaciones> Get();
        Invitaciones Get(int id);
        void Post(Invitaciones value);
        void Put(Invitaciones value);
        void Delete(int id);
    }
}
