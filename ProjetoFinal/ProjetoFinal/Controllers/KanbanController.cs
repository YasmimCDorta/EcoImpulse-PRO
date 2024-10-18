using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal.Controllers
{
    public class KanbanController : Controller
    {
        public IActionResult Kanban()
        {
            return View();
        }
    }
}
