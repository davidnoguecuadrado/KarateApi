using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Deportista
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }

        public Usuario Usuario { get; set; }
    }
}
