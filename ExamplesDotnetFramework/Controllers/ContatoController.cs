using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamplesDotnetFramework.Models;

namespace ExamplesDotnetFramework.Controllers
{
    public class ContatoController : Controller
    {
        static IList<Contato> contatos = new List<Contato>
        { 
            new Contato()
            {
                codigo = 1,
                nome = "Beltrano",
                telefone = "(11) 99999-9999",
                dataNascimento = new DateTime(1985, 03, 12)
            },
            new Contato()
            {
                codigo = 2,
                nome = "Fulano",
                telefone = "(21) 88888-8888",
                dataNascimento = new DateTime(1994, 01, 29)
            },
            new Contato()
            {
                codigo = 3,
                nome = "Sicrano",
                telefone = "(37) 99999-8888",
                dataNascimento = new DateTime(1994, 01, 29)
            }
        };
        private static int codigo = 4;

        public ContatoController() { }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contato contato)
        {
            contato.codigo = codigo++;
            contatos.Add(contato);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Retrieve(int codigo)
        {
            Contato contato = contatos.Where(c => c.codigo == codigo).FirstOrDefault();
            return View(contato);
        }

        [HttpPost]
        public ActionResult Retrieve(Contato contato)
        {
            Contato db = contatos.Where(c => c.codigo == contato.codigo).FirstOrDefault();
            if (db != null)
            {
                db.nome = contato.nome;
                db.telefone = contato.telefone;
                db.dataNascimento = contato.dataNascimento;

            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int codigo)
        {
            Contato contato = contatos.Where(c => c.codigo == codigo).FirstOrDefault();
            if (contato != null)
            {
                contatos.Remove(contato);
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(contatos);
        }

    }
}