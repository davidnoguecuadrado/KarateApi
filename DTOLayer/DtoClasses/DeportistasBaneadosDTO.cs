using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DtoClasses
{
    public class DeportistasBaneadosDTO
    {
        public int ID { get; set; }
        public int? ClubID { get; set; }
        public int? DeportistaID { get; set; }
        public bool Estado { get; set; }
    }
}
