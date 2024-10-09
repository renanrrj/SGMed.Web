using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGMed.Dados;
using SGMed.Models;

namespace SGMed.Controllers
{
    public class ExameController : Controller
    {
        readonly private Contexto _bd;

        public ExameController(Contexto bd)
        {
            _bd = bd;
        }

        // GET: EmpresaController -------------------------
        public ActionResult Index()
        {
            IEnumerable<ExameModel> Exame = _bd.Tb_Exame;
            return View(Exame);
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
        public ActionResult Create(ExameModel oExame)
        {
            if (ModelState.IsValid)
            {
                _bd.Tb_Exame.Add(oExame);
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

            ExameModel Empresa = _bd.Tb_Exame.FirstOrDefault(c => c.IdExame == id);

            if (Empresa == null) ;

            return View(Empresa);
        }

        // POST: EmpresaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ExameModel oExame)
        {
            if (ModelState.IsValid)
            {
                var oExameDb = _bd.Tb_Exame.Find(oExame.IdExame);

                oExameDb.DescricaoExame = oExame.DescricaoExame;               

                _bd.Tb_Exame.Update(oExameDb);
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

            ExameModel Exame = _bd.Tb_Exame.FirstOrDefault(x => x.IdExame == id);

            if (Exame == null)
            {
                return NotFound();
            }

            return View(Exame);
        }

        // POST: EmpresaController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(ExameModel oExame)
        {
            if (oExame == null)
            {
                return NotFound();
            }

            _bd.Tb_Exame.Remove(oExame);
            _bd.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
