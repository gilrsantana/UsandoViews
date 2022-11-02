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

        public IActionResult Cadastrar(int? id)
        {
            if(id.HasValue && Usuario.Listagem.Any<Usuario>(u => u.Id == id))
            {
                var usuario = Usuario.Listagem.Single<Usuario>(u => u.Id == id);
                return View(usuario);
            }
            return View();
        }
    }
}