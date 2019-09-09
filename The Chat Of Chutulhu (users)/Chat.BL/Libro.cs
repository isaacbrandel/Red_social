using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese la Sipnosis")]
        public String Sipnosis { get; set; }
        public int ListaCategoria { get; set; }
        /*[Required(ErrorMessage = "Seleccione la Categoria")]*/
        public Categoria Categoria { get; set; }
        [Display(Name = "Imagen")]
        public string Urlimag { get; set; }
        public int descargaId { get; set; }
        public Descarga descarga { get; set; }

        public bool Activo { get; set; }
    }
}
