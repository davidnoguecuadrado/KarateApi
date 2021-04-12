using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IVideoData
    {
        List<Video> Get();
        Video Get(int id);
        void Post(Video value);
        void Put(Video value);
        void Delete(Video id);
    }
}
