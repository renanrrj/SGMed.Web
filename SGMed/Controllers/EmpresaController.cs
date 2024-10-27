using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGMed.Dados;
using SGMed.Models;

namespace SGMed.Controllers
{
    public class EmpresaController : Controller
    {
        readonly private Contexto _bd;

        public EmpresaController (Contexto bd)
        {
            _bd = bd;
        }

        // GET: EmpresaController -------------------------
        public ActionResult IndexEmpresa()
        {
            IEnumerable<EmpresaModel> Empresa = _bd.Tb_Empresa;
            return View(Empresa);
        }

        // GET: EmpresaController/Details/5 -------------------
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpresaController/Create ----------------------------
        public ActionResult Create()
        {
           return View();
        }

        // POST: EmpresaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpresaModel oEmpresa)
        {
            if (ModelState.IsValid)
            {
                _bd.Tb_Empresa.Add(oEmpresa);
                _bd.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: EmpresaController/Edit/5 -------------------------------
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmpresaModel Empresa = _bd.Tb_Empresa.FirstOrDefault(c => c.IdEmpresa == id);

            if (Empresa == null);

            return View(Empresa);
        }

        // POST: EmpresaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpresaModel oEmpresa)
        {
            if (ModelState.IsValid)
            {
                var oEmpresaDb = _bd.Tb_Empresa.Find(oEmpresa.IdEmpresa);

                oEmpresaDb.NomeEmpresa = oEmpresa.NomeEmpresa;
                oEmpresaDb.CNPJ = oEmpresa.CNPJ;                
                oEmpresaDb.EnderecoEmpresa = oEmpresa.EnderecoEmpresa;

                _bd.Tb_Empresa.Update(oEmpresaDb);
                _bd.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: EmpresaController/Delete/5 --------------------------------
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmpresaModel Empresa = _bd.Tb_Empresa.FirstOrDefault(x => x.IdEmpresa == id);

            if (Empresa == null)
            {
                return NotFound();
            }

            return View(Empresa);
        }

        // POST: EmpresaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmpresaModel oEmpresa)
        {
            if (oEmpresa == null)
            {
                return NotFound();
            }

            _bd.Tb_Empresa.Remove(oEmpresa);
            _bd.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
