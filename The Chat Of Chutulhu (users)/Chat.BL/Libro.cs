using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BL
{
    public class Libro
    {
        public Libro()
        {
            Activo = true;
        }
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Sipnosis { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
