using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DeportistasNiveles
    {
        public int ID { get; set; }
        public int? DeportistaID { get; set; }
        public int? NivelID { get; set; }
        public string Clave { get; set; }

        public Deportista Deportistas { get; set; }
        public Nivel Nivel { get; set; }

    }
}
