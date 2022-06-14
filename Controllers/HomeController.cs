using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atv_4.Models;

namespace Atv_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.TestarConexao();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult QuemSomos()
        {
            return View();
        }
        public IActionResult Produto()
        {
            return View();
        }
        public IActionResult Servico()
        {
            return View();
        }
        public IActionResult Fotos()
        {
            return View();
        }
        public IActionResult Videos()
        {
            return View();
        }
        public IActionResult Parceiros()
        {
            return View();
        }
        public IActionResult FaleConosco()
        {
            return View();
        }
    }

}
