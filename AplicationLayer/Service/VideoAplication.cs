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
    public class VideoAplication : IVideoAplication
    {
        private readonly IVideoData _videoData;
        public VideoAplication(IVideoData videoData)
        {
            _videoData = videoData;
        }
        public void Delete(int id)
        {
            var contenido = _videoData.Get(id);

            _videoData.Delete(contenido);
        }

        public List<Video> Get()
        {
            return _videoData.Get();
        }

        public Video Get(int id)
        {
            return _videoData.Get(id);
        }

        public void Post(Video value)
        {
            _videoData.Post(value);
        }

        public void Put(Video value)
        {
            _videoData.Put(value);
        }
    }
}
