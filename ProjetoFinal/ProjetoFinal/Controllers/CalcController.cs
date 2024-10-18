using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Calc()
        {
            return View();
        }
    }
}
