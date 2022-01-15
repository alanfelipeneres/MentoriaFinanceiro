using Microsoft.AspNetCore.Mvc;

namespace MentoriaFinanceiro.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
