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
    public class DeportistaClubAplication : IDeportistaClubAplication
    {

        private readonly IDeportistaClubData _deportistaClubData;
        public DeportistaClubAplication(IDeportistaClubData deportistaClubData) {
            _deportistaClubData = deportistaClubData;
        }
        public void Delete(int id)
        {
            var contenido = _deportistaClubData.Get(id);

            _deportistaClubData.Delete(contenido);
        }

        public List<DeportistaClub> Get()
        {
            return _deportistaClubData.Get();
        }

        public DeportistaClub Get(int id)
        {
            return _deportistaClubData.Get(id);
        }

        public void Post(DeportistaClub value)
        {
            _deportistaClubData.Post(value);
        }

        public void Put(DeportistaClub value)
        {
            _deportistaClubData.Put(value);
        }
    }
}
