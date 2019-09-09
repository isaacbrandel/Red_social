﻿using System;
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
            ListaLibro = _contexto.Libros
                .Include("Categoria")
                .ToList();



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
                LibroExistente.Categoria = libro.Categoria;
                LibroExistente.Sipnosis = libro.Sipnosis;
                LibroExistente.ListaCategoria = libro.ListaCategoria;
                LibroExistente.Urlimag = libro.Urlimag;
            }

            _contexto.SaveChanges();
        }
        public Libro Mostrarlibros(int id)
        {
                 var libro = _contexto.Libros.Include("Categoria").FirstOrDefault(p => p.Id == id);
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

