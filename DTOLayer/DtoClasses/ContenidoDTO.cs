using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DtoClasses
{
    public class ContenidoDTO
    {
        public int ID { get; set; }
        public int NivelID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Img { get; set; }
    }
}
