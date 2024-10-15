using Microsoft.AspNetCore.Mvc;

namespace SGMed.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult CreateConsulta()
        {
            return View();
        }
    }
}
