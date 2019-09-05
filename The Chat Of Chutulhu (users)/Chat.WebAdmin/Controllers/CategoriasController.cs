using Chat.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chat.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriaBL _categoriasBL;
        public CategoriasController()
        {
            _categoriasBL = new CategoriaBL();

        }
        // GET: Categorias
        public ActionResult Index()
        {
            var lista_Cate = _categoriasBL.MostrarCategorias();
            return View(lista_Cate);
        }
        public ActionResult Crear()
        {
            var Nueva_Categoria = new Categoria();
            return View(Nueva_Categoria);
        }
        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
            _categoriasBL.GuardarCategoria(categoria);
            return RedirectToAction("Index");
        }
    }
}