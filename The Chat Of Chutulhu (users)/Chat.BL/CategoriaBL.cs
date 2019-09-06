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
        public void GuardarCategoria(Categoria categoria)
        {    if(categoria.ID== 0)
            {
                _contexto.Categorias.Add(categoria);
            }
            else
            {
                var categoriaExistente = _contexto.Categorias.Find(categoria.ID);
                categoriaExistente.Nombre = categoria.Nombre;
                categoriaExistente.Descripcion = categoria.Descripcion;
            }
          
            _contexto.SaveChanges();
        }  
        public Categoria MostrarCategorias(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            return categoria;
        }
        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }
}
