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
        public CategoriaBL()
        {
            _contexto = new Contexto();
        }
        public List<Categoria> MostrarCategorias()
        {
            
            
            return _contexto.Categorias.ToList(); ;
        }
    }
}
