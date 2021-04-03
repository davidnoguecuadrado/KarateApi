using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DeportistasBaneados
    {
        public int ID { get; set; }
        public int? ClubID { get; set; }
        public int? DeportistaID { get; set; }
        public bool Estado { get; set; }

        public Deportista Deportista { get; set; }
        public Club Club { get; set; }

    }
}
