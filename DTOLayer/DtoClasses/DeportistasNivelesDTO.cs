using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DtoClasses
{
    public class DeportistasNivelesDTO
    {
        public int ID { get; set; }
        public int? DeportistaID { get; set; }
        public int? NivelID { get; set; }
        public string Clave { get; set; }
    }
}
