using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGMed.Dados;
using SGMed.Models;

namespace SGMed.Controllers
{
    public class ClienteController : Controller
    {
        readonly private Contexto _bd;

        public ClienteController(Contexto bd)
        {
            _bd = bd;
        }

        // GET: ClienteController
        public ActionResult IndexCliente()
        {
            IEnumerable<ClienteModel> Cliente = _bd.Tb_Cliente;
            return View(Cliente);
        }


        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModel Cliente)
        {
            if (ModelState.IsValid)
            {
                _bd.Tb_Cliente.Add(Cliente);
                _bd.SaveChanges();

                return RedirectToAction("IndexCliente"); 
            }
            return View();
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel Cliente = _bd.Tb_Cliente.FirstOrDefault(c => c.IdCliente == id);

            if (Cliente == null);

            return View(Cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteModel oCliente)
        {
            if (ModelState.IsValid)
            {
                var oClienteDb = _bd.Tb_Cliente.Find(oCliente.IdCliente);

                oClienteDb.NomeCompleto = oCliente.NomeCompleto;
                oClienteDb.DataNascimento = oCliente.DataNascimento;
                oClienteDb.CPF = oCliente.CPF;
                oClienteDb.EnderecoCliente = oCliente.EnderecoCliente;

                _bd.Tb_Cliente.Update(oClienteDb);
                _bd.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel cliente = _bd.Tb_Cliente.FirstOrDefault(x => x.IdCliente == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteModel oCliente)
        {
            if (oCliente == null)
            {
                return NotFound();
            }

            _bd.Tb_Cliente.Remove(oCliente);
            _bd.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
