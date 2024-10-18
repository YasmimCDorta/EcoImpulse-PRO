using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdicionarProd.Controllers
{
    public class AdicController : Controller
    {
        public IActionResult Adic()
        {
            return View(); // Certifique-se de que a View Index.cshtml está na pasta correta
        }
    }

}
