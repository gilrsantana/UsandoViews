using System.Resources;
using Microsoft.AspNetCore.Mvc;
using UsandoViews.Models;

namespace UsandoViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
		{
			return View();
		}

        public IActionResult Cadastrar()
        {
            return View("FormUsuario", Usuario.Listagem.Single(u => u.Id == 1));
        }
    }
}