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

        [HttpGet]
        public IActionResult Cadastrar(int? id)
        {
            if(id.HasValue && Usuario.Listagem.Any<Usuario>(u => u.IdUsuario == id))
            {
                var usuario = Usuario.Listagem.Single<Usuario>(u => u.IdUsuario == id);
                return View(usuario);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            Usuario.Salvar(usuario);
            return RedirectToAction("Usuarios");
        }

        public IActionResult Usuarios()
        {
            return View(Usuario.Listagem);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if(id.HasValue && Usuario.Listagem.Any<Usuario>(u => u.IdUsuario == id))
            {
                var usuario = Usuario.Listagem.Single<Usuario>(u => u.IdUsuario == id);
                return View(usuario);
            }
            return RedirectToAction("Usuarios");
        }

        [HttpPost]
        public IActionResult Excluir(Usuario usuario)
        {
            Usuario.Excluir(usuario);
            return RedirectToAction("Usuarios");
        }
    }
}