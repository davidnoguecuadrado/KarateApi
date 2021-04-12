using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer.Inteface
{
    public interface IVideoAplication
    {
        List<Video> Get();
        Video Get(int id);
        void Post(Video value);
        void Put(Video value);
        void Delete(int id);
    }
}
