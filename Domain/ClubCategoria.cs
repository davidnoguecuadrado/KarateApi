using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ClubCategoria
    {
        public int ID { get; set; }
        public int ClubID { get; set; }
        public int CategoriasID { get; set; }

        public Club Club { get; set; }
        public Categorias Categorias { get; set; }
    }
}
