using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OCTOTeste.Database;
using OCTOTeste.Models;
using X.PagedList;

namespace OCTOTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _db;

        public HomeController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? pagina)
        {
            var clients = _db.Clientes.ToList();
            var resultadoPaginado = clients.ToPagedList(pagina ?? 1, 10);

            return View(resultadoPaginado);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View("Cadastro", new Cliente());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                TempData["Mensagem"] = "Cliente cadastrado com sucesso!";

                return RedirectToAction("Index");
            }

            return View("Cadastro", cliente);
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            var cliente = _db.Clientes.Find(Id);
            return View("Cadastro", cliente);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(cliente);
                _db.SaveChanges();

                TempData["Mensagem"] = "Cliente atualizado com sucesso!";

                return RedirectToAction("Index");
            }

            return View("Cadastro", cliente);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            var cliente = _db.Clientes.Find(Id);
            _db.Clientes.Remove(cliente);
            _db.SaveChanges();

            TempData["Mensagem"] = "Cliente excluído com sucesso!";

            return RedirectToAction("Index");
        }
    }
}