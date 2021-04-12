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
    public class ClubAplication : IClubAplication
    {
        private IClubData _clubData;

        public ClubAplication(IClubData clubData) {
            _clubData = clubData;
        }

        public void Delete(int id)
        {
            var club = _clubData.Get(id);
            _clubData.Delete(club);
        }

        public List<Club> Get()
        {
           return _clubData.Get();
        }

        public Club Get(int id)
        {
            var club = _clubData.Get(id);
            return club;
        }

        public void Post(Club value)
        {
            _clubData.Post(value);
        }

        public void Put(Club value)
        {
            _clubData.Put(value);
        }
    }
}
