using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DeportistaClub
    {
        public int ID { get; set; }
        public int? ClubID { get; set; }
        public int? DeportistaID { get; set; }
        public int Estado { get; set; }

        public Club Club { get; set; }
        public Deportista Deportista { get; set; }

    }
}

