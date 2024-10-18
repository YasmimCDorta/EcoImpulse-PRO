using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Quiz()
        {
            return View();
        }
    }
}
