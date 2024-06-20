using Microsoft.AspNetCore.Mvc;

namespace CadastroDeCliente.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
