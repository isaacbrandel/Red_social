﻿using Chat.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.WebAdmin.Controllers
{
    public class LibroController : Controller
    {
        LibroBL _libroBL;
        CategoriaBL _categoriasBL;
        public LibroController()
        {
            _libroBL= new LibroBL();
            _categoriasBL = new CategoriaBL();

        }
        // GET: Libro
        public ActionResult Index()
        {
            var lista_libros = _libroBL.MostrarLibros();
            return View(lista_libros);
        }
        public ActionResult Crear()
        {
            var Nuevo_libro = new Libro();
            var Categoria = _categoriasBL.MostrarCategorias();
           ViewBag.ListaCategoria = new SelectList(Categoria, "ID", "Nombre");
            return View(Nuevo_libro);
        }


        [HttpPost]
        public ActionResult Crear(Libro libro, HttpPostedFileBase imagen)
        {
        
            if (ModelState.IsValid)
            {
                _libroBL.GuardarLibro(libro);
                return RedirectToAction("Index");
            }
            if (imagen != null)
            {
                libro.Urlimag = GuardarImagen(imagen);
            }
                var Categoria = _categoriasBL.MostrarCategorias();
            ViewBag.ListaCategoria = new SelectList(Categoria, "ID", "Nombre");
            return View(libro);
        }
        public ActionResult Editar(int id)
        {
            var libro = _libroBL.Mostrarlibros(id);

            return View(libro);
        }
        [HttpPost]
        public ActionResult Editar(Libro libro)
        {
            _libroBL.GuardarLibro(libro);
            return RedirectToAction("Index");
        }
        public ActionResult Detalle(int id)
        {
            var libro = _libroBL.Mostrarlibros(id);

            return View(libro);
        }
        public ActionResult Eliminar(int id)
        {
            var libro = _libroBL.Mostrarlibros(id);

            return View(libro);
        }
        [HttpPost]
        public ActionResult Eliminar(Libro libro)
        {
            _libroBL.EliminarLibro(libro.Id);
            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);
            return "/Imagenes/" + imagen.FileName;
        }


    }
}