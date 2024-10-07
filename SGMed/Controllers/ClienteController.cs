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
        public ActionResult Index()
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

                return RedirectToAction("Home"); 
            }
            return View();
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
