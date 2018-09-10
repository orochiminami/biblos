using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblos.Controllers
{
    public class LivroController : Controller
    {
        public static List<Livro> Livros { get; set; }

        public LivroController(){
            if(Livros == null)
            {
                Livros = new List<Livro>
                {
                    new Livro(Guid.NewGuid(), "A1", "Eu", 2010, "Some", "Adulto", "12313", true)
                };
            }
        }

        public IActionResult Index()
        {
            return View(Livros);
        }

        public IActionResult Adicionar()
        {
            return View("Adicionar", new Livro());
        }

        [HttpPost]
        public IActionResult Salvar(Livro model)
        {
            if (ModelState.IsValid)
            {
                model.Codigo = Guid.NewGuid();
                model.Disponivel = true;
                Livros.Add(model);
            }

            return View("Index", Livros);
        }
    }
}