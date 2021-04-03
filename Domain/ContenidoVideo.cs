using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ContenidoVideo
    {
        public int ID { get; set; }
        public int ContenidoID { get; set; }
        public int VideoID { get; set; }

        public Contenido Contenido { get; set; }
        public Video Video { get; set; }
    }
}
