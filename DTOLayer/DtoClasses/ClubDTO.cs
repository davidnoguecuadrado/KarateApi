using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DtoClasses
{
    public class ClubDTO
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public int Nombre { get; set; }
        public string Clave { get; set; }
    }
}
