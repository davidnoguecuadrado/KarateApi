using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UsuarioDTO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Correo { get; set; }
        public int Password { get; set; }
    }
}
