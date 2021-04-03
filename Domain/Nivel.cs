using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Nivel
    {
        public int ID { get; set; }
        public int ClubCategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Img { get; set; }

        public ClubCategoria ClubCategoria { get; set; }

    }
}
