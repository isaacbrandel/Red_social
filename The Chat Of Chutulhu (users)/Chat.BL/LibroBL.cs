using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BL
{
    public class LibroBL
    {
        Contexto _contexto;
        public List<Libro> ListaLibro { get; set; }
        public LibroBL()
        {
            _contexto = new Contexto();
            ListaLibro = new List<Libro>();
        }
        public List<Libro> MostrarLibros()
        {
            ListaLibro = _contexto.Libros.ToList();


            return ListaLibro;

        }
        public void GuardarLibro(Libro libro)
        {
            if (libro.Id == 0)
            {
                _contexto.Libros.Add(libro);
            }
            else
            {
                var LibroExistente = _contexto.Libros.Find(libro.Id);
                LibroExistente.Id = libro.Id;
                LibroExistente.Nombre = libro.Nombre;
                LibroExistente.Sipnosis = libro.Sipnosis;
            }

            _contexto.SaveChanges();
        }
        public Libro Mostrarlibros(int id)
        {
            var libro = _contexto.Libros.Find(id);
            return libro;
        }
        public void EliminarLibro(int id)
        {
            var libro = _contexto.Libros.Find(id);
            _contexto.Libros.Remove(libro);
            _contexto.SaveChanges();
        }
    }
}

