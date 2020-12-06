using LivroWeb.DAL;
using LivroWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivroWeb.Controllers
{
    public class LivroController : Controller
    {
        // GET: Livro
        private LivroDal livroDal;

        public LivroController(LivroDal livroDal)
        {
            this.livroDal = livroDal;
        }
        public ActionResult Form()
        {
            return View();
        }
        // GET: Livro
        public ActionResult Index()
        {
            return View(livroDal.Lista());
        }

        public ActionResult Adiciona(Livro livro)
        {
            if (ModelState.IsValid)
            {
                livroDal.Adiciona(livro);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", livro);
            }
        }
    }
}