using Microsoft.AspNetCore.Mvc;
using ViaCepMvc.Models;

namespace ViaCepMvc.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult    Confirmar(Endereco model)
        {
            return View("Detalhes", model);
        }

        public IActionResult Detalhes(Endereco model)
        {
            return View(model);
        }
    }
}