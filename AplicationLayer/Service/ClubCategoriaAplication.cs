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
    public class ClubCategoriaAplication : IClubCategoriaAplication
    {

        private readonly IClubCategoriaData _clubCategoriaData;
        public ClubCategoriaAplication(IClubCategoriaData clubCategoriaData) {
            _clubCategoriaData = clubCategoriaData;
        }
        public void Delete(int id)
        {
            var club = _clubCategoriaData.Get(id);

            _clubCategoriaData.Delete(club);
        }

        public List<ClubCategoria> Get()
        {
            return _clubCategoriaData.Get();
        }

        public ClubCategoria Get(int id)
        {
            return _clubCategoriaData.Get(id);
        }

        public void Post(ClubCategoria value)
        {
            _clubCategoriaData.Post(value);
        }

        public void Put(ClubCategoria value)
        {
            _clubCategoriaData.Put(value);
        }
    }
}
