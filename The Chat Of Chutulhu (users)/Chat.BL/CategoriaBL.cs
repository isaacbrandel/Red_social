using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BL
{
    public class CategoriaBL
    {

        Contexto _contexto;
        public List<Categoria> ListaCategoria { get; set; }
        public CategoriaBL()
        {
            _contexto = new Contexto();
            ListaCategoria = new List<Categoria>();
        }
        public List<Categoria> MostrarCategorias()
        {
            ListaCategoria = _contexto.Categorias.ToList();


            return ListaCategoria;
            
        }
    }
}
